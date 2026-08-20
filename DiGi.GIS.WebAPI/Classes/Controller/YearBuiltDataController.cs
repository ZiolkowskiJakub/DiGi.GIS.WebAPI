using DiGi.GIS.PostgreSQL.Classes;
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
    /// Provides API endpoints for managing and updating year built data stored in a PostgreSQL database.
    /// </summary>
    [ApiController]
    [Route("gis/[controller]")]
    public class YearBuiltDataController : DiGi.WebAPI.Classes.WebAPIController
    {
        private readonly AdministrativeAreal2DPostgreSQLConverter administrativeAreal2DPostgreSQLConverter;
        private readonly Building2DPostgreSQLConverter building2DPostgreSQLConverter; //States which polygon part of a multi-part county a datum belongs to, from the 2D building already stored under it.
        private readonly GISWebAPIConfigurationFileWatcher GISWebAPIConfigurationFileWatcher;
        private readonly YearBuiltDataPostgreSQLConverter yearBuiltDataPostgreSQLConverter;

        /// <summary>
        /// Initializes a new instance of the YearBuiltDataController class.
        /// </summary>
        /// <param name="GISWebAPIConfigurationFileWatcher">The configuration file watcher used to monitor changes to the PostgreSQL Web API configuration.</param>
        /// <param name="yearBuiltDataPostgreSQLConverter">The converter for YearBuiltData objects when interacting with a PostgreSQL database.</param>
        /// <param name="building2DPostgreSQLConverter">The converter for Building2D objects, used to read which county row a reference is already filed under.</param>
        /// <param name="administrativeAreal2DPostgreSQLConverter">The converter for administrative areal 2D data when interacting with a PostgreSQL database.</param>
        public YearBuiltDataController(GISWebAPIConfigurationFileWatcher GISWebAPIConfigurationFileWatcher, YearBuiltDataPostgreSQLConverter yearBuiltDataPostgreSQLConverter, Building2DPostgreSQLConverter building2DPostgreSQLConverter, AdministrativeAreal2DPostgreSQLConverter administrativeAreal2DPostgreSQLConverter)
        {
            this.GISWebAPIConfigurationFileWatcher = GISWebAPIConfigurationFileWatcher;
            this.yearBuiltDataPostgreSQLConverter = yearBuiltDataPostgreSQLConverter;
            this.building2DPostgreSQLConverter = building2DPostgreSQLConverter;
            this.administrativeAreal2DPostgreSQLConverter = administrativeAreal2DPostgreSQLConverter;
        }

        /// <summary>
        /// Updates multiple year built data items based on the provided JSON array and identification code.
        /// <para>A county code does not identify a single county row: BDOT10k stores a county whose territory is disconnected as one feature per polygon part, and every part becomes its own row. Every part the code names is passed on, and each datum is filed under the part it actually belongs to - see <see cref="UpdateItemsByCountyIdsAsync"/> for how that is decided.</para>
        /// </summary>
        /// <param name="jsonArray">The JSON array containing the data items to be updated.</param>
        /// <param name="code">The identification code required for the update operation.</param>
        /// <returns>An <see cref="IActionResult"/> representing the result of the update operation.</returns>
        [HttpPost("updateitems")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateItemsAsync([FromBody] JsonArray? jsonArray, [FromQuery(Name = "code")] string code)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(YearBuiltDataController), nameof(UpdateItemsAsync));
            Serilog.Modify.Log("Code provided: {Code}", code ?? string.Empty);

            if (string.IsNullOrWhiteSpace(code))
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Code cannot be null or empty");
                return BadRequest();
            }

            if (!GISWebAPIConfigurationFileWatcher.AllowUpdateYearBuiltData)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "YearBuiltData update not allowed");
                return BadRequest();
            }

            if (administrativeAreal2DPostgreSQLConverter is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "AdministrativeAreal2DPostgreSQLConverter is null");
                return BadRequest();
            }

            if (jsonArray is null || jsonArray.Count == 0)
            {
                Serilog.Modify.Log("No YearBuiltData to update");
                return NoContent();
            }

            HashSet<int>? countyIds = await administrativeAreal2DPostgreSQLConverter.GetIdsByCodeAsync(code, PostgreSQL.Enums.AdministrativeArealType.County);
            if (countyIds is null || countyIds.Count == 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "County code '{Code}' was not found in database", code);
                return BadRequest();
            }

            int[] countyIds_Resolved = [.. countyIds.OrderBy(x => x)];

            // Collapsing an ambiguous code onto one row is what let the skew in this table go unnoticed:
            // the upload reported success while everything filed under a sibling row read back empty.
            // Every part is passed on instead, and the batch is split between them per datum.
            if (countyIds_Resolved.Length > 1)
            {
                Serilog.Modify.Log("County code '{Code}' matches {Count} rows ({CountyIds}) because the county has that many polygon parts. Each datum is being filed under the part its Building2D is stored in", code, countyIds_Resolved.Length, string.Join(", ", countyIds_Resolved));
            }

            return await UpdateItemsByCountyIdsAsync(jsonArray, countyIds_Resolved);
        }

        /// <summary>
        /// Updates multiple year built data items in the database for the given county rows.
        /// <para>The unambiguous counterpart of <see cref="UpdateItemsAsync"/>: it takes county identifiers rather than a code, so the caller states which rows are in play instead of leaving the server to derive them.</para>
        /// <para>A single identifier is taken as stated and every datum is filed under it. Several identifiers are the polygon parts of one multi-part county, and each datum is then filed under the part already holding the <c>building_2d</c> row its reference names, probed lowest part first. That row was filed by geometry when it was imported, so reusing its answer keeps both tables keyed by the same <c>(county_id, reference)</c> pair.</para>
        /// <para>A datum whose reference no part holds is not written: it carries no geometry of its own, so nothing states where it belongs, and storing it under a guessed part is the state this replaced.</para>
        /// </summary>
        /// <param name="jsonArray">The JSON array containing the data items to be updated.</param>
        /// <param name="countyIds">The identifiers of the county rows the year built data belong to. Normally every polygon part of one county.</param>
        /// <returns>An <see cref="IActionResult"/> representing the result of the update operation.</returns>
        [HttpPost("updateitemsbycountyids")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateItemsByCountyIdsAsync([FromBody] JsonArray? jsonArray, [FromQuery(Name = "countyids")] int[]? countyIds)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(YearBuiltDataController), nameof(UpdateItemsByCountyIdsAsync));
            Serilog.Modify.Log("CountyIds provided: {CountyIds}", countyIds is null ? string.Empty : string.Join(", ", countyIds));

            if (!GISWebAPIConfigurationFileWatcher.AllowUpdateYearBuiltData)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "YearBuiltData update not allowed");
                return BadRequest();
            }

            if (countyIds is null || countyIds.Length == 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "CountyIds cannot be null or empty");
                return BadRequest();
            }

            if (jsonArray is null || jsonArray.Count == 0)
            {
                Serilog.Modify.Log("No YearBuiltData to update");
                return NoContent();
            }

            List<GIS.Classes.YearBuiltData>? yearBuiltDatas_GIS = Core.Create.SerializableObjects<GIS.Classes.YearBuiltData>(jsonArray);
            if (yearBuiltDatas_GIS is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "YearBuiltDatas could not be converted from json");
                return BadRequest();
            }

            Serilog.Modify.Log("YearBuiltDatas conversion to PostgreSQL started. YearBuiltDatas count: {Count}", yearBuiltDatas_GIS.Count);

            List<int> countyIds_Candidate = [.. new HashSet<int>(countyIds).OrderBy(x => x)];

            // Left unset while there is more than one candidate, so the part is decided per item below.
            int? countyId_Single = countyIds_Candidate.Count == 1 ? countyIds_Candidate[0] : null;

            Dictionary<string, int>? countyIds_ByReference = null;
            if (countyId_Single is null)
            {
                countyIds_ByReference = await building2DPostgreSQLConverter.CountyIdsByReferencesAsync(yearBuiltDatas_GIS.ConvertAll(x => x?.Reference), countyIds_Candidate);
            }

            List<string> references_Unresolved = [];

            List<YearBuiltData> yearBuiltDatas_PostgreSQL = [];
            foreach (GIS.Classes.YearBuiltData yearBuiltData_GIS in yearBuiltDatas_GIS)
            {
                int? countyId = countyId_Single;

                if (countyId is null)
                {
                    // A datum carries no geometry, so the 2D building its reference names is the only thing
                    // that can say which part it belongs to. One that names none is left unwritten rather
                    // than filed under a guessed part.
                    if (yearBuiltData_GIS?.Reference is null || countyIds_ByReference is null || !countyIds_ByReference.TryGetValue(yearBuiltData_GIS.Reference, out int countyId_Reference))
                    {
                        references_Unresolved.Add(yearBuiltData_GIS?.Reference ?? string.Empty);
                        continue;
                    }

                    countyId = countyId_Reference;
                }

                if (PostgreSQL.Convert.ToPostgreSQL(yearBuiltData_GIS, countyId) is YearBuiltData yearBuiltData_PostgreSQL)
                {
                    yearBuiltDatas_PostgreSQL.Add(yearBuiltData_PostgreSQL);
                }
            }

            if (references_Unresolved.Count != 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "YearBuiltDatas not written because no Building2D under the given parts carries their reference: {Count}/{Total}. References: {References}", references_Unresolved.Count, yearBuiltDatas_GIS.Count, string.Join(", ", references_Unresolved.Take(20)));
            }

            if (yearBuiltDatas_PostgreSQL is null || yearBuiltDatas_PostgreSQL.Count == 0)
            {
                Serilog.Modify.Log("No YearBuiltDatas PostgreSQL to update");
                return NoContent();
            }

            Serilog.Modify.Log("YearBuiltDatas conversion to PostgreSQL ended. YearBuiltDatas converted: {After}/{Before}", yearBuiltDatas_PostgreSQL.Count, yearBuiltDatas_GIS.Count);

            Serilog.Modify.Log("Updating to database starting");

            HashSet<long>? ids = null;
            try
            {
                ids = await yearBuiltDataPostgreSQLConverter.UpdateAsync(yearBuiltDatas_PostgreSQL);
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "Database could not be updated");
                return StatusCode(500, "Database update failed.");
            }

            // Answering Ok here is what let a whole county regeneration report success while writing
            // nothing: the storage database was unreachable, every batch came back empty, and the client
            // treats 200 as done. YearBuiltDatas were converted and reached this point, so nothing updated
            // is a failure, not a quiet no-op. BuildingController already answers this case the same way.
            if (ids is null || ids.Count == 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Updating to database ended but no YearBuiltDatas have been updated");
                return StatusCode(500, "Database update returned no modified YearBuiltData IDs.");
            }

            Serilog.Modify.Log("Updating to database ended. Updated YearBuiltDatas: {After}/{Before}", ids.Count, yearBuiltDatas_PostgreSQL.Count);

            return Ok();
        }

        /// <summary>
        /// Asynchronously retrieves items based on a provided reference and an optional county identifier.
        /// </summary>
        /// <param name="reference">The unique reference string used to identify the year built data items.</param>
        /// <param name="countyId">An optional integer representing the county ID to filter the results.</param>
        /// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> to observe for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        [HttpGet("itemsbyreference")]
        public async Task<IActionResult> GetItemsByReferenceAsync([FromQuery(Name = "reference")] string reference, [FromQuery(Name = "countyid")] int? countyId, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(YearBuiltDataController), nameof(GetItemsByReferenceAsync));

            Serilog.Modify.Log("Reference provided: {Reference}", reference ?? string.Empty);
            Serilog.Modify.Log("CountyId provided: {CountyId}", countyId?.ToString() ?? string.Empty);

            if (string.IsNullOrWhiteSpace(reference))
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Reference cannot be null or empty");
                return BadRequest();
            }

            if (yearBuiltDataPostgreSQLConverter is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "YearBuiltDataPostgreSQLConverter is null");
                return BadRequest();
            }

            List<YearBuiltData>? yearBuiltDatas_PostgreSQL = await yearBuiltDataPostgreSQLConverter.GetItemsByReferenceAsync(reference, countyId, null, cancellationToken);

            if (yearBuiltDatas_PostgreSQL is null || yearBuiltDatas_PostgreSQL.Count == 0)
            {
                Serilog.Modify.Log("No YearBuiltDatas found for provided reference");
                return NoContent();
            }

            List<GIS.Interfaces.IYearBuiltData> yearBuiltDatas = [];
            foreach (YearBuiltData yearBuilt_PostgreSQL in yearBuiltDatas_PostgreSQL)
            {
                GIS.Interfaces.IYearBuiltData? yearBuiltData_GIS = yearBuilt_PostgreSQL.ToDiGi();
                if (yearBuiltData_GIS is null)
                {
                    continue;
                }

                yearBuiltDatas.Add(yearBuiltData_GIS);
            }

            if (yearBuiltDatas is null || yearBuiltDatas.Count == 0)
            {
                return NoContent();
            }

            return Content(Core.Convert.ToSystem_String(yearBuiltDatas) ?? string.Empty, "application/json");
        }
    }
}