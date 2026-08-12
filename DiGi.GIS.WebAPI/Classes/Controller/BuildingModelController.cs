using DiGi.Analytical.Building.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Analytical.Enums;
using DiGi.GIS.PostgreSQL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.GIS.WebAPI.Classes
{
    /// <summary>
    /// Web API controller for building model operations, providing endpoints to retrieve building model data.
    /// </summary>
    [ApiController]
    [Route("gis/[controller]")]
    public class BuildingModelController : DiGi.WebAPI.Classes.WebAPIController
    {
        private readonly PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter administrativeAreal2DPostgreSQLConverter;
        private readonly PostgreSQL.Classes.Building2DPostgreSQLConverter building2DPostgreSQLConverter; //Resolves the spatial query to Building2D references, which key the building model lookup.
        private readonly PostgreSQL.Classes.BuildingModelPostgreSQLConverter buildingModelPostgreSQLConverter;
        private readonly GISWebAPIConfigurationFileWatcher GISWebAPIConfigurationFileWatcher;

        /// <summary>Initializes a new instance of the <see cref="BuildingModelController"/> class.</summary>
        /// <param name="GISWebAPIConfigurationFileWatcher">The configuration file watcher for the GIS PostgreSQL Web API.</param>
        /// <param name="buildingModelPostgreSQLConverter">The converter used for building model data operations in PostgreSQL.</param>
        /// <param name="building2DPostgreSQLConverter">The converter used for Building 2D data operations in PostgreSQL.</param>
        /// <param name="administrativeAreal2DPostgreSQLConverter">The converter used to resolve an administrative area code to its county identifier.</param>
        public BuildingModelController(GISWebAPIConfigurationFileWatcher GISWebAPIConfigurationFileWatcher, PostgreSQL.Classes.BuildingModelPostgreSQLConverter buildingModelPostgreSQLConverter, PostgreSQL.Classes.Building2DPostgreSQLConverter building2DPostgreSQLConverter, PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter administrativeAreal2DPostgreSQLConverter)
        {
            this.GISWebAPIConfigurationFileWatcher = GISWebAPIConfigurationFileWatcher;
            this.building2DPostgreSQLConverter = building2DPostgreSQLConverter;
            this.buildingModelPostgreSQLConverter = buildingModelPostgreSQLConverter;
            this.administrativeAreal2DPostgreSQLConverter = administrativeAreal2DPostgreSQLConverter;
        }

        /// <summary> Retrieves the building models stored in the database for all buildings within a specified circle. </summary>
        /// <param name="x">The X-coordinate of the center point of the search circle.</param>
        /// <param name="y">The Y-coordinate of the center point of the search circle.</param>
        /// <param name="radius">The radius of the search circle. This value can be null.</param>
        /// <param name="diameter">The diameter of the search circle. This value can be null.</param>
        /// <param name="tolerance">An optional tolerance value for the spatial query. If not provided, the default distance tolerance is used.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by the caller to cancel the asynchronous operation.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        [HttpGet("itemsbycircle", Name = $"{nameof(BuildingModelController)}_{nameof(GetItemsByCircleAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(List<BuildingModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetItemsByCircleAsync([FromQuery(Name = "x")] double x, [FromQuery(Name = "y")] double y, [FromQuery(Name = "radius")] double? radius, [FromQuery(Name = "diameter")] double? diameter, [FromQuery(Name = "tolerance")] double? tolerance = Core.Constants.Tolerance.Distance, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(BuildingModelController), nameof(GetItemsByCircleAsync));
            if (double.IsNaN(x) || double.IsNaN(y))
            {
                return BadRequest();
            }

            if ((radius is null || !radius.HasValue || double.IsNaN(radius.Value)) && (diameter is null || !diameter.HasValue || double.IsNaN(diameter.Value)))
            {
                return BadRequest();
            }

            double radius_Temp = double.NaN;
            if (radius is not null && !double.IsNaN(radius.Value))
            {
                radius_Temp = radius.Value;
            }

            if (double.IsNaN(radius_Temp))
            {
                if (diameter is not null && !double.IsNaN(diameter.Value))
                {
                    radius_Temp = diameter.Value / 2;
                }
            }

            if (double.IsNaN(radius_Temp))
            {
                return BadRequest();
            }

            if (tolerance is null || double.IsNaN(tolerance.Value))
            {
                tolerance = Core.Constants.Tolerance.MacroDistance;
            }

            // Only the reference and the county are needed to key the building model lookup, so the lighter
            // reference query is used rather than pulling footprint geometry that would then be discarded.
            List<PostgreSQL.Classes.Building2DReference>? building2DReferences = await building2DPostgreSQLConverter.GetBuilding2DReferencesByCircle2DAsync(new Circle2D(new Point2D(x, y), radius_Temp), tolerance.Value, cancellationToken);
            if (building2DReferences is null || building2DReferences.Count == 0)
            {
                return NotFound();
            }

            Serilog.Modify.Log("Building2DReferences found within circle: {Count}", building2DReferences.Count);

            // The building model table is partitioned by county and the county is a mandatory filter, so the
            // references are grouped and each county is resolved in a single query.
            List<BuildingModel> buildingModels = [];
            foreach (IGrouping<int, PostgreSQL.Classes.Building2DReference> grouping in building2DReferences.Where(building2DReference => building2DReference.CountyId is not null && !string.IsNullOrWhiteSpace(building2DReference.Reference)).GroupBy(building2DReference => building2DReference.CountyId!.Value))
            {
                int countyId = grouping.Key;

                List<string> references = [.. grouping.Select(building2DReference => building2DReference.Reference!).Distinct()];

                List<PostgreSQL.Classes.Building2D>? building2Ds = await building2DPostgreSQLConverter.GetBuilding2DsByBuilding2DReferences(grouping);
                if (building2Ds is null || building2Ds.Count == 0)
                {
                    Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "No Building2Ds found for county {CountyId}. Requested references: {Count}", countyId, references.Count);
                    continue;
                }

                //Temporary solution till PostgreSQL.Classes.BuildingModel will have correct geometry
                List<PostgreSQL.Classes.BuildingModel?>? buildingModels_PostgreSQL = building2Ds.ConvertAll(building2D_PostgreSQL => Analytical.Create.BuildingModel(building2D_PostgreSQL?.ToDiGi()))?.ConvertAll(x => x.ToPostgreSQL(countyId));

                //TODO: Uncomment the following code when PostgreSQL.Classes.BuildingModel will have correct geometry
                //List<PostgreSQL.Classes.BuildingModel>? buildingModels_PostgreSQL = await buildingModelPostgreSQLConverter.GetItemsByReferencesAsync(references, countyId, null, cancellationToken);

                if (buildingModels_PostgreSQL is null || buildingModels_PostgreSQL.Count == 0)
                {
                    Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "No BuildingModels stored for county {CountyId}. Requested references: {Count}", countyId, references.Count);
                    continue;
                }

                Serilog.Modify.Log("BuildingModels read from database for county {CountyId}: {After}/{Before}", countyId, buildingModels_PostgreSQL.Count, references.Count);

                foreach (PostgreSQL.Classes.BuildingModel? buildingModel_PostgreSQL in buildingModels_PostgreSQL)
                {
                    BuildingModel? buildingModel = buildingModel_PostgreSQL?.ToDiGi();
                    if (buildingModel is null)
                    {
                        continue;
                    }

                    // The stored parameter holds the bare Building2D reference. Wrapping it back into a county
                    // qualified reference keeps the response identical to what the caller has always consumed,
                    // and is what lets a selected element be traced back to its building.
                    Core.Interfaces.IReference? reference = PostgreSQL.Create.Reference(buildingModel, null, countyId);
                    if (reference is not null)
                    {
                        buildingModel.SetValue(BuildingModelParameter.Reference, reference.ToString(), new Core.Parameter.Classes.SetValueSettings(true, false));
                    }

                    buildingModels.Add(buildingModel);
                }
            }

            if (buildingModels is null || buildingModels.Count == 0)
            {
                return NotFound();
            }

            Serilog.Modify.Log("BuildingModels resolved: {After}/{Before}", buildingModels.Count, building2DReferences.Count);

            string? json = Core.Convert.ToSystem_String(buildingModels);
            if (string.IsNullOrWhiteSpace(json))
            {
                return NotFound();
            }

            return Content(json, "application/json");
        }

        /// <summary> Retrieves building models stored in the database for the specified references. </summary>
        /// <param name="references">The building references identifying the building models to retrieve. This value can be null.</param>
        /// <param name="countyId">The optional county identifier used to narrow the search. This value can be null.</param>
        /// <param name="limit">The optional maximum number of building models to retrieve. This value can be null.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by the caller to cancel the asynchronous operation.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        [HttpGet("itemsbyreferences", Name = $"{nameof(BuildingModelController)}_{nameof(GetItemsByReferencesAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(List<BuildingModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetItemsByReferencesAsync([FromQuery(Name = "references")] IEnumerable<string>? references, [FromQuery(Name = "countyid")] int? countyId, [FromQuery(Name = "limit")] long? limit = null, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(BuildingModelController), nameof(GetItemsByReferencesAsync));
            Serilog.Modify.Log("CountyId provided: {CountyId}", countyId?.ToString() ?? string.Empty);
            if (references is null)
            {
                return BadRequest();
            }

            if (!references.Any())
            {
                return NoContent();
            }

            List<PostgreSQL.Classes.BuildingModel>? buildingModels_PostgreSQL = await buildingModelPostgreSQLConverter.GetItemsByReferencesAsync(references, countyId, limit, cancellationToken);
            if (buildingModels_PostgreSQL is null || buildingModels_PostgreSQL.Count == 0)
            {
                return NotFound();
            }

            List<BuildingModel> buildingModels = [];
            foreach (PostgreSQL.Classes.BuildingModel buildingModel_PostgreSQL in buildingModels_PostgreSQL)
            {
                BuildingModel? buildingModel = buildingModel_PostgreSQL?.ToDiGi();
                if (buildingModel is null)
                {
                    continue;
                }

                buildingModels.Add(buildingModel);
            }

            if (buildingModels is null || buildingModels.Count == 0)
            {
                return NotFound();
            }

            string? json = Core.Convert.ToSystem_String(buildingModels);
            if (string.IsNullOrWhiteSpace(json))
            {
                return NotFound();
            }

            return Content(json, "application/json");
        }

        /// <summary>
        /// Updates multiple building model items in the database, keyed by administrative area code.
        /// <para>A county code does not identify a single county row: BDOT10k stores a county whose territory is disconnected as one feature per polygon part, and every part becomes its own row. This action files the whole batch under the lowest matching row and warns when the code was ambiguous. Prefer <see cref="UpdateItemsByCountyIdAsync"/>, which leaves the server nothing to guess.</para>
        /// </summary>
        /// <param name="jsonArray">The JSON array containing the building models to be updated. This value can be null.</param>
        /// <param name="code">The administrative area code the building models belong to, resolved server-side to a county identifier.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        [HttpPost("updateitems", Name = $"{nameof(BuildingModelController)}_{nameof(UpdateItemsAsync)}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateItemsAsync([FromBody] JsonArray? jsonArray, [FromQuery(Name = "code")] string? code)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(BuildingModelController), nameof(UpdateItemsAsync));
            Serilog.Modify.Log("Code provided: {Code}", code ?? string.Empty);

            if (!GISWebAPIConfigurationFileWatcher.AllowUpdateBuildingModel)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "BuildingModel update not allowed");
                return Unauthorized();
            }

            if (string.IsNullOrWhiteSpace(code))
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Code cannot be null or empty");
                return BadRequest();
            }

            if (administrativeAreal2DPostgreSQLConverter is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "AdministrativeAreal2DPostgreSQLConverter is null");
                return BadRequest();
            }

            if (jsonArray is null || jsonArray.Count == 0)
            {
                Serilog.Modify.Log("No BuildingModels to update");
                return NoContent();
            }

            HashSet<int>? countyIds = await administrativeAreal2DPostgreSQLConverter.GetIdsByCodeAsync(code, PostgreSQL.Enums.AdministrativeArealType.County);
            if (countyIds is null || countyIds.Count == 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "County code '{Code}' was not found in database", code);
                return BadRequest();
            }

            int countyId_Resolved = countyIds.Min();

            // Resolving an ambiguous code silently is what let the skew in this table go unnoticed: the
            // upload reported success while everything filed under a sibling row read back empty.
            if (countyIds.Count > 1)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "County code '{Code}' matches {Count} rows ({CountyIds}) because the county has that many polygon parts. The whole batch is being filed under {CountyId}; post to 'updateitemsbycountyid' to pick the part yourself", code, countyIds.Count, string.Join(", ", countyIds.OrderBy(x => x)), countyId_Resolved);
            }

            return await UpdateItemsByCountyIdAsync(jsonArray, countyId_Resolved);
        }

        /// <summary>
        /// Updates multiple building model items in the database for an explicitly identified county row.
        /// <para>The unambiguous counterpart of <see cref="UpdateItemsAsync"/>: a multi-part county holds one row per polygon part, and passing the identifier states which part the batch belongs to rather than leaving the server to choose one.</para>
        /// </summary>
        /// <param name="jsonArray">The JSON array containing the building models to be updated. This value can be null.</param>
        /// <param name="countyId">The identifier of the county row the building models belong to.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        [HttpPost("updateitemsbycountyid", Name = $"{nameof(BuildingModelController)}_{nameof(UpdateItemsByCountyIdAsync)}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateItemsByCountyIdAsync([FromBody] JsonArray? jsonArray, [FromQuery(Name = "countyid")] int countyId)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(BuildingModelController), nameof(UpdateItemsByCountyIdAsync));
            Serilog.Modify.Log("CountyId provided: {CountyId}", countyId);

            if (!GISWebAPIConfigurationFileWatcher.AllowUpdateBuildingModel)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "BuildingModel update not allowed");
                return Unauthorized();
            }

            if (jsonArray is null || jsonArray.Count == 0)
            {
                Serilog.Modify.Log("No BuildingModels to update");
                return NoContent();
            }

            List<BuildingModel>? buildingModels = Core.Create.SerializableObjects<BuildingModel>(jsonArray);
            if (buildingModels is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "BuildingModels could not be converted from json");
                return BadRequest();
            }

            Serilog.Modify.Log("BuildingModels conversion to PostgreSQL started. BuildingModels count: {Count}", buildingModels.Count);

            List<PostgreSQL.Classes.BuildingModel> buildingModels_PostgreSQL = [];
            List<string> references_Rejected = [];

            foreach (BuildingModel buildingModel in buildingModels)
            {
                PostgreSQL.Classes.BuildingModel? buildingModel_PostgreSQL = PostgreSQL.Convert.ToPostgreSQL(buildingModel, countyId);
                if (buildingModel_PostgreSQL is null)
                {
                    // The converter refuses a model missing its reference or carrying geometry that cannot be
                    // used. Naming the models kept out of the database is what makes the next occurrence
                    // traceable - the corruption found in this table was silent precisely because nothing here
                    // reported the models it was letting through.
                    buildingModel.TryGetValue(BuildingModelParameter.Reference, out string? reference_Rejected);
                    references_Rejected.Add(string.IsNullOrWhiteSpace(reference_Rejected) ? buildingModel.UniqueId ?? "???" : reference_Rejected!);
                    continue;
                }

                buildingModels_PostgreSQL.Add(buildingModel_PostgreSQL);
            }

            if (references_Rejected.Count != 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "BuildingModels rejected before the database: {Count}/{Total}. References: {References}", references_Rejected.Count, buildingModels.Count, string.Join(", ", references_Rejected.GetRange(0, System.Math.Min(20, references_Rejected.Count))));
            }

            if (buildingModels_PostgreSQL is null || buildingModels_PostgreSQL.Count == 0)
            {
                Serilog.Modify.Log("No BuildingModels PostgreSQL to update");
                return NoContent();
            }

            Serilog.Modify.Log("BuildingModels conversion to PostgreSQL ended. BuildingModels converted: {After}/{Before}", buildingModels_PostgreSQL.Count, buildingModels.Count);

            Serilog.Modify.Log("Updating to database starting");

            HashSet<long>? ids = null;
            try
            {
                ids = await buildingModelPostgreSQLConverter.UpdateAsync(buildingModels_PostgreSQL);
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "Database could not be updated");
            }

            if (ids is null || ids.Count == 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Updating to database ended but no BuildingModels have been updated");
            }
            else
            {
                Serilog.Modify.Log("Updating to database ended. Updated BuildingModels: {After}/{Before}", ids?.Count ?? 0, buildingModels_PostgreSQL.Count);
            }

            return Ok();
        }
    }
}