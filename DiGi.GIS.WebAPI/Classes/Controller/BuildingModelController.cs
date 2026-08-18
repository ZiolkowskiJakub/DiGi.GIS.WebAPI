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
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
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

            List<BuildingModel>? buildingModels = Core.Create.SerializableObjects<BuildingModel>(jsonArray);
            if (buildingModels is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "BuildingModels could not be converted from json");
                return BadRequest();
            }

            if (countyIds.Count == 1)
            {
                return await UpdateAsync(buildingModels, countyIds.Min());
            }

            // A code names every polygon part of a multi-part county, so which part a model belongs to is
            // read from the 2D building it was created from rather than guessed. Filing the whole batch
            // under one part is what left sibling parts reading back empty while the upload reported success.
            List<int> countyIds_Sorted = [.. countyIds.OrderBy(x => x)];

            Serilog.Modify.Log("County code '{Code}' matches {Count} rows ({CountyIds}) because the county has that many polygon parts. Each model is being filed under the part its Building2D is stored in", code, countyIds.Count, string.Join(", ", countyIds_Sorted));

            Dictionary<string, List<BuildingModel>> buildingModels_ByReference = [];
            foreach (BuildingModel buildingModel in buildingModels)
            {
                if (!buildingModel.TryGetValue(BuildingModelParameter.Reference, out string? reference) || string.IsNullOrWhiteSpace(reference))
                {
                    continue;
                }

                if (!buildingModels_ByReference.TryGetValue(reference!, out List<BuildingModel>? buildingModels_Reference))
                {
                    buildingModels_Reference = [];
                    buildingModels_ByReference[reference!] = buildingModels_Reference;
                }

                buildingModels_Reference.Add(buildingModel);
            }

            Dictionary<int, List<BuildingModel>> buildingModels_ByCountyId = [];
            HashSet<string> references_Unresolved = [.. buildingModels_ByReference.Keys];

            // One batched lookup per part, lowest part first, so a reference held by more than one part
            // resolves to the same one every run.
            foreach (int countyId in countyIds_Sorted)
            {
                if (references_Unresolved.Count == 0)
                {
                    break;
                }

                List<PostgreSQL.Classes.Building2DReference> building2DReferences_Requested = [.. references_Unresolved.Select(x => new PostgreSQL.Classes.Building2DReference() { Reference = x, CountyId = countyId })];

                List<PostgreSQL.Classes.Building2DReference>? building2DReferences = await building2DPostgreSQLConverter.GetBuilding2DReferencesAsync(building2DReferences_Requested);
                if (building2DReferences is null)
                {
                    continue;
                }

                foreach (PostgreSQL.Classes.Building2DReference building2DReference in building2DReferences)
                {
                    string? reference = building2DReference.Reference;
                    if (string.IsNullOrWhiteSpace(reference) || !references_Unresolved.Remove(reference!))
                    {
                        continue;
                    }

                    if (!buildingModels_ByCountyId.TryGetValue(countyId, out List<BuildingModel>? buildingModels_County))
                    {
                        buildingModels_County = [];
                        buildingModels_ByCountyId[countyId] = buildingModels_County;
                    }

                    buildingModels_County.AddRange(buildingModels_ByReference[reference!]);
                }
            }

            if (references_Unresolved.Count != 0)
            {
                // No Building2D anywhere under this code means nothing states where the model belongs, and
                // storing it under a guessed part is exactly the state being repaired here.
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "BuildingModels not written because no Building2D under code '{Code}' carries their reference: {Count}/{Total}. References: {References}", references_Unresolved.Count, buildingModels.Count, string.Join(", ", references_Unresolved.Take(20)));
            }

            if (buildingModels_ByCountyId.Count == 0)
            {
                Serilog.Modify.Log("No BuildingModels to update");
                return NoContent();
            }

            foreach (KeyValuePair<int, List<BuildingModel>> keyValuePair in buildingModels_ByCountyId)
            {
                IActionResult actionResult = await UpdateAsync(keyValuePair.Value, keyValuePair.Key);
                if (actionResult is not OkResult)
                {
                    return actionResult;
                }
            }

            return Ok();
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
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
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

            return await UpdateAsync(buildingModels, countyId);
        }

        /// <summary>
        /// Writes the given building models to the partition of a single county row, replacing whatever those buildings already held there.
        /// <para>Shared by both update actions so the county row is resolved once, by the action, and this method never has to guess one.</para>
        /// <para><b>A post replaces rather than adds.</b> A model row is addressed by the identifier of the model it holds, and a model is handed a fresh one whenever it is created, so the write itself always appends - see <see cref="PostgreSQL.Classes.Building2DReferencedObject{TUniqueObject}"/>. Left at that, regenerating a county would add a model to every building instead of replacing its own, so what the buildings already held is read first and removed once the write has succeeded. A building therefore ends up holding exactly the models this call sent for it.</para>
        /// <para>The identifiers are read before the write and deleted after it, deliberately in that order: an interrupted call then leaves the building holding both its old and its new model, which is recoverable, rather than holding neither.</para>
        /// </summary>
        /// <param name="buildingModels">The building models to write.</param>
        /// <param name="countyId">The identifier of the county row the models belong to.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        private async Task<IActionResult> UpdateAsync(List<BuildingModel> buildingModels, int countyId)
        {
            Serilog.Modify.Log("BuildingModels conversion to PostgreSQL started. BuildingModels count: {Count}, CountyId: {CountyId}", buildingModels.Count, countyId);

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

            // What the building already holds is read before the write rather than deleted before it. A
            // model row is keyed on the model's own identifier and a model is handed a fresh one whenever it
            // is created, so a regeneration adds a row instead of replacing one and something has to take the
            // previous one out - without this a county regenerated twice holds two models per building.
            // Reading first and deleting last means a run that dies in between leaves the building holding
            // both its old and its new model, which is recoverable, rather than holding neither.
            HashSet<string> references_Written = [];
            foreach (PostgreSQL.Classes.BuildingModel buildingModel_PostgreSQL in buildingModels_PostgreSQL)
            {
                string? reference = buildingModel_PostgreSQL.Reference;
                if (!string.IsNullOrWhiteSpace(reference))
                {
                    references_Written.Add(reference!);
                }
            }

            HashSet<string>? uniqueIds_Superseded;
            try
            {
                uniqueIds_Superseded = await buildingModelPostgreSQLConverter.GetUniqueIdsByReferencesAsync(references_Written, countyId);
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "BuildingModels already stored for these references could not be read");
                return StatusCode(500, "Database read failed.");
            }

            // Writing without knowing what was already there is what grows the table silently, which is the
            // failure this whole arrangement exists to prevent. Refusing is louder and costs the caller a retry.
            if (uniqueIds_Superseded is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "BuildingModels already stored for these references could not be read - nothing was written");
                return StatusCode(500, "Database read returned no result.");
            }

            Serilog.Modify.Log("Updating to database starting");

            HashSet<long>? ids;
            try
            {
                ids = await buildingModelPostgreSQLConverter.UpdateAsync(buildingModels_PostgreSQL);
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "Database could not be updated");
                return StatusCode(500, "Database update failed.");
            }

            // Answering Ok here is what let a whole county regeneration report success while writing nothing:
            // the storage database was unreachable, every batch came back empty, and the client treats 200 as
            // done. Models were converted and reached this point, so nothing updated is a failure, not a
            // quiet no-op. BuildingController already answers this case the same way.
            if (ids is null || ids.Count == 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Updating to database ended but no BuildingModels have been updated");
                return StatusCode(500, "Database update returned no modified building model IDs.");
            }

            Serilog.Modify.Log("Updating to database ended. Updated BuildingModels: {After}/{Before}", ids.Count, buildingModels_PostgreSQL.Count);

            // A model posted under an identifier that was already stored replaced its own row rather than
            // adding one, so that identifier names a row that has just been written and must not be deleted.
            foreach (PostgreSQL.Classes.BuildingModel buildingModel_PostgreSQL in buildingModels_PostgreSQL)
            {
                string? uniqueId = buildingModel_PostgreSQL.UniqueId;
                if (!string.IsNullOrWhiteSpace(uniqueId))
                {
                    uniqueIds_Superseded.Remove(uniqueId!);
                }
            }

            if (uniqueIds_Superseded.Count != 0)
            {
                // The write has already succeeded, so a failure here leaves the models stored with their
                // predecessors still beside them. That is worth reporting loudly and is repairable, but it is
                // not a reason to fail the request and have the caller write a third model on the retry.
                try
                {
                    HashSet<long>? ids_Removed = await buildingModelPostgreSQLConverter.RemoveByUniqueIdsAsync(uniqueIds_Superseded, countyId);

                    int count = ids_Removed?.Count ?? 0;
                    if (count != uniqueIds_Superseded.Count)
                    {
                        Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Superseded BuildingModels removed: {Removed}/{Counted} - the table did not hold what was read", count, uniqueIds_Superseded.Count);
                    }
                    else
                    {
                        Serilog.Modify.Log("Superseded BuildingModels removed: {Removed}", count);
                    }
                }
                catch (Exception exception)
                {
                    Serilog.Modify.Log(exception, "Superseded BuildingModels could not be removed. The models were written and their predecessors are still stored beside them: {Counted} rows under CountyId {CountyId}", uniqueIds_Superseded.Count, countyId);
                }
            }

            return Ok();
        }
    }
}
