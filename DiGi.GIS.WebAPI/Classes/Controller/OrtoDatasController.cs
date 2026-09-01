using DiGi.GIS.Classes;
using DiGi.GIS.PostgreSQL;
using DiGi.GIS.PostgreSQL.Enums;
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
    /// Controller providing API endpoints for managing and accessing orthophoto data and related GIS spatial information via a PostgreSQL database.
    /// </summary>
    [ApiController]
    [Route("gis/[controller]")]
    public class OrtoDatasController : DiGi.WebAPI.Classes.WebAPIController
    {
        private readonly PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter administrativeAreal2DPostgreSQLConverter;
        private readonly PostgreSQL.Classes.Building2DPostgreSQLConverter building2DPostgreSQLConverter;
        private readonly GISWebAPIConfigurationFileWatcher GISWebAPIConfigurationFileWatcher;
        private readonly PostgreSQL.Classes.OrtoDatasPostgreSQLConverter ortoDatasPostgreSQLConverter;

        /// <summary>
        /// Initializes a new instance of the OrtoDatasController class.
        /// </summary>
        /// <param name="GISWebAPIConfigurationFileWatcher">The configuration file watcher used to monitor changes to the GIS PostgreSQL Web API settings.</param>
        /// <param name="ortoDatasPostgreSQLConverter">The converter used for handling OrtoDatas data operations within the PostgreSQL database.</param>
        /// <param name="building2DPostgreSQLConverter">The converter used for handling Building 2D data operations within the PostgreSQL database.</param>
        /// <param name="administrativeAreal2DPostgreSQLConverter">The converter used for handling Administrative Areal 2D data operations within the PostgreSQL database.</param>
        public OrtoDatasController(GISWebAPIConfigurationFileWatcher GISWebAPIConfigurationFileWatcher, PostgreSQL.Classes.OrtoDatasPostgreSQLConverter ortoDatasPostgreSQLConverter, PostgreSQL.Classes.Building2DPostgreSQLConverter building2DPostgreSQLConverter, PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter administrativeAreal2DPostgreSQLConverter)
        {
            this.GISWebAPIConfigurationFileWatcher = GISWebAPIConfigurationFileWatcher;
            this.ortoDatasPostgreSQLConverter = ortoDatasPostgreSQLConverter;
            this.administrativeAreal2DPostgreSQLConverter = administrativeAreal2DPostgreSQLConverter;
            this.building2DPostgreSQLConverter = building2DPostgreSQLConverter;
        }

        /// <summary>
        /// Asynchronously checks for the existence of a collection of references, optionally filtered by a county identifier.
        /// </summary>
        /// <param name="references">A list of strings representing the references to be checked.</param>
        /// <param name="countyId">The identifier of the county partition to confine the check to. Omit to search every partition.</param>
        /// <param name="inverted">Returns the references that are absent rather than the ones present.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by the caller to cancel the asynchronous operation.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        [HttpPost("containsbyreferences", Name = $"{nameof(OrtoDatasController)}_{nameof(ContainsByReferencesAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(HashSet<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ContainsByReferencesAsync([FromBody] List<string>? references, [FromQuery(Name = "countyid")] int? countyId, [FromQuery(Name = "inverted")] bool? inverted, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(OrtoDatasController), nameof(ContainsByReferencesAsync));
            Serilog.Modify.Log("CountyId provided: {CountyId}", countyId?.ToString() ?? "None");
            Serilog.Modify.Log("Inverted: {Inverted}", (inverted ?? false).ToString());

            if (references is null || references.Count == 0)
            {
                Serilog.Modify.Log("No references to check");
                return BadRequest("The references list cannot be empty.");
            }

            HashSet<string> uniqueReferences = [.. references.Where(r => !string.IsNullOrWhiteSpace(r))];

            if (uniqueReferences.Count == 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "References could not be converted or are empty");
                return BadRequest("Provided list contains only empty values.");
            }

            Serilog.Modify.Log("References count: {Count}", uniqueReferences.Count);

            Serilog.Modify.Log("Query database starting");

            try
            {
                HashSet<string>? referencesExisting = await ortoDatasPostgreSQLConverter.ContainsByReferencesAsync(uniqueReferences, countyId, inverted ?? false, cancellationToken: cancellationToken);

                referencesExisting ??= [];

                return Ok(referencesExisting);
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "Database could not be queried");
                return StatusCode(500, "Internal server error during database query");
            }
        }

        /// <summary>
        /// Retrieves the orthophoto coverage factor for a specified administrative area 2D identifier.
        /// <para>Below county level the figure is counted rather than estimated. A subdivision and a municipality have no partition of their own - both tables are partitioned by <c>county_id</c> - so the coverage is measured over that area's own buildings, by reading its county once per side and matching the references in memory. County and above keep the planner's row estimate, which is what makes a voivodeship or a country affordable at all, so an exact sub-county figure and its county's estimate can differ by a few percent and both be right.</para>
        /// <para>Where building data is measured but no orthophoto partition has been created for a county, the county has zero orthophotos stored and yields a coverage factor of <c>0.0</c>. A coverage that cannot be measured (missing or unanalysed building data, or an unanalysed orthophoto partition) answers 204 NoContent; <c>countbycountyid?estimated=true</c> reads the state of one county, answering 200 when it is analysed, 204 when it is unanalysed and 404 when it has no partition.</para>
        /// </summary>
        /// <param name="administrativeAreal2DId">The unique identifier of the administrative area 2D.</param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of each command. A value of 0 disables the timeout. Defaults to 600 seconds.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by the caller to cancel the asynchronous operation.</param>
        /// <returns>An <see cref="IActionResult"/> carrying the coverage factor, 204 NoContent when it could not be measured, or an error status code.</returns>
        [HttpGet("estimatedcoveragefactor", Name = $"{nameof(OrtoDatasController)}_{nameof(GetEstimatedCoverageFactorAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(double), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetEstimatedCoverageFactorAsync([FromQuery(Name = "administrativeareal2Did")] int administrativeAreal2DId, [FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(OrtoDatasController), nameof(GetEstimatedCoverageFactorAsync));
            Serilog.Modify.Log("AdministrativeAreal2D Id provided: {Id}", administrativeAreal2DId);

            if (administrativeAreal2DPostgreSQLConverter is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "AdministrativeAreal2DPostgreSQLConverter cannot be null");
                return BadRequest();
            }

            if (ortoDatasPostgreSQLConverter is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "OrtoDatasPostgreSQLConverter cannot be null");
                return BadRequest();
            }

            if (building2DPostgreSQLConverter is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Building2DPostgreSQLConverter cannot be null");
                return BadRequest();
            }

            PostgreSQL.Classes.AdministrativeAreal2DReference? administrativeAreal2DReference = await administrativeAreal2DPostgreSQLConverter.GetAdministrativeAreal2DReferenceByIdAsync(administrativeAreal2DId, cancellationToken: cancellationToken);
            if (administrativeAreal2DReference is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Could not find given AdministrativeAreal2D");
                return BadRequest();
            }

            Serilog.Modify.Log("AdministrativeAreal2D found: {Name}, type: {AdministrativeArealType}", administrativeAreal2DReference.Name ?? "???", administrativeAreal2DReference.AdministrativeArealType.ToString());

            long count_Building2D = -1;
            long count_OrtoDatas = -1;

            switch (administrativeAreal2DReference.AdministrativeArealType)
            {
                case AdministrativeArealType.Subdivision:
                case AdministrativeArealType.Municipality:

                    if (administrativeAreal2DReference.CountyId is not int countyId_Parent)
                    {
                        Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "AdministrativeAreal2D names no county, so its coverage cannot be measured. Id: {Id}", administrativeAreal2DId);
                        return NoContent();
                    }

                    Serilog.Modify.Log("Counting coverage within county {CountyId}", countyId_Parent);

                    long? count_Building2D_Parent = await building2DPostgreSQLConverter.GetEstimatedCountAsync(countyId_Parent, commandTimeout: commandTimeout, cancellationToken: cancellationToken);
                    if (count_Building2D_Parent is null || count_Building2D_Parent <= 0)
                    {
                        Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Parent county {CountyId} has no building measurement", countyId_Parent);
                        return NoContent();
                    }

                    long? count_OrtoDatas_Parent = await ortoDatasPostgreSQLConverter.GetEstimatedCountAsync(countyId_Parent, commandTimeout: commandTimeout, cancellationToken: cancellationToken);
                    if (count_OrtoDatas_Parent is null || count_OrtoDatas_Parent == 0)
                    {
                        Serilog.Modify.Log("Parent county {CountyId} has 0 orthophotos stored; coverage is 0.0", countyId_Parent);
                        return Ok(0.0);
                    }

                    if (count_OrtoDatas_Parent < 0)
                    {
                        Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Parent county {CountyId} has unanalysed orthophoto partition", countyId_Parent);
                        return NoContent();
                    }

                    List<PostgreSQL.Classes.OrtoDatasCoverageResult>? ortoDatasCoverageResults = await ortoDatasPostgreSQLConverter.SubdivisionCoveragesAsync(building2DPostgreSQLConverter, countyId_Parent, commandTimeout, cancellationToken);
                    if (ortoDatasCoverageResults is null)
                    {
                        Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Coverage could not be counted for county {CountyId}", countyId_Parent);
                        return NoContent();
                    }

                    HashSet<int>? subdivisionIds = await SubdivisionIdsAsync(administrativeAreal2DReference, countyId_Parent);
                    if (subdivisionIds is null)
                    {
                        Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Subdivisions could not be resolved for AdministrativeAreal2D {Id}", administrativeAreal2DId);
                        return NoContent();
                    }

                    count_Building2D = 0;
                    count_OrtoDatas = 0;

                    foreach (PostgreSQL.Classes.OrtoDatasCoverageResult ortoDatasCoverageResult in ortoDatasCoverageResults)
                    {
                        // A result carrying no subdivision is the county's unresolved buildings. They belong to
                        // no subdivision and to no municipality, so nothing below county level counts them.
                        if (ortoDatasCoverageResult?.SubdivisionId is not int subdivisionId || !subdivisionIds.Contains(subdivisionId))
                        {
                            continue;
                        }

                        count_Building2D += ortoDatasCoverageResult.Building2DCount;
                        count_OrtoDatas += ortoDatasCoverageResult.OrtoDatasCount;
                    }

                    break;

                case AdministrativeArealType.County:
                    Serilog.Modify.Log("Calculating estimated count for {Id}", administrativeAreal2DReference.Id.ToString() ?? "???");

                    HashSet<int>? siblingCountyIds = null;
                    if (administrativeAreal2DReference.Code is string countyCode && !string.IsNullOrWhiteSpace(countyCode))
                    {
                        siblingCountyIds = await administrativeAreal2DPostgreSQLConverter.GetIdsByCodeAsync(countyCode, AdministrativeArealType.County, cancellationToken: cancellationToken);
                    }

                    if (siblingCountyIds is not null && siblingCountyIds.Count > 1)
                    {
                        Dictionary<int, long>? counts_Building2D_Siblings = await building2DPostgreSQLConverter.GetEstimatedCountsAsync(siblingCountyIds, commandTimeout: commandTimeout, cancellationToken: cancellationToken);
                        Dictionary<int, long>? counts_OrtoDatas_Siblings = await ortoDatasPostgreSQLConverter.GetEstimatedCountsAsync(siblingCountyIds, commandTimeout: commandTimeout, cancellationToken: cancellationToken);
                        if (counts_Building2D_Siblings is null || counts_OrtoDatas_Siblings is null)
                        {
                            return NoContent();
                        }

                        long sum_Building2D_County = 0;
                        long sum_OrtoDatas_County = 0;
                        bool countyNotMeasured = false;

                        foreach (int siblingCountyId in siblingCountyIds)
                        {
                            long count_Building2D_Sibling = 0;
                            if (counts_Building2D_Siblings.TryGetValue(siblingCountyId, out long count_Building2D_Sibling_Val))
                            {
                                if (count_Building2D_Sibling_Val < 0)
                                {
                                    countyNotMeasured = true;
                                    break;
                                }

                                count_Building2D_Sibling = count_Building2D_Sibling_Val;
                            }

                            long count_OrtoDatas_Sibling = 0;
                            if (counts_OrtoDatas_Siblings.TryGetValue(siblingCountyId, out long count_OrtoDatas_Sibling_Val))
                            {
                                if (count_OrtoDatas_Sibling_Val < 0)
                                {
                                    countyNotMeasured = true;
                                    break;
                                }

                                count_OrtoDatas_Sibling = count_OrtoDatas_Sibling_Val;
                            }

                            sum_Building2D_County += count_Building2D_Sibling;
                            sum_OrtoDatas_County += count_OrtoDatas_Sibling;
                        }

                        if (countyNotMeasured)
                        {
                            return NoContent();
                        }

                        count_Building2D = sum_Building2D_County;
                        count_OrtoDatas = sum_OrtoDatas_County;
                    }
                    else
                    {
                        count_Building2D = await building2DPostgreSQLConverter.GetEstimatedCountAsync(administrativeAreal2DReference.Id, commandTimeout: commandTimeout, cancellationToken: cancellationToken) ?? -1;
                        long? count_OrtoDatas_Single = await ortoDatasPostgreSQLConverter.GetEstimatedCountAsync(administrativeAreal2DReference.Id, commandTimeout: commandTimeout, cancellationToken: cancellationToken);
                        count_OrtoDatas = (count_Building2D >= 0 && count_OrtoDatas_Single is null) ? 0 : (count_OrtoDatas_Single ?? -1);
                    }
                    break;

                case AdministrativeArealType.Voivodeship:
                case AdministrativeArealType.Country:

                    if (administrativeAreal2DReference.Code is null)
                    {
                        Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Could not get Code for given AdministrativeAreal2D");
                        return BadRequest();
                    }

                    Serilog.Modify.Log("Calculating estimated count for {Code}", administrativeAreal2DReference.Code);

                    List<int>? countyIds = (await administrativeAreal2DPostgreSQLConverter.GetAdministrativeAreal2DReferencesByParentCodeAsync(administrativeAreal2DReference.Code, AdministrativeArealType.County, administrativeAreal2DReference.AdministrativeArealType, cancellationToken: cancellationToken))?.ConvertAll(x => x.Id);
                    if (countyIds is null || countyIds.Count == 0)
                    {
                        Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Could not find given County AdministrativeAreal2Ds for given Id");
                        return BadRequest();
                    }

                    Serilog.Modify.Log("Calculating estimated count for {Ids}", string.Join(",", countyIds));

                    Dictionary<int, long>? counts_Building2D = await building2DPostgreSQLConverter.GetEstimatedCountsAsync(countyIds, commandTimeout: commandTimeout, cancellationToken: cancellationToken);
                    Dictionary<int, long>? counts_OrtoDatas = await ortoDatasPostgreSQLConverter.GetEstimatedCountsAsync(countyIds, commandTimeout: commandTimeout, cancellationToken: cancellationToken);
                    if (counts_Building2D is null || counts_OrtoDatas is null)
                    {
                        Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Coverage could not be measured. Id: {Id}", administrativeAreal2DId);
                        return NoContent();
                    }

                    HashSet<int> countyIds_Temp = [.. countyIds];
                    long sum_Building2D = 0;
                    long sum_OrtoDatas = 0;
                    List<int> countyIds_NotMeasured = [];

                    foreach (int countyId in countyIds_Temp)
                    {
                        long count_Building2D_County = 0;
                        if (counts_Building2D.TryGetValue(countyId, out long count_Building2D_County_Val))
                        {
                            if (count_Building2D_County_Val < 0)
                            {
                                countyIds_NotMeasured.Add(countyId);
                                continue;
                            }

                            count_Building2D_County = count_Building2D_County_Val;
                        }

                        long count_OrtoDatas_County = 0;
                        if (counts_OrtoDatas.TryGetValue(countyId, out long count_OrtoDatas_County_Val))
                        {
                            if (count_OrtoDatas_County_Val < 0)
                            {
                                countyIds_NotMeasured.Add(countyId);
                                continue;
                            }

                            count_OrtoDatas_County = count_OrtoDatas_County_Val;
                        }

                        sum_Building2D += count_Building2D_County;
                        sum_OrtoDatas += count_OrtoDatas_County;
                    }

                    if (countyIds_NotMeasured.Count > 0)
                    {
                        Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Coverage could not be measured. Unmeasured counties: {CountyIds}", string.Join(",", countyIds_NotMeasured));
                        return NoContent();
                    }

                    count_Building2D = sum_Building2D;
                    count_OrtoDatas = sum_OrtoDatas;
                    break;
            }

            if (count_Building2D < 0 || count_OrtoDatas < 0)
            {
                // Answered rather than logged and rounded down to zero. A negative count means the partition is
                // absent or has never been analysed, which is not the same fact as an uncovered county, and a
                // caller handed 0.0 for it cannot tell the two apart.
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Coverage could not be measured. Building2D count: {Count_Building2D}, OrtoDatas count: {Count_OrtoDatas}", count_Building2D, count_OrtoDatas);
                return NoContent();
            }

            if (count_Building2D == 0)
            {
                // No buildings is not zero coverage. There is nothing there to be covered, and the fraction has
                // no denominator.
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "No buildings to measure coverage against. Id: {Id}", administrativeAreal2DId);
                return NoContent();
            }

            return Ok(Math.Clamp((double)count_OrtoDatas / (double)count_Building2D, 0.0, 1.0));

            // Which subdivisions the requested area is made of. A subdivision is itself; a municipality is every
            // subdivision naming it, read from the county's own subdivision rows rather than by walking the
            // municipality, so one query serves a county however many of its municipalities are asked about. A
            // subdivision naming no municipality hangs off the county directly - m. Poznan holds no gmina
            // feature - and therefore counts toward no municipality, which falling out of this filter gives.
            async Task<HashSet<int>?> SubdivisionIdsAsync(PostgreSQL.Classes.AdministrativeAreal2DReference administrativeAreal2DReference_Requested, int countyId)
            {
                if (administrativeAreal2DReference_Requested.AdministrativeArealType == AdministrativeArealType.Subdivision)
                {
                    return [administrativeAreal2DReference_Requested.Id];
                }

                List<PostgreSQL.Classes.AdministrativeAreal2DReference>? administrativeAreal2DReferences_Subdivision = await administrativeAreal2DPostgreSQLConverter.GetAdministrativeAreal2DReferencesByAdministrativeArealTypeAsync(AdministrativeArealType.Subdivision, countyId, false, commandTimeout, cancellationToken);
                if (administrativeAreal2DReferences_Subdivision is null)
                {
                    return null;
                }

                HashSet<int> subdivisionIds_Municipality = [];
                foreach (PostgreSQL.Classes.AdministrativeAreal2DReference administrativeAreal2DReference_Subdivision in administrativeAreal2DReferences_Subdivision)
                {
                    if (administrativeAreal2DReference_Subdivision?.MunicipalityId == administrativeAreal2DReference_Requested.Id)
                    {
                        subdivisionIds_Municipality.Add(administrativeAreal2DReference_Subdivision.Id);
                    }
                }

                return subdivisionIds_Municipality;
            }
        }

        /// <summary>
        /// Retrieves the orthophoto coverage factors for the specified administrative area identifiers.
        /// <para>The values come back in the order the identifiers were given, one per identifier, so a caller can update one row per value without matching anything up. A value is <c>null</c> where the coverage could not be measured (missing or unanalysed building data, or unanalysed orthophoto partition). Where building data is measured but no orthophoto partition has been created for a county, its orthophoto count is 0, yielding a coverage factor of <c>0.0</c>.</para>
        /// <para>A county, a voivodeship and a country are answered from the two tables row estimates - every identifier is resolved to the counties it stands for and both estimates are read for the whole set in one query per table. A subdivision and a municipality have no partition of their own and are instead counted, over their own buildings, by reading their county once per side; every subdivision and municipality of one county is served from that single pass.</para>
        /// <para>Because counting reads a whole county, at most <see cref="Constants.OrtoDatas.MaximumCoverageCountyCount"/> distinct counties are counted per request, taken in the order the identifiers were given. Identifiers sitting in counties beyond that are answered <c>null</c> rather than given their county figure or failing the request.</para>
        /// </summary>
        /// <param name="administrativeAreal2DIds">The collection of administrative area 2D identifiers to be processed.</param>
        /// <param name="analyze">Refreshes the statistics before reading them. This applies only to the estimated county-and-above path and does nothing for a subdivision or a municipality, which are counted. It costs one <c>VACUUM ANALYZE</c> per resolved county partition on each of the two tables - for a country identifier that is several hundred maintenance statements against live partitions, so raise <c>commandtimeout</c> to match or leave the flag off.</param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of each command. A value of 0 disables the timeout. Defaults to 600 seconds.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by the caller to cancel the asynchronous operation.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        [HttpPost("estimatedcoveragefactors", Name = $"{nameof(OrtoDatasController)}_{nameof(GetEstimatedCoverageFactorsAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(List<double?>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetEstimatedCoverageFactorsAsync([FromBody] IEnumerable<int> administrativeAreal2DIds, [FromQuery(Name = "analyze")] bool? analyze, [FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(OrtoDatasController), nameof(GetEstimatedCoverageFactorsAsync));
            Serilog.Modify.Log("AdministrativeAreal2D Ids provided: {Ids}", string.Join(",", administrativeAreal2DIds ?? []));
            Serilog.Modify.Log("AdministrativeAreal2D data type: {DataType}", administrativeAreal2DIds?.GetType()?.FullName ?? "???");

            if (administrativeAreal2DIds is null || !administrativeAreal2DIds.Any())
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "administrativeAreal2DIds have not been provided");
                return BadRequest();
            }

            List<int> administrativeAreal2DIds_Temp = [.. administrativeAreal2DIds];

            if (ortoDatasPostgreSQLConverter is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "OrtoDatasPostgreSQLConverter cannot be null");
                return BadRequest();
            }

            if (administrativeAreal2DPostgreSQLConverter is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "AdministrativeAreal2DPostgreSQLConverter cannot be null");
                return BadRequest();
            }

            if (building2DPostgreSQLConverter is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Building2DPostgreSQLConverter cannot be null");
                return BadRequest();
            }

            List<PostgreSQL.Classes.AdministrativeAreal2DReference>? administrativeAreal2DReferences = await administrativeAreal2DPostgreSQLConverter.GetAdministrativeAreal2DReferencesByIdsAsync(administrativeAreal2DIds_Temp, cancellationToken: cancellationToken);
            if (administrativeAreal2DReferences is null || administrativeAreal2DReferences.Count == 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "AdministrativeAreal2Ds could not be found in database");
                return BadRequest();
            }

            List<PostgreSQL.Classes.AdministrativeAreal2DReference> administrativeAreal2DReferences_SubdivisionMunicipality = [];
            List<PostgreSQL.Classes.AdministrativeAreal2DReference> administrativeAreal2DReferences_County = [];
            List<PostgreSQL.Classes.AdministrativeAreal2DReference> administrativeAreal2DReferences_VoivodeshipCountry = [];

            foreach (PostgreSQL.Classes.AdministrativeAreal2DReference administrativeAreal2DReference in administrativeAreal2DReferences)
            {
                if (administrativeAreal2DReference?.AdministrativeArealType is not AdministrativeArealType administrativeArealType || administrativeArealType == AdministrativeArealType.Undefined)
                {
                    Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "AdministrativeAreal2D is null or has invalid AdministrativeArealType: {AdministrativeArealType}", administrativeAreal2DReference?.AdministrativeArealType.ToString() ?? "???");
                    continue;
                }

                switch (administrativeArealType)
                {
                    case AdministrativeArealType.Subdivision:
                    case AdministrativeArealType.Municipality:
                        administrativeAreal2DReferences_SubdivisionMunicipality.Add(administrativeAreal2DReference);
                        break;

                    case AdministrativeArealType.County:
                        administrativeAreal2DReferences_County.Add(administrativeAreal2DReference);
                        break;

                    case AdministrativeArealType.Voivodeship:
                    case AdministrativeArealType.Country:
                        administrativeAreal2DReferences_VoivodeshipCountry.Add(administrativeAreal2DReference);
                        break;
                }
            }

            // An identifier with no entry here is one that could not be measured, and is answered null further
            // down. That is the whole vocabulary: an entry means a measurement, an absence means there is none.
            Dictionary<int, (long Count_Building2D, long Count_OrtoDatas)> dictionary = [];

            // Resolve which counties every estimated identifier stands for BEFORE touching the count tables.
            // A country expands to all 406 county rows, so asking per county per table cost ~1 624 statements
            // for one request; the two batched reads below replace all of them.
            Dictionary<int, List<int>> countyIds_ByAdministrativeAreal2DId = [];
            HashSet<int> countyIds = [];

            HashSet<string> countyCodes = [.. administrativeAreal2DReferences_County.Where(x => !string.IsNullOrWhiteSpace(x.Code)).Select(x => x.Code!)];
            Dictionary<string, HashSet<int>>? countyPartIds_ByCode = null;
            if (countyCodes.Count > 0)
            {
                countyPartIds_ByCode = await administrativeAreal2DPostgreSQLConverter.GetIdsByCodesAsync(countyCodes, AdministrativeArealType.County, cancellationToken: cancellationToken);
            }

            foreach (PostgreSQL.Classes.AdministrativeAreal2DReference administrativeAreal2DReference in administrativeAreal2DReferences_County)
            {
                List<int> countyPartIds;
                if (administrativeAreal2DReference.Code is not null && countyPartIds_ByCode is not null && countyPartIds_ByCode.TryGetValue(administrativeAreal2DReference.Code, out HashSet<int>? partIds) && partIds.Count > 0)
                {
                    countyPartIds = [.. partIds];
                }
                else
                {
                    countyPartIds = [administrativeAreal2DReference.Id];
                }

                countyIds_ByAdministrativeAreal2DId[administrativeAreal2DReference.Id] = countyPartIds;
                countyIds.UnionWith(countyPartIds);
            }

            foreach (PostgreSQL.Classes.AdministrativeAreal2DReference administrativeAreal2DReference in administrativeAreal2DReferences_VoivodeshipCountry)
            {
                if (administrativeAreal2DReference.Code is not string code || string.IsNullOrWhiteSpace(code))
                {
                    continue;
                }

                List<int>? countyIds_AdministrativeAreal2DReference = (await administrativeAreal2DPostgreSQLConverter.GetAdministrativeAreal2DReferencesByParentCodeAsync(code, AdministrativeArealType.County, administrativeAreal2DReference.AdministrativeArealType, cancellationToken: cancellationToken))?.ConvertAll(x => x.Id);

                // An identifier that resolves to no county is left without an entry, which answers null for it -
                // the same thing the singular endpoint does when it cannot measure.
                if (countyIds_AdministrativeAreal2DReference is null || countyIds_AdministrativeAreal2DReference.Count == 0)
                {
                    continue;
                }

                countyIds_ByAdministrativeAreal2DId[administrativeAreal2DReference.Id] = countyIds_AdministrativeAreal2DReference;
                countyIds.UnionWith(countyIds_AdministrativeAreal2DReference);
            }

            // Everything below county level is counted rather than estimated, and the cost follows the counties
            // named rather than the identifiers: the identifiers are grouped by their county first so that one
            // pass over a county serves every subdivision and municipality of it that was asked about.
            Dictionary<int, List<PostgreSQL.Classes.AdministrativeAreal2DReference>> administrativeAreal2DReferences_ByCountyId = [];
            List<int> countyIds_Coverage = [];

            Dictionary<int, PostgreSQL.Classes.AdministrativeAreal2DReference> administrativeAreal2DReferences_ById = [];
            foreach (PostgreSQL.Classes.AdministrativeAreal2DReference administrativeAreal2DReference in administrativeAreal2DReferences_SubdivisionMunicipality)
            {
                administrativeAreal2DReferences_ById[administrativeAreal2DReference.Id] = administrativeAreal2DReference;
            }

            // Walked in the order the identifiers were given rather than in the order the database returned
            // them, because that order is what decides which counties fall inside the cap below. Reading the
            // references back sorts them by identifier, so grouping from that list would silently cap by
            // identifier and make the documented "in the order given" untrue.
            HashSet<int> administrativeAreal2DIds_Seen = [];
            foreach (int administrativeAreal2DId in administrativeAreal2DIds_Temp)
            {
                if (!administrativeAreal2DIds_Seen.Add(administrativeAreal2DId))
                {
                    continue;
                }

                if (!administrativeAreal2DReferences_ById.TryGetValue(administrativeAreal2DId, out PostgreSQL.Classes.AdministrativeAreal2DReference? administrativeAreal2DReference))
                {
                    continue;
                }

                if (administrativeAreal2DReference?.CountyId is not int countyId)
                {
                    continue;
                }

                if (!administrativeAreal2DReferences_ByCountyId.TryGetValue(countyId, out List<PostgreSQL.Classes.AdministrativeAreal2DReference>? administrativeAreal2DReferences_County_Temp))
                {
                    administrativeAreal2DReferences_County_Temp = [];
                    administrativeAreal2DReferences_ByCountyId[countyId] = administrativeAreal2DReferences_County_Temp;
                    countyIds_Coverage.Add(countyId);
                }

                administrativeAreal2DReferences_County_Temp.Add(administrativeAreal2DReference);
            }

            if (countyIds_Coverage.Count > Constants.OrtoDatas.MaximumCoverageCountyCount)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Coverage counting capped: {Count} counties named, at most {Maximum} are counted. The rest are answered as not measured.", countyIds_Coverage.Count, Constants.OrtoDatas.MaximumCoverageCountyCount);
                countyIds_Coverage = countyIds_Coverage.GetRange(0, Constants.OrtoDatas.MaximumCoverageCountyCount);
            }

            HashSet<int> allCountyIds = [.. countyIds, .. countyIds_Coverage];
            Serilog.Modify.Log("Counties resolved for estimated counts: {Count}", allCountyIds.Count);

            if (allCountyIds.Count != 0)
            {
                Dictionary<int, long>? counts_Building2D = await building2DPostgreSQLConverter.GetEstimatedCountsAsync(allCountyIds, analyze ?? false, commandTimeout: commandTimeout, cancellationToken: cancellationToken);
                Dictionary<int, long>? counts_OrtoDatas = await ortoDatasPostgreSQLConverter.GetEstimatedCountsAsync(allCountyIds, analyze ?? false, commandTimeout: commandTimeout, cancellationToken: cancellationToken);

                if (counts_Building2D is not null && counts_OrtoDatas is not null)
                {
                    foreach (KeyValuePair<int, List<int>> keyValuePair in countyIds_ByAdministrativeAreal2DId)
                    {
                        long count_Building2D = 0;
                        long count_OrtoDatas = 0;
                        List<int> countyIds_NotMeasured = [];

                        foreach (int countyId in keyValuePair.Value)
                        {
                            long count_Building2D_County = 0;
                            if (counts_Building2D.TryGetValue(countyId, out long count_Building2D_County_Val))
                            {
                                if (count_Building2D_County_Val < 0)
                                {
                                    countyIds_NotMeasured.Add(countyId);
                                    continue;
                                }

                                count_Building2D_County = count_Building2D_County_Val;
                            }

                            long count_OrtoDatas_County = 0;
                            if (counts_OrtoDatas.TryGetValue(countyId, out long count_OrtoDatas_Val))
                            {
                                if (count_OrtoDatas_Val < 0)
                                {
                                    countyIds_NotMeasured.Add(countyId);
                                    continue;
                                }

                                count_OrtoDatas_County = count_OrtoDatas_Val;
                            }

                            count_Building2D += count_Building2D_County;
                            count_OrtoDatas += count_OrtoDatas_County;
                        }

                        if (countyIds_NotMeasured.Count > 0)
                        {
                            Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "AdministrativeAreal2D {Id} has no measurement. Unmeasured counties: {CountyIds}", keyValuePair.Key, string.Join(",", countyIds_NotMeasured));
                            continue;
                        }

                        dictionary[keyValuePair.Key] = (count_Building2D, count_OrtoDatas);
                    }

                    List<int> countyIds_ToCount = [];
                    foreach (int countyId in countyIds_Coverage)
                    {
                        if (!counts_Building2D.TryGetValue(countyId, out long count_Building2D_County) || count_Building2D_County <= 0)
                        {
                            continue;
                        }

                        if (!counts_OrtoDatas.TryGetValue(countyId, out long count_OrtoDatas_Val) || count_OrtoDatas_Val == 0)
                        {
                            // County has buildings and 0 orthophotos (partition absent or 0 rows).
                            // Assign (count_Building2D_County, 0) so coverageFactor computes 0.0.
                            foreach (PostgreSQL.Classes.AdministrativeAreal2DReference administrativeAreal2DReference in administrativeAreal2DReferences_ByCountyId[countyId])
                            {
                                dictionary[administrativeAreal2DReference.Id] = (count_Building2D_County, 0);
                            }

                            continue;
                        }

                        countyIds_ToCount.Add(countyId);
                    }

                    if (countyIds_ToCount.Count > 0)
                    {
                        object object_Lock = new();
                        using SemaphoreSlim semaphoreSlim = new(4);
                        List<Task> tasks = [];

                        foreach (int countyId in countyIds_ToCount)
                        {
                            tasks.Add(Task.Run(async () =>
                            {
                                await semaphoreSlim.WaitAsync(cancellationToken);
                                try
                                {
                                    cancellationToken.ThrowIfCancellationRequested();
                                    List<PostgreSQL.Classes.OrtoDatasCoverageResult>? ortoDatasCoverageResults = await ortoDatasPostgreSQLConverter.SubdivisionCoveragesAsync(building2DPostgreSQLConverter, countyId, commandTimeout, cancellationToken);
                                    if (ortoDatasCoverageResults is null)
                                    {
                                        Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Coverage could not be counted for county {CountyId}", countyId);
                                        return;
                                    }

                                    Dictionary<int, (long Count_Building2D, long Count_OrtoDatas)> counts_BySubdivisionId = [];
                                    foreach (PostgreSQL.Classes.OrtoDatasCoverageResult ortoDatasCoverageResult in ortoDatasCoverageResults)
                                    {
                                        if (ortoDatasCoverageResult?.SubdivisionId is not int subdivisionId)
                                        {
                                            continue;
                                        }

                                        counts_BySubdivisionId[subdivisionId] = (ortoDatasCoverageResult.Building2DCount, ortoDatasCoverageResult.OrtoDatasCount);
                                    }

                                    List<PostgreSQL.Classes.AdministrativeAreal2DReference> administrativeAreal2DReferences_County_Coverage = administrativeAreal2DReferences_ByCountyId[countyId];

                                    List<PostgreSQL.Classes.AdministrativeAreal2DReference>? administrativeAreal2DReferences_Subdivision = null;
                                    if (administrativeAreal2DReferences_County_Coverage.Exists(x => x.AdministrativeArealType == AdministrativeArealType.Municipality))
                                    {
                                        administrativeAreal2DReferences_Subdivision = await administrativeAreal2DPostgreSQLConverter.GetAdministrativeAreal2DReferencesByAdministrativeArealTypeAsync(AdministrativeArealType.Subdivision, countyId, false, commandTimeout, cancellationToken);
                                    }

                                    foreach (PostgreSQL.Classes.AdministrativeAreal2DReference administrativeAreal2DReference in administrativeAreal2DReferences_County_Coverage)
                                    {
                                        HashSet<int> subdivisionIds = [];

                                        if (administrativeAreal2DReference.AdministrativeArealType == AdministrativeArealType.Subdivision)
                                        {
                                            subdivisionIds.Add(administrativeAreal2DReference.Id);
                                        }
                                        else
                                        {
                                            if (administrativeAreal2DReferences_Subdivision is null)
                                            {
                                                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Subdivisions could not be resolved for AdministrativeAreal2D {Id}", administrativeAreal2DReference.Id);
                                                continue;
                                            }

                                            foreach (PostgreSQL.Classes.AdministrativeAreal2DReference administrativeAreal2DReference_Subdivision in administrativeAreal2DReferences_Subdivision)
                                            {
                                                if (administrativeAreal2DReference_Subdivision?.MunicipalityId == administrativeAreal2DReference.Id)
                                                {
                                                    subdivisionIds.Add(administrativeAreal2DReference_Subdivision.Id);
                                                }
                                            }
                                        }

                                        long count_Building2D = 0;
                                        long count_OrtoDatas = 0;

                                        foreach (int subdivisionId in subdivisionIds)
                                        {
                                            if (!counts_BySubdivisionId.TryGetValue(subdivisionId, out (long Count_Building2D, long Count_OrtoDatas) value_Subdivision))
                                            {
                                                continue;
                                            }

                                            count_Building2D += value_Subdivision.Count_Building2D;
                                            count_OrtoDatas += value_Subdivision.Count_OrtoDatas;
                                        }

                                        lock (object_Lock)
                                        {
                                            dictionary[administrativeAreal2DReference.Id] = (count_Building2D, count_OrtoDatas);
                                        }
                                    }
                                }
                                finally
                                {
                                    semaphoreSlim.Release();
                                }
                            }, cancellationToken));
                        }

                        await Task.WhenAll(tasks);
                    }
                }
            }

            Func<long, long, double?> coverageFactor = new((count_Building2D, count_OrtoDatas) =>
            {
                // Null where unmeasured: negative counts mean an unanalysed partition, and a non-positive
                // building count means there are no buildings to be covered. A count_OrtoDatas of 0 with
                // positive buildings is a valid measurement of 0.0 coverage.
                if (count_Building2D <= 0 || count_OrtoDatas < 0)
                {
                    return null;
                }

                return Math.Clamp((double)count_OrtoDatas / (double)count_Building2D, 0.0, 1.0);
            });

            Serilog.Modify.Log("Counts calculated: {Count}", dictionary.Count);

            List<double?> result = [];
            foreach (int id in administrativeAreal2DIds_Temp)
            {
                if (!dictionary.TryGetValue(id, out (long Count_Building2D, long Count_OrtoDatas) value))
                {
                    Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "AdministrativeAreal2D has no measurement. Id: {Id}", id);
                    result.Add(null);
                    continue;
                }

                double? factor = coverageFactor(value.Count_Building2D, value.Count_OrtoDatas);
                Serilog.Modify.Log("Factor calculated: {Factor}", factor?.ToString() ?? "None");

                result.Add(factor);
            }

            return Ok(result);
        }

        /// <summary>
        /// Asynchronously retrieves the number of orthophoto rows stored for one county partition.
        /// <para>The cheapest question that can be asked of the store, and the one that separates a county nothing was ever downloaded for from one that was downloaded and holds nothing.</para>
        /// </summary>
        /// <param name="countyId">The identifier of the county partition to count.</param>
        /// <param name="estimated">Reads the planner's row estimate instead of counting the rows. Far faster on a large partition and accurate to a few percent, but it reflects the last time the partition was analysed rather than this moment. An unanalysed partition returns 204 NoContent.</param>
        /// <param name="analyze">A boolean value indicating whether to perform an ANALYZE operation before reading the estimate to ensure statistics are current.</param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout. Defaults to 600 seconds.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by the caller to cancel the asynchronous operation.</param>
        /// <returns>An <see cref="IActionResult"/> carrying the count, 204 NoContent when the partition exists but is unanalysed, or 404 NotFound when the county has no partition.</returns>
        [HttpGet("countbycountyid", Name = $"{nameof(OrtoDatasController)}_{nameof(GetCountByCountyIdAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(long), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCountByCountyIdAsync([FromQuery(Name = "countyid")] int countyId, [FromQuery(Name = "estimated")] bool estimated = false, [FromQuery(Name = "analyze")] bool analyze = false, [FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started for county {CountyId}", nameof(OrtoDatasController), nameof(GetCountByCountyIdAsync), countyId);

            if (ortoDatasPostgreSQLConverter is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "OrtoDatasPostgreSQLConverter cannot be null");
                return BadRequest();
            }

            if (commandTimeout < 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "CommandTimeout cannot be negative");
                return BadRequest();
            }

            long? count;
            try
            {
                count = estimated
                    ? await ortoDatasPostgreSQLConverter.GetEstimatedCountAsync(countyId, analyze, commandTimeout, cancellationToken)
                    : await ortoDatasPostgreSQLConverter.GetCountAsync(countyId, commandTimeout, cancellationToken);
            }
            catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                throw;
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "Database could not be queried");
                return StatusCode(500, "Internal server error during database query");
            }

            if (count is null || (!estimated && count < 0))
            {
                Serilog.Modify.Log("County {CountyId} has no orthophoto partition", countyId);
                return NotFound();
            }

            if (estimated && count < 0)
            {
                Serilog.Modify.Log("County {CountyId} orthophoto partition exists but has not been analysed", countyId);
                return NoContent();
            }

            return Ok(count.Value);
        }

        /// <summary>
        /// Asynchronously summarises what each of the named county partitions holds: how many rows, how many name a subdivision, how many distinct subdivisions they are spread across, and when they were written.
        /// <para>The measurement to take either side of a refresh. A building's subdivision is resolved in another database and pushed across, so <see cref="PostgreSQL.Classes.OrtoDatasCountyResult.WithSubdivisionIdCount"/> can only ever be gained - a run that lowers it is clearing subdivisions rather than filling them in, which is the defect of issues #23, #31 and #36.</para>
        /// <para>Naming no county summarises every partition, in one grouped statement. Counties holding no row are absent from the result rather than present with a zero.</para>
        /// </summary>
        /// <param name="countyIds">The identifiers of the county partitions to summarise, repeated once per county. Omit to summarise every one.</param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout. Defaults to 600 seconds.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by the caller to cancel the asynchronous operation.</param>
        /// <returns>An <see cref="IActionResult"/> carrying the summaries as JSON, or an error status.</returns>
        [HttpGet("summariesbycountyids", Name = $"{nameof(OrtoDatasController)}_{nameof(GetSummariesByCountyIdsAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(List<PostgreSQL.Classes.OrtoDatasCountyResult>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetSummariesByCountyIdsAsync([FromQuery(Name = "countyids")] List<int>? countyIds, [FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started for {CountyCount} counties", nameof(OrtoDatasController), nameof(GetSummariesByCountyIdsAsync), countyIds?.Count ?? 0);

            if (ortoDatasPostgreSQLConverter is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "OrtoDatasPostgreSQLConverter cannot be null");
                return BadRequest();
            }

            if (countyIds is not null && countyIds.Count > Constants.OrtoDatas.MaximumSummaryCountyCount)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Too many counties named: {Count}, the limit is {Maximum}", countyIds.Count, Constants.OrtoDatas.MaximumSummaryCountyCount);
                return BadRequest($"At most {Constants.OrtoDatas.MaximumSummaryCountyCount} counties may be named. Omit the parameter to summarise every one.");
            }

            List<PostgreSQL.Classes.OrtoDatasCountyResult>? ortoDatasCountyResults;
            try
            {
                ortoDatasCountyResults = await ortoDatasPostgreSQLConverter.GetSummariesByCountyIdsAsync(countyIds is null || countyIds.Count == 0 ? null : countyIds, commandTimeout, cancellationToken);
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "Database could not be queried");
                return StatusCode(500, "Internal server error during database query");
            }

            if (ortoDatasCountyResults is null)
            {
                return NotFound();
            }

            string? json = Core.Convert.ToSystem_String(ortoDatasCountyResults);
            if (string.IsNullOrWhiteSpace(json))
            {
                return NotFound();
            }

            Serilog.Modify.Log("Number of OrtoDatasCountyResults to be returned: {Count}", ortoDatasCountyResults.Count);
            return Content(json, "application/json");
        }

        /// <summary>
        /// Asynchronously compares, for one county, the subdivision each building is filed under against the one its orthophoto row carries.
        /// <para>The two tables live in different databases, so nothing keeps them in step on its own and no query can join them - each side is read once and matched in memory. This is the only place the two can be seen together.</para>
        /// <para>Read the result across a run rather than on its own. <c>OrtoDatasOnlyCount</c> counts rows whose orthophoto knows a subdivision the building no longer does, and nothing legitimate removes one, so a refresh that lowers it is doing damage. <c>Building2DOnlyCount</c> counts what a refresh exists to fix: it should fall to near zero and stay there, and climbing again once the download drains the queue is issue #36.</para>
        /// </summary>
        /// <param name="countyId">The identifier of the county to compare. One polygon part, not a code - a multi-part county is compared a part at a time.</param>
        /// <param name="sampleCount">How many references to name back per disagreeing category. The counts are exact whatever this is; the samples are what make a disagreement actionable.</param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of each command. A value of 0 disables the timeout. Defaults to 600 seconds.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by the caller to cancel the asynchronous operation.</param>
        /// <returns>An <see cref="IActionResult"/> carrying the comparison as JSON, or an error status.</returns>
        [HttpGet("subdivisionlinksbycountyid", Name = $"{nameof(OrtoDatasController)}_{nameof(GetSubdivisionLinksByCountyIdAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(PostgreSQL.Classes.OrtoDatasSubdivisionResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetSubdivisionLinksByCountyIdAsync([FromQuery(Name = "countyid")] int countyId, [FromQuery(Name = "samplecount")] int sampleCount = 20, [FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started for county {CountyId}", nameof(OrtoDatasController), nameof(GetSubdivisionLinksByCountyIdAsync), countyId);

            if (ortoDatasPostgreSQLConverter is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "OrtoDatasPostgreSQLConverter cannot be null");
                return BadRequest();
            }

            if (building2DPostgreSQLConverter is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Building2DPostgreSQLConverter cannot be null");
                return BadRequest();
            }

            if (sampleCount < 0 || sampleCount > Constants.OrtoDatas.MaximumSampleCount)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Sample count out of range: {Count}, the limit is {Maximum}", sampleCount, Constants.OrtoDatas.MaximumSampleCount);
                return BadRequest($"Sample count must be between 0 and {Constants.OrtoDatas.MaximumSampleCount}.");
            }

            PostgreSQL.Classes.OrtoDatasSubdivisionResult? ortoDatasSubdivisionResult;
            try
            {
                ortoDatasSubdivisionResult = await ortoDatasPostgreSQLConverter.SubdivisionLinksAsync(building2DPostgreSQLConverter, countyId, sampleCount, commandTimeout, cancellationToken);
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "Database could not be queried");
                return StatusCode(500, "Internal server error during database query");
            }

            if (ortoDatasSubdivisionResult is null)
            {
                return NotFound();
            }

            string? json = Core.Convert.ToSystem_String(ortoDatasSubdivisionResult);
            if (string.IsNullOrWhiteSpace(json))
            {
                return NotFound();
            }

            Serilog.Modify.Log(
                "County {CountyId} compared: {MatchedCount} matched, orthophoto only {OrtoDatasOnlyCount}, building only {Building2DOnlyCount}, disagreeing {DisagreeCount}",
                countyId, ortoDatasSubdivisionResult.MatchedCount, ortoDatasSubdivisionResult.OrtoDatasOnlyCount, ortoDatasSubdivisionResult.Building2DOnlyCount, ortoDatasSubdivisionResult.DisagreeCount);

            return Content(json, "application/json");
        }

        /// <summary>
        /// Asynchronously reports what each of the named counties still has waiting in the orthophoto download queue.
        /// <para>Reads the queue without claiming anything from it, unlike <see cref="NextBuilding2DReferencesAsync(int, int, int, int, CancellationToken)"/>, which claims the rows it returns. It is the only way to see what a refresh queued, and the way to watch the refresh and the download move against each other.</para>
        /// <para>Naming no county reports every one. Counties with nothing waiting are absent from the result rather than present with a zero, so an empty result means the queue is drained.</para>
        /// </summary>
        /// <param name="countyIds">The identifiers of the counties to report on, repeated once per county. Omit to report every one.</param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout. Defaults to 600 seconds.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by the caller to cancel the asynchronous operation.</param>
        /// <returns>An <see cref="IActionResult"/> carrying the queue depths as JSON, or an error status.</returns>
        [HttpGet("queuesummariesbycountyids", Name = $"{nameof(OrtoDatasController)}_{nameof(GetQueueSummariesByCountyIdsAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(List<PostgreSQL.Classes.OrtoDatasQueueResult>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetQueueSummariesByCountyIdsAsync([FromQuery(Name = "countyids")] List<int>? countyIds, [FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started for {CountyCount} counties", nameof(OrtoDatasController), nameof(GetQueueSummariesByCountyIdsAsync), countyIds?.Count ?? 0);

            if (ortoDatasPostgreSQLConverter is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "OrtoDatasPostgreSQLConverter cannot be null");
                return BadRequest();
            }

            if (countyIds is not null && countyIds.Count > Constants.OrtoDatas.MaximumSummaryCountyCount)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Too many counties named: {Count}, the limit is {Maximum}", countyIds.Count, Constants.OrtoDatas.MaximumSummaryCountyCount);
                return BadRequest($"At most {Constants.OrtoDatas.MaximumSummaryCountyCount} counties may be named. Omit the parameter to report every one.");
            }

            List<PostgreSQL.Classes.OrtoDatasQueueResult>? ortoDatasQueueResults;
            try
            {
                ortoDatasQueueResults = await ortoDatasPostgreSQLConverter.GetQueueSummariesByCountyIdsAsync(countyIds is null || countyIds.Count == 0 ? null : countyIds, commandTimeout, cancellationToken);
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "Database could not be queried");
                return StatusCode(500, "Internal server error during database query");
            }

            // Null rather than empty means the queue table has never been created, which is to say no refresh
            // has ever run - a different fact to a queue that is simply drained.
            if (ortoDatasQueueResults is null)
            {
                return NotFound();
            }

            string? json = Core.Convert.ToSystem_String(ortoDatasQueueResults);
            if (string.IsNullOrWhiteSpace(json))
            {
                return NotFound();
            }

            Serilog.Modify.Log("Number of OrtoDatasQueueResults to be returned: {Count}", ortoDatasQueueResults.Count);
            return Content(json, "application/json");
        }
        /// <summary>
        /// Asynchronously retrieves an orthodata item based on the specified reference and optional county identifier.
        /// </summary>
        /// <param name="reference">The unique reference string used to locate the orthodata item.</param>
        /// <param name="countyId">The optional identifier of the county associated with the orthodata item.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by the caller to cancel the asynchronous operation.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        [HttpGet("itembyreference", Name = $"{nameof(OrtoDatasController)}_{nameof(GetItemByReferenceAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        public async Task<IActionResult> GetItemByReferenceAsync([FromQuery(Name = "reference")] string reference, [FromQuery(Name = "countyid")] int? countyId = null, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(OrtoDatasController), nameof(GetItemByReferenceAsync));
            Serilog.Modify.Log("Reference provided: {Reference}", reference ?? string.Empty);
            Serilog.Modify.Log("CountyId provided: {CountyId}", countyId?.ToString() ?? string.Empty);

            if (string.IsNullOrWhiteSpace(reference))
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Reference cannot be null or whitespace");
                return BadRequest("Reference cannot be null or whitespace.");
            }

            PostgreSQL.Classes.OrtoDatas? ortoDatas = await ortoDatasPostgreSQLConverter.GetOrtoDatasByReferenceAsync(reference, countyId, cancellationToken: cancellationToken);
            if (ortoDatas is null)
            {
                return NoContent();
            }

            OrtoDatas? ortoDatas_DiGi = ortoDatas.ToDiGi();
            if (ortoDatas_DiGi is null)
            {
                return NoContent();
            }

            return Content(Core.Convert.ToSystem_String((Core.Interfaces.ISerializableObject)ortoDatas_DiGi) ?? string.Empty, "application/json");
        }

        /// <summary>
        /// Retrieves an orthodata reference by its unique reference code and an optional county identifier.
        /// </summary>
        /// <param name="reference">The unique reference string of the building to retrieve orthodata metadata for.</param>
        /// <param name="countyId">The optional integer identifier of the county used to filter the search.</param>
        /// <param name="fallbackByReference">A boolean value indicating whether to perform a fallback search across all partitions if not matched by county.</param>
        /// <param name="cancellationToken">The cancellation token to observe.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        [HttpGet("ortodatasreferencebyreference", Name = $"{nameof(OrtoDatasController)}_{nameof(GetOrtoDatasReferenceByReferenceAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(PostgreSQL.Classes.OrtoDatasReference), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetOrtoDatasReferenceByReferenceAsync([FromQuery(Name = "reference")] string reference, [FromQuery(Name = "countyid")] int? countyId = null, [FromQuery(Name = "fallbackbyreference")] bool fallbackByReference = false, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(OrtoDatasController), nameof(GetOrtoDatasReferenceByReferenceAsync));
            Serilog.Modify.Log("Reference provided: {Reference}", reference ?? string.Empty);
            Serilog.Modify.Log("CountyId provided: {CountyId}", countyId?.ToString() ?? string.Empty);

            if (string.IsNullOrWhiteSpace(reference) || (countyId is not null && countyId <= 0))
            {
                return BadRequest();
            }

            if (ortoDatasPostgreSQLConverter is null)
            {
                return BadRequest();
            }

            PostgreSQL.Classes.OrtoDatasReference? ortoDatasReference = await ortoDatasPostgreSQLConverter.GetOrtoDatasReferenceByReferenceAsync(reference, countyId, fallbackByReference, cancellationToken: cancellationToken);
            if (ortoDatasReference is null)
            {
                return NotFound();
            }

            string? json = Core.Convert.ToSystem_String(ortoDatasReference);
            if (string.IsNullOrWhiteSpace(json))
            {
                return NotFound();
            }

            return Content(json, "application/json");
        }

        /// <summary>
        /// Retrieves a list of orthodata references for the specified building reference codes and optional county identifier.
        /// </summary>
        /// <param name="references">A collection of unique reference strings to query.</param>
        /// <param name="countyId">The optional integer identifier of the county used to filter the search.</param>
        /// <param name="fallbackByReference">A boolean value indicating whether to perform a fallback search across all partitions if not matched by county.</param>
        /// <param name="cancellationToken">The cancellation token to observe.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        [HttpPost("ortodatasreferencesbyreferences", Name = $"{nameof(OrtoDatasController)}_{nameof(GetOrtoDatasReferencesByReferencesAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(List<PostgreSQL.Classes.OrtoDatasReference>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetOrtoDatasReferencesByReferencesAsync([FromBody] IEnumerable<string> references, [FromQuery(Name = "countyid")] int? countyId = null, [FromQuery(Name = "fallbackbyreference")] bool fallbackByReference = false, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(OrtoDatasController), nameof(GetOrtoDatasReferencesByReferencesAsync));
            Serilog.Modify.Log("CountyId provided: {CountyId}", countyId?.ToString() ?? string.Empty);

            if (references is null || !references.Any() || (countyId is not null && countyId <= 0))
            {
                return BadRequest();
            }

            if (ortoDatasPostgreSQLConverter is null)
            {
                return BadRequest();
            }

            List<PostgreSQL.Classes.OrtoDatasReference>? ortoDatasReferences = await ortoDatasPostgreSQLConverter.GetOrtoDatasReferencesByReferencesAsync(references, countyId, fallbackByReference, cancellationToken: cancellationToken);
            if (ortoDatasReferences is null)
            {
                return NotFound();
            }

            string? json = Core.Convert.ToSystem_String(ortoDatasReferences);
            if (string.IsNullOrWhiteSpace(json))
            {
                return NotFound();
            }

            return Content(json, "application/json");
        }

        /// <summary>
        /// Retrieves a list of orthodata references for the specified building 2D reference objects.
        /// </summary>
        /// <param name="building2DReferences">A collection of <see cref="PostgreSQL.Classes.Building2DReference"/> objects to query.</param>
        /// <param name="fallbackByReference">A boolean value indicating whether to perform a fallback search across all partitions if not matched by county.</param>
        /// <param name="cancellationToken">The cancellation token to observe.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        [HttpPost("ortodatasreferencesbybuilding2dreferences", Name = $"{nameof(OrtoDatasController)}_{nameof(GetOrtoDatasReferencesByBuilding2DReferencesAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(List<PostgreSQL.Classes.OrtoDatasReference>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetOrtoDatasReferencesByBuilding2DReferencesAsync([FromBody] IEnumerable<PostgreSQL.Classes.Building2DReference> building2DReferences, [FromQuery(Name = "fallbackbyreference")] bool fallbackByReference = false, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(OrtoDatasController), nameof(GetOrtoDatasReferencesByBuilding2DReferencesAsync));

            if (building2DReferences is null || !building2DReferences.Any())
            {
                return BadRequest();
            }

            if (ortoDatasPostgreSQLConverter is null)
            {
                return BadRequest();
            }

            List<PostgreSQL.Classes.OrtoDatasReference>? ortoDatasReferences = await ortoDatasPostgreSQLConverter.GetOrtoDatasReferencesByBuilding2DReferencesAsync(building2DReferences, fallbackByReference, cancellationToken: cancellationToken);
            if (ortoDatasReferences is null)
            {
                return NotFound();
            }

            string? json = Core.Convert.ToSystem_String(ortoDatasReferences);
            if (string.IsNullOrWhiteSpace(json))
            {
                return NotFound();
            }

            return Content(json, "application/json");
        }

        /// <summary>
        /// Retrieves a list of orthodata references for a specified county, with optional subdivision filtering.
        /// </summary>
        /// <param name="countyId">The integer identifier of the county.</param>
        /// <param name="subdivisionIds">An optional array of subdivision identifiers to filter by.</param>
        /// <param name="cancellationToken">The cancellation token to observe.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        [HttpGet("ortodatasreferencesbycountyid", Name = $"{nameof(OrtoDatasController)}_{nameof(GetOrtoDatasReferencesByCountyIdAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(List<PostgreSQL.Classes.OrtoDatasReference>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetOrtoDatasReferencesByCountyIdAsync([FromQuery(Name = "countyid")] int countyId, [FromQuery(Name = "subdivisionids")] int[]? subdivisionIds = null, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(OrtoDatasController), nameof(GetOrtoDatasReferencesByCountyIdAsync));
            Serilog.Modify.Log("CountyId provided: {CountyId}", countyId);

            if (countyId <= 0)
            {
                return BadRequest();
            }

            if (ortoDatasPostgreSQLConverter is null)
            {
                return BadRequest();
            }

            List<PostgreSQL.Classes.OrtoDatasReference>? ortoDatasReferences = await ortoDatasPostgreSQLConverter.GetOrtoDatasReferencesByCountyIdAsync(countyId, subdivisionIds, cancellationToken: cancellationToken);
            if (ortoDatasReferences is null)
            {
                return NotFound();
            }

            string? json = Core.Convert.ToSystem_String(ortoDatasReferences);
            if (string.IsNullOrWhiteSpace(json))
            {
                return NotFound();
            }

            return Content(json, "application/json");
        }

        /// <summary>
        /// Retrieves and claims the next batch of building 2D reference objects from the update queue.
        /// </summary>
        /// <param name="count">The maximum number of building 2D reference objects to retrieve. Defaults to 100.</param>
        /// <param name="claimTimeoutMinutes">The duration in minutes before an unacknowledged claim expires and returns to the queue. Defaults to 30.</param>
        /// <param name="maxAttempts">The maximum number of claim attempts before a reference is retired as a poison row. Defaults to 5.</param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout. Defaults to 60 seconds.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by the caller to cancel the asynchronous operation.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        [HttpPost("nextbuilding2dreferences", Name = $"{nameof(OrtoDatasController)}_{nameof(NextBuilding2DReferencesAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(List<PostgreSQL.Classes.Building2DReference>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> NextBuilding2DReferencesAsync([FromQuery(Name = "count")] int count = 100, [FromQuery(Name = "claimtimeoutminutes")] int claimTimeoutMinutes = 30, [FromQuery(Name = "maxattempts")] int maxAttempts = 5, [FromQuery(Name = "commandtimeout")] int commandTimeout = 60, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(OrtoDatasController), nameof(NextBuilding2DReferencesAsync));
            Serilog.Modify.Log("Count provided: {Count}, ClaimTimeoutMinutes: {ClaimTimeoutMinutes}, MaxAttempts: {MaxAttempts}, CommandTimeout: {CommandTimeout}", count, claimTimeoutMinutes, maxAttempts, commandTimeout);

            if (count <= 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Count must be greater than 0");
                return BadRequest("Count must be greater than 0.");
            }

            if (claimTimeoutMinutes <= 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Claim timeout minutes must be greater than 0");
                return BadRequest("Claim timeout minutes must be greater than 0.");
            }

            if (maxAttempts <= 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Max attempts must be greater than 0");
                return BadRequest("Max attempts must be greater than 0.");
            }

            if (ortoDatasPostgreSQLConverter is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "OrtoDatasPostgreSQLConverter is null");
                return BadRequest();
            }

            Serilog.Modify.Log("Extracting data starting");

            List<PostgreSQL.Classes.Building2DReference>? building2DReferences = await ortoDatasPostgreSQLConverter.GetNextBuilding2DReferencesAsync(count, claimTimeoutMinutes, maxAttempts, commandTimeout, cancellationToken: cancellationToken);

            Serilog.Modify.Log("Extracting data ended");

            if (building2DReferences is null || building2DReferences.Count == 0)
            {
                Serilog.Modify.Log("No content extracted");
                return NoContent();
            }

            Serilog.Modify.Log("{Count} items extracted", building2DReferences.Count);

            return Content(Core.Convert.ToSystem_String(building2DReferences) ?? string.Empty, "application/json");
        }

        /// <summary>
        /// Acknowledges and deletes completed building 2D reference objects from the update queue.
        /// </summary>
        /// <param name="ids">The collection of queue entry identifiers to acknowledge and remove from the queue.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by the caller to cancel the asynchronous operation.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        [HttpPost("acknowledgebuilding2dreferences", Name = $"{nameof(OrtoDatasController)}_{nameof(AcknowledgeBuilding2DReferencesAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(long), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AcknowledgeBuilding2DReferencesAsync([FromBody] IEnumerable<long>? ids, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(OrtoDatasController), nameof(AcknowledgeBuilding2DReferencesAsync));

            if (ids is null || !ids.Any())
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Ids collection cannot be null or empty");
                return BadRequest("The ids collection cannot be null or empty.");
            }

            if (ortoDatasPostgreSQLConverter is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "OrtoDatasPostgreSQLConverter is null");
                return BadRequest();
            }

            try
            {
                long count_Deleted = await ortoDatasPostgreSQLConverter.AcknowledgeBuilding2DReferencesAsync(ids, cancellationToken: cancellationToken);
                if (count_Deleted < 0)
                {
                    Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Error occurred during acknowledgement in database");
                    return StatusCode(500, "Internal server error during acknowledgement");
                }

                Serilog.Modify.Log("{Count} items acknowledged and removed from queue", count_Deleted);
                return Ok(count_Deleted);
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "Database could not be updated during acknowledgement");
                return StatusCode(500, "Internal server error during database update");
            }
        }

        /// <summary>
        /// Updates multiple orthophoto data items based on the provided JSON array and code.
        /// <para>A county code does not identify a single county row: BDOT10k stores a county whose territory is disconnected as one feature per polygon part, and every part becomes its own row. Every part the code names is passed on, and each entry is filed under the part it actually belongs to - see <see cref="UpdateItemsByCountyIdsAsync"/> for how that is decided.</para>
        /// </summary>
        /// <param name="jsonArray">The JSON array containing the orthophoto data items to be updated.</param>
        /// <param name="code">The unique identifier or code used to identify the items for update.</param>
        /// <param name="key">The secret access key supplied in the request header.</param>
        /// <param name="cancellationToken">The cancellation token to observe.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        [HttpPost("updateitemsbycode", Name = $"{nameof(OrtoDatasController)}_{nameof(UpdateItemsByCodeAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(UpdateItemsResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateItemsByCodeAsync([FromBody] JsonArray? jsonArray, [FromQuery(Name = "code")] string code, [FromHeader(Name = "key")] string? key = null, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(OrtoDatasController), nameof(UpdateItemsByCodeAsync));
            Serilog.Modify.Log("Code provided: {Code}", code ?? string.Empty);

            if (code is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "code cannot be null");
                return BadRequest();
            }

            if (!GISWebAPIConfigurationFileWatcher.IsAuthorized(key))
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "OrtoDatas update not authorized");
                return Unauthorized();
            }

            if (!GISWebAPIConfigurationFileWatcher.AllowUpdateOrtoDatas)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "OrtoDatas update not allowed");
                return BadRequest();
            }

            if (administrativeAreal2DPostgreSQLConverter is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "AdministrativeAreal2DPostgreSQLConverter is null");
                return BadRequest();
            }

            if (jsonArray is null || jsonArray.Count == 0)
            {
                Serilog.Modify.Log("No OrtoDatas to update");
                return NoContent();
            }

            HashSet<int>? countyIds = await administrativeAreal2DPostgreSQLConverter.GetIdsByCodeAsync(code, AdministrativeArealType.County);
            if (countyIds is null || countyIds.Count == 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "County code '{Code}' was not found in database", code);
                return BadRequest();
            }

            int[] countyIds_Resolved = [.. countyIds.OrderBy(x => x)];

            // Collapsing an ambiguous code onto one row is what let the skew in this table go unnoticed:
            // the upload reported success while everything filed under a sibling row read back empty.
            // Every part is passed on instead, and the batch is split between them per entry.
            if (countyIds_Resolved.Length > 1)
            {
                Serilog.Modify.Log("County code '{Code}' matches {Count} rows ({CountyIds}) because the county has that many polygon parts. Each entry is being filed under the part it belongs to", code, countyIds_Resolved.Length, string.Join(", ", countyIds_Resolved));
            }

            return await UpdateItemsByCountyIdsAsync(jsonArray, countyIds_Resolved, key, cancellationToken);
        }

        /// <summary>
        /// Updates orthodata items associated with the given county rows.
        /// <para>A single identifier is taken as stated and every entry is filed under it. Several identifiers are the polygon parts of one multi-part county, and each entry is then filed under the part it belongs to, decided in two steps:</para>
        /// <para>1. the part already holding the entry's <c>building_2d</c> row, probed lowest part first. That row was filed by geometry when it was imported, and reusing its answer keeps both tables keyed by the same <c>(county_id, reference)</c> pair - orthodata filed under a part its building is not stored in reads back as missing.</para>
        /// <para>2. geometry, for an entry no part holds a 2D row for: the part containing its bounding box, else the nearest part, else the part it overlaps most. Done by the converter, which drops an entry it cannot place rather than filing it under a guess.</para>
        /// </summary>
        /// <param name="jsonArray">The JSON array containing the orthodata items to be updated.</param>
        /// <param name="countyIds">The identifiers of the county rows the entries belong to. Normally every polygon part of one county.</param>
        /// <param name="key">The secret access key supplied in the request header.</param>
        /// <param name="cancellationToken">The cancellation token to observe.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        [HttpPost("updateitemsbycountyids", Name = $"{nameof(OrtoDatasController)}_{nameof(UpdateItemsByCountyIdsAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(UpdateItemsResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateItemsByCountyIdsAsync([FromBody] JsonArray? jsonArray, [FromQuery(Name = "countyids")] int[]? countyIds, [FromHeader(Name = "key")] string? key = null, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(OrtoDatasController), nameof(UpdateItemsByCountyIdsAsync));
            Serilog.Modify.Log("CountyIds provided: {CountyIds}", countyIds is null ? string.Empty : string.Join(", ", countyIds));

            if (!GISWebAPIConfigurationFileWatcher.IsAuthorized(key))
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "OrtoDatas update not authorized");
                return Unauthorized();
            }

            if (!GISWebAPIConfigurationFileWatcher.AllowUpdateOrtoDatas)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "OrtoDatas update not allowed");
                return BadRequest();
            }

            if (countyIds is null || countyIds.Length == 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "CountyIds cannot be null or empty");
                return BadRequest();
            }

            if (jsonArray is null || jsonArray.Count == 0)
            {
                Serilog.Modify.Log("No OrtoDatas to update");
                return NoContent();
            }

            List<OrtoDatas>? ortoDatas = Core.Create.SerializableObjects<OrtoDatas>(jsonArray);
            if (ortoDatas is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "OrtoDatas could not be converted from json");
                return BadRequest();
            }

            Serilog.Modify.Log("OrtoDatas conversion to PostgreSQL started. OrtoDatas count: {Count}", ortoDatas.Count);

            List<int> countyIds_Candidate = [.. new HashSet<int>(countyIds).OrderBy(x => x)];

            // Left unset while there is more than one candidate, so the county is decided below rather than
            // baked in here.
            int? countyId_Single = countyIds_Candidate.Count == 1 ? countyIds_Candidate[0] : null;

            List<PostgreSQL.Classes.OrtoDatas> ortoDatas_PostgreSQL = [];
            foreach (OrtoDatas ortoDatas_Temp in ortoDatas)
            {
                PostgreSQL.Classes.OrtoDatas? ortoDatas_PostgreSQL_Temp = ortoDatas_Temp.ToPostgreSQL(countyId_Single);
                if (ortoDatas_PostgreSQL_Temp is null)
                {
                    continue;
                }

                ortoDatas_PostgreSQL.Add(ortoDatas_PostgreSQL_Temp);
            }

            if (ortoDatas_PostgreSQL is null || ortoDatas_PostgreSQL.Count == 0)
            {
                Serilog.Modify.Log("No OrtoDatas PostgreSQL to update");
                return NoContent();
            }

            if (countyId_Single is null)
            {
                Dictionary<string, int> countyIds_ByReference = await building2DPostgreSQLConverter.CountyIdsByReferencesAsync(ortoDatas_PostgreSQL.ConvertAll(x => x.Reference), countyIds_Candidate);

                List<string> references_Unresolved = [];
                foreach (PostgreSQL.Classes.OrtoDatas ortoDatas_PostgreSQL_Temp in ortoDatas_PostgreSQL)
                {
                    if (ortoDatas_PostgreSQL_Temp.Reference is not null && countyIds_ByReference.TryGetValue(ortoDatas_PostgreSQL_Temp.Reference, out int countyId))
                    {
                        ortoDatas_PostgreSQL_Temp.CountyId = countyId;
                        continue;
                    }

                    references_Unresolved.Add(ortoDatas_PostgreSQL_Temp.Reference ?? string.Empty);
                }

                if (references_Unresolved.Count != 0)
                {
                    // Not a failure: these fall through to the converter, which decides them by geometry and
                    // rejects only what it cannot place at all.
                    Serilog.Modify.Log("OrtoDatas with no Building2D under the given parts, left to be decided by geometry: {Count}/{Total}. References: {References}", references_Unresolved.Count, ortoDatas_PostgreSQL.Count, string.Join(", ", references_Unresolved.Take(20)));
                }
            }

            Serilog.Modify.Log("OrtoDatas conversion to PostgreSQL ended. OrtoDatas converted: {After}/{Before}", ortoDatas_PostgreSQL.Count, ortoDatas.Count);

            Serilog.Modify.Log("Updating to database starting");

            PostgreSQL.Classes.PostgreSQLUpdateResult? postgreSQLUpdateResult = null;
            try
            {
                postgreSQLUpdateResult = await ortoDatasPostgreSQLConverter.UpdateAsync(ortoDatas_PostgreSQL, countyIds_Candidate);
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "Database could not be updated");
                return StatusCode(500, "Database update failed.");
            }

            UpdateItemsResult? updateItemsResult = postgreSQLUpdateResult.UpdateItemsResult(ortoDatas_PostgreSQL.Count);
            if (updateItemsResult is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Updating to database could not be attempted");
                return StatusCode(500, "Database update failed.");
            }

            // A drop means the row carried no geometry, no part could be decided for it, or a partition
            // could not be created. It is still a partial write, and it used to leave no trace.
            if (updateItemsResult.Rejected.Count != 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "OrtoDatas rejected before the database: {Count}/{Total}. References: {References}", updateItemsResult.Rejected.Count, updateItemsResult.Sent, updateItemsResult.Rejected.RejectionSample());
            }

            // Answering Ok here is what let a whole county regeneration report success while writing
            // nothing: the storage database was unreachable, every batch came back empty, and the client
            // treats 200 as done. OrtoDatas were converted and reached this point, so nothing updated is a
            // failure, not a quiet no-op. BuildingController already answers this case the same way.
            if (updateItemsResult.Updated == 0)
            {
                if (updateItemsResult.Rejected.Count == updateItemsResult.Sent)
                {
                    return StatusCode(500, $"All {updateItemsResult.Sent} OrtoDatas were rejected before the database; none could be filed under a county.");
                }

                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Updating to database ended but no OrtoDatas have been updated");
                return StatusCode(500, "Database update returned no modified OrtoDatas IDs.");
            }

            // Updated counts distinct identifiers, and rows colliding on (reference, county_id) share one,
            // so Updated < Sent on its own proves nothing. Rejected is the exact figure.
            Serilog.Modify.Log("Updating to database ended. Updated OrtoDatas: {After}/{Before}, rejected: {Rejected}", updateItemsResult.Updated, updateItemsResult.Sent, updateItemsResult.Rejected.Count);

            return Ok(updateItemsResult);
        }

        /// <summary>
        /// Retrieves orthophoto image data based on the provided reference, year, and optional county identifier.
        /// </summary>
        /// <param name="reference">The unique reference string of the orthophoto image.</param>
        /// <param name="year">The production or capture year of the orthophoto image.</param>
        /// <param name="countyId">The optional identifier of the county associated with the orthophoto data.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by the caller to cancel the asynchronous operation.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        [HttpGet("imagebyreference", Name = $"{nameof(OrtoDatasController)}_{nameof(GetImageByReferenceAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [Produces("image/jpeg")]
        [ProducesResponseType(typeof(FileContentResult), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetImageByReferenceAsync([FromQuery(Name = "reference")] string reference, [FromQuery(Name = "year")] short year, [FromQuery(Name = "countyid")] int? countyId = null, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(OrtoDatasController), nameof(GetImageByReferenceAsync));
            Serilog.Modify.Log("Reference provided: {Reference}", reference ?? string.Empty);
            Serilog.Modify.Log("CountyId provided: {CountyId}", countyId?.ToString() ?? string.Empty);
            Serilog.Modify.Log("Year provided: {Year}", year.ToString());

            if (string.IsNullOrWhiteSpace(reference))
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Reference cannot be null or whitespace");
                return BadRequest("Reference cannot be null or whitespace.");
            }

            PostgreSQL.Classes.OrtoDatas? ortoDatas = await ortoDatasPostgreSQLConverter.GetOrtoDatasByReferenceAsync(reference, countyId, cancellationToken: cancellationToken);
            if (ortoDatas is null)
            {
                return NotFound();
            }

            byte[]? bytes = ortoDatas.ToDiGi()?.GetBytes(new DateTime(year, 1, 1));
            if (bytes is null)
            {
                return NotFound();
            }

            return File(bytes, "image/jpeg");
        }
    }
}