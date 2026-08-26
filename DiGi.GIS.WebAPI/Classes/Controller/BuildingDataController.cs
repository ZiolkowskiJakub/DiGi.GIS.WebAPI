using DiGi.Core.IO.Table.Classes;
using DiGi.GIS.PostgreSQL;
using DiGi.GIS.PostgreSQL.Classes;
using DiGi.PostgreSQL.Table;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DiGi.GIS.WebAPI.Classes
{
    /// <summary>
    /// Controller responsible for handling API requests related to building data retrieved from a PostgreSQL database.
    /// </summary>
    [ApiController]
    [Route("gis/[controller]")]
    public class BuildingDataController : DiGi.WebAPI.Classes.WebAPIController
    {
        /// <summary>
        /// The largest number of references one request may ask for.
        /// <para>The whole collection travels into a single statement, so an unbounded list is an unbounded statement. A caller with more than this to ask about should page rather than widen the request.</para>
        /// </summary>
        private const int referenceCount_Maximum = 10000;

        private readonly BuildingDataPostgreSQLConverter buildingDataPostgreSQLConverter;

        private readonly Building2DPostgreSQLConverter building2DPostgreSQLConverter;

        /// <summary>
        /// Initializes a new instance of the BuildingDataController class.
        /// <para>Both converters are taken on the one constructor rather than the building data one alone, because the coverage read compares two tables that sit in different databases. A second constructor is not an option: a controller with more than one public constructor fails activation and answers 500 on every one of its endpoints.</para>
        /// </summary>
        /// <param name="buildingDataPostgreSQLConverter">The <see cref="BuildingDataPostgreSQLConverter" /> used to handle building data operations and database conversions.</param>
        /// <param name="building2DPostgreSQLConverter">The <see cref="Building2DPostgreSQLConverter" /> used to read the buildings a county holds, which is the other half of the coverage comparison.</param>
        public BuildingDataController(BuildingDataPostgreSQLConverter buildingDataPostgreSQLConverter, Building2DPostgreSQLConverter building2DPostgreSQLConverter)
        {
            this.buildingDataPostgreSQLConverter = buildingDataPostgreSQLConverter;
            this.building2DPostgreSQLConverter = building2DPostgreSQLConverter;
        }

        /// <summary>
        /// Asynchronously retrieves all available building data column categories.
        /// </summary>
        /// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        [HttpGet("categories", Name = $"{nameof(BuildingDataController)}_{nameof(GetCategoriesAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCategoriesAsync([FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(BuildingDataController), nameof(GetCategoriesAsync));

            if (commandTimeout < 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "CommandTimeout cannot be negative");
                return BadRequest();
            }

            try
            {
                HashSet<string>? categories = await buildingDataPostgreSQLConverter.GetCategoriesAsync(commandTimeout, cancellationToken);
                if (categories is null || categories.Count == 0)
                {
                    return NotFound();
                }

                JsonArray jsonArray = [.. categories];

                string? json = jsonArray.ToJsonString();
                if (string.IsNullOrWhiteSpace(json))
                {
                    return NotFound();
                }

                return Content(json, "application/json");
            }
            catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                throw;
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "{Type}:{Name} failed", nameof(BuildingDataController), nameof(GetCategoriesAsync));
                return StatusCode(500, "Internal server error during database query");
            }
        }

        /// <summary>
        /// Asynchronously retrieves all column references, optionally filtered by the specified categories.
        /// </summary>
        /// <param name="categories">An optional list of category names to filter the column references by.</param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
        /// <returns>A task representing the asynchronous operation, returning a list of column references.</returns>
        [HttpGet("columnreferences", Name = $"{nameof(BuildingDataController)}_{nameof(GetColumnReferencesAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(List<DiGi.PostgreSQL.Table.Classes.ColumnReference>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetColumnReferencesAsync([FromQuery(Name = "categories")] List<string>? categories = null, [FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(BuildingDataController), nameof(GetColumnReferencesAsync));

            if (commandTimeout < 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "CommandTimeout cannot be negative");
                return BadRequest();
            }

            try
            {
                List<DiGi.PostgreSQL.Table.Classes.ColumnReference>? columnReferences = await buildingDataPostgreSQLConverter.GetColumnReferencesByCategoriesAsync(categories, commandTimeout, cancellationToken);
                if (columnReferences is null || columnReferences.Count == 0)
                {
                    return NotFound();
                }

                string? json = Core.Convert.ToSystem_String(columnReferences);
                if (string.IsNullOrWhiteSpace(json))
                {
                    return NotFound();
                }

                return Content(json, "application/json");
            }
            catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                throw;
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "{Type}:{Name} failed", nameof(BuildingDataController), nameof(GetColumnReferencesAsync));
                return StatusCode(500, "Internal server error during database query");
            }
        }

        /// <summary>
        /// Asynchronously retrieves all available column definitions for building data.
        /// </summary>
        /// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        [HttpGet("columns", Name = $"{nameof(BuildingDataController)}_{nameof(GetColumnsAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(List<DiGi.PostgreSQL.Table.Classes.Column>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetColumnsAsync([FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(BuildingDataController), nameof(GetColumnsAsync));

            if (commandTimeout < 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "CommandTimeout cannot be negative");
                return BadRequest();
            }

            try
            {
                List<Column>? columns = await buildingDataPostgreSQLConverter.GetColumnsByCategoriesAsync(commandTimeout: commandTimeout, cancellationToken: cancellationToken);
                if (columns is null || columns.Count == 0)
                {
                    return NotFound();
                }

                List<DiGi.PostgreSQL.Table.Classes.Column>? columns_PostgreSQL = DiGi.PostgreSQL.Table.Convert.ToDiGi(columns);

                string? json = Core.Convert.ToSystem_String(columns_PostgreSQL);
                if (string.IsNullOrWhiteSpace(json))
                {
                    return NotFound();
                }

                return Content(json, "application/json");
            }
            catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                throw;
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "{Type}:{Name} failed", nameof(BuildingDataController), nameof(GetColumnsAsync));
                return StatusCode(500, "Internal server error during database query");
            }
        }

        /// <summary>
        /// Asynchronously retrieves all columns filtered by the specified categories.
        /// </summary>
        /// <param name="categories">An optional list of category names to filter the columns by. If null, the filtering behavior is determined by the underlying data source.</param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        [HttpPost("columnsbycategories", Name = $"{nameof(BuildingDataController)}_{nameof(GetColumnsByCategoriesAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(List<DiGi.PostgreSQL.Table.Classes.Column>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetColumnsByCategoriesAsync([FromBody] List<string>? categories = null, [FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(BuildingDataController), nameof(GetColumnsByCategoriesAsync));

            if (commandTimeout < 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "CommandTimeout cannot be negative");
                return BadRequest();
            }

            try
            {
                List<Column>? columns = await buildingDataPostgreSQLConverter.GetColumnsByCategoriesAsync(categories, commandTimeout, cancellationToken);
                if (columns is null || columns.Count == 0)
                {
                    return NotFound();
                }

                List<DiGi.PostgreSQL.Table.Classes.Column>? columns_PostgreSQL = DiGi.PostgreSQL.Table.Convert.ToDiGi(columns);

                string? json = Core.Convert.ToSystem_String(columns_PostgreSQL);
                if (string.IsNullOrWhiteSpace(json))
                {
                    return NotFound();
                }

                return Content(json, "application/json");
            }
            catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                throw;
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "{Type}:{Name} failed", nameof(BuildingDataController), nameof(GetColumnsByCategoriesAsync));
                return StatusCode(500, "Internal server error during database query");
            }
        }

        /// <summary>
        /// Retrieves all columns with given categories by columns by categories parameter (which contains categories).
        /// </summary>
        /// <param name="columnsByCategoriesParameter"> The parameter containing the categories for querying columns. </param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
        /// <returns>Column <see cref="DiGi.PostgreSQL.Table.Classes.Column"/></returns>
        [HttpPost("columnsbycategoriesparameter", Name = $"{nameof(BuildingDataController)}_{nameof(GetColumnsByCategoriesParameterAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(List<DiGi.PostgreSQL.Table.Classes.Column>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetColumnsByCategoriesParameterAsync([FromBody] ColumnsByCategoriesParameter columnsByCategoriesParameter, [FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(BuildingDataController), nameof(GetColumnsByCategoriesParameterAsync));

            if (commandTimeout < 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "CommandTimeout cannot be negative");
                return BadRequest();
            }

            try
            {
                List<Column>? columns = await buildingDataPostgreSQLConverter.GetColumnsByCategoriesAsync(columnsByCategoriesParameter.Categories, commandTimeout, cancellationToken);
                if (columns is null || columns.Count == 0)
                {
                    return NotFound();
                }

                List<DiGi.PostgreSQL.Table.Classes.Column>? columns_PostgreSQL = DiGi.PostgreSQL.Table.Convert.ToDiGi(columns);

                string? json = Core.Convert.ToSystem_String(columns_PostgreSQL);
                if (string.IsNullOrWhiteSpace(json))
                {
                    return NotFound();
                }

                return Content(json, "application/json");
            }
            catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                throw;
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "{Type}:{Name} failed", nameof(BuildingDataController), nameof(GetColumnsByCategoriesParameterAsync));
                return StatusCode(500, "Internal server error during database query");
            }
        }

        /// <summary>
        /// Retrieves the unique identifiers for columns, optionally filtered by the specified categories.
        /// </summary>
        /// <param name="categories">An optional list of category names used to filter the column references.</param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        [HttpPost("columnuniqueids", Name = $"{nameof(BuildingDataController)}_{nameof(GetColumnUniqueIdsAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetColumnUniqueIdsAsync([FromBody] List<string>? categories = null, [FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(BuildingDataController), nameof(GetColumnUniqueIdsAsync));

            if (commandTimeout < 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "CommandTimeout cannot be negative");
                return BadRequest();
            }

            try
            {
                List<DiGi.PostgreSQL.Table.Classes.ColumnReference>? columnReferences = await buildingDataPostgreSQLConverter.GetColumnReferencesByCategoriesAsync(categories, commandTimeout, cancellationToken);
                if (columnReferences is null || columnReferences.Count == 0)
                {
                    return NotFound();
                }

                List<string> columnUniqueIds = [];
                foreach (DiGi.PostgreSQL.Table.Classes.ColumnReference columnReference in columnReferences)
                {
                    if (columnReference.UniqueId is string columnUniqueId && !string.IsNullOrWhiteSpace(columnUniqueId))
                    {
                        columnUniqueIds.Add(columnUniqueId);
                    }
                }

                JsonArray jsonArray = [.. columnUniqueIds];

                string? json = jsonArray.ToJsonString();
                if (string.IsNullOrWhiteSpace(json))
                {
                    return NotFound();
                }

                return Content(json, "application/json");
            }
            catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                throw;
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "{Type}:{Name} failed", nameof(BuildingDataController), nameof(GetColumnUniqueIdsAsync));
                return StatusCode(500, "Internal server error during database query");
            }
        }

        /// <summary>
        /// Asynchronously retrieves the number of building data rows stored for one county.
        /// <para>The cheapest question that can be asked of the table, and the one that separates a county no run has reached from one a run reached and wrote nothing for.</para>
        /// </summary>
        /// <param name="countyId">The identifier of the county to count.</param>
        /// <param name="estimated">Reads the planner's row estimate instead of counting the rows. Far faster on a partition of millions and accurate to a few percent, but it reflects the last time the partition was analysed rather than this moment. An unanalysed partition returns 204 NoContent.</param>
        /// <param name="analyze">A boolean value indicating whether to perform an ANALYZE operation before reading the estimate to ensure statistics are current.</param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout. Defaults to 600 seconds.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
        /// <returns>An <see cref="IActionResult"/> carrying the count, 204 NoContent when the partition exists but is unanalysed, or 404 NotFound when the county has no partition.</returns>
        [HttpGet("countbycountyid", Name = $"{nameof(BuildingDataController)}_{nameof(GetCountByCountyIdAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(long), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCountByCountyIdAsync([FromQuery(Name = "countyid")] int countyId, [FromQuery(Name = "estimated")] bool estimated = false, [FromQuery(Name = "analyze")] bool analyze = false, [FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started for county {CountyId}", nameof(BuildingDataController), nameof(GetCountByCountyIdAsync), countyId);

            if (commandTimeout < 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "CommandTimeout cannot be negative");
                return BadRequest();
            }

            long? count;
            try
            {
                count = estimated
                    ? await buildingDataPostgreSQLConverter.GetEstimatedCountAsync(countyId, analyze, commandTimeout, cancellationToken)
                    : await buildingDataPostgreSQLConverter.GetCountAsync(countyId, commandTimeout, cancellationToken);
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
                Serilog.Modify.Log("County {CountyId} has no building data partition", countyId);
                return NotFound();
            }

            if (estimated && count < 0)
            {
                Serilog.Modify.Log("County {CountyId} building data partition exists but has not been analysed", countyId);
                return NoContent();
            }

            return Content(count.Value.ToString(), "application/json");
        }

        /// <summary>
        /// Asynchronously retrieves the counties whose building data holds a row for one reference.
        /// <para>A reference addresses one building of one county, so more than one identifier coming back means the reference was written outside the county it belongs to.</para>
        /// </summary>
        /// <param name="reference">The building reference to look up.</param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout. Defaults to 600 seconds.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
        /// <returns>An <see cref="IActionResult"/> carrying the county identifiers in ascending order, or 404 when the reference is not stored.</returns>
        [HttpGet("countyidsbyreference", Name = $"{nameof(BuildingDataController)}_{nameof(GetCountyIdsByReferenceAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(List<int>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCountyIdsByReferenceAsync([FromQuery(Name = "reference")] string reference, [FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started for reference {Reference}", nameof(BuildingDataController), nameof(GetCountyIdsByReferenceAsync), reference ?? string.Empty);

            if (string.IsNullOrWhiteSpace(reference))
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Reference cannot be null");
                return BadRequest();
            }

            if (commandTimeout < 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "CommandTimeout cannot be negative");
                return BadRequest();
            }

            List<int>? countyIds;
            try
            {
                countyIds = await buildingDataPostgreSQLConverter.GetCountyIdsByReferenceAsync(reference, commandTimeout, cancellationToken);
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

            if (countyIds is null || countyIds.Count == 0)
            {
                return NotFound();
            }

            JsonArray jsonArray = [.. countyIds];

            return Content(jsonArray.ToJsonString(), "application/json");
        }

        /// <summary>
        /// Asynchronously measures what one county's building data holds against the buildings that county actually has.
        /// <para>What a row count cannot answer: how much was left out, and how much of that no run could have reached. A shortfall larger than the unresolved subdivision count is a run that did not finish what it could have.</para>
        /// <para>Reads both databases - the buildings from the main one and their data from the storage one - so it costs more than a count. Call it per county rather than in a sweep.</para>
        /// </summary>
        /// <param name="countyId">The identifier of the county to measure.</param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout. Defaults to 600 seconds.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
        /// <returns>An <see cref="IActionResult"/> carrying the <see cref="BuildingDataCoverageResult"/>, or 404 when either side could not be read.</returns>
        [HttpGet("coveragebycountyid", Name = $"{nameof(BuildingDataController)}_{nameof(GetCoverageByCountyIdAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(BuildingDataCoverageResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCoverageByCountyIdAsync([FromQuery(Name = "countyid")] int countyId, [FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started for county {CountyId}", nameof(BuildingDataController), nameof(GetCoverageByCountyIdAsync), countyId);

            if (commandTimeout < 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "CommandTimeout cannot be negative");
                return BadRequest();
            }

            BuildingDataCoverageResult? buildingDataCoverageResult;
            try
            {
                buildingDataCoverageResult = await buildingDataPostgreSQLConverter.BuildingDataCoverageResultAsync(building2DPostgreSQLConverter, countyId, commandTimeout, cancellationToken);
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

            if (buildingDataCoverageResult is null)
            {
                return NotFound();
            }

            string? json = Core.Convert.ToSystem_String(buildingDataCoverageResult);
            if (string.IsNullOrWhiteSpace(json))
            {
                return NotFound();
            }

            return Content(json, "application/json");
        }

        /// <summary>
        /// Asynchronously retrieves the references the building data holds under more than one county, ordered by collision count descending.
        /// <para>Expected to come back empty. A reference addresses one building of one county, so anything listed here was written outside the county it belongs to and nothing removes it afterwards.</para>
        /// </summary>
        /// <param name="limit">The maximum number of references to return. Defaults to 100.</param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout. Defaults to 600 seconds.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
        /// <returns>An <see cref="IActionResult"/> carrying the duplicated references, or 404 when there are none.</returns>
        [HttpGet("duplicatereferences", Name = $"{nameof(BuildingDataController)}_{nameof(GetDuplicateReferencesAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(List<Building2DReferenceDuplicate>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetDuplicateReferencesAsync([FromQuery(Name = "limit")] int limit = 100, [FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(BuildingDataController), nameof(GetDuplicateReferencesAsync));

            if (limit <= 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Limit has to be greater than zero");
                return BadRequest();
            }

            if (commandTimeout < 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "CommandTimeout cannot be negative");
                return BadRequest();
            }

            List<Building2DReferenceDuplicate>? building2DReferenceDuplicates;
            try
            {
                building2DReferenceDuplicates = await buildingDataPostgreSQLConverter.GetDuplicateReferencesAsync(limit, commandTimeout, cancellationToken);
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

            if (building2DReferenceDuplicates is null || building2DReferenceDuplicates.Count == 0)
            {
                return NotFound();
            }

            string? json = Core.Convert.ToSystem_String(building2DReferenceDuplicates);
            if (string.IsNullOrWhiteSpace(json))
            {
                return NotFound();
            }

            return Content(json, "application/json");
        }

        /// <summary>
        /// Generates a value range distribution histogram for a specific building data column inside a county partition, applying optional dynamic filters.
        /// </summary>
        /// <param name="histogramRequestParameter">The parameter containing the target column, county identifier, desired bucket count, and optional dynamic filters.</param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
        /// <returns>A task representing the asynchronous operation, returning the histogram bucket list as a JSON array.</returns>
        [HttpPost("histogramsummary", Name = $"{nameof(BuildingDataController)}_{nameof(GetHistogramSummaryAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(JsonArray), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetHistogramSummaryAsync([FromBody] HistogramRequestParameter histogramRequestParameter, [FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(BuildingDataController), nameof(GetHistogramSummaryAsync));

            if (commandTimeout < 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "CommandTimeout cannot be negative");
                return BadRequest();
            }

            try
            {
                JsonArray? histogramArray = await buildingDataPostgreSQLConverter.GetHistogramSummaryAsync(histogramRequestParameter.ColumnUniqueId, histogramRequestParameter.BucketCount, histogramRequestParameter.CountyId, histogramRequestParameter.FilterGroup, commandTimeout, cancellationToken);

                if (histogramArray is null)
                {
                    return NotFound();
                }

                string json = histogramArray.ToJsonString();
                return Content(json, "application/json");
            }
            catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                throw;
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "{Type}:{Name} failed", nameof(BuildingDataController), nameof(GetHistogramSummaryAsync));
                return StatusCode(500, "Internal server error during database query");
            }
        }

        /// <summary>
        /// Computes multi-value statistical summaries (SplitDistinctCount, SplitValueDistribution) on a partition column.
        /// </summary>
        /// <param name="multivalueAggregateRequestParameter">The parameter containing target column, multi-value aggregate function, county identifier, and optional separator.</param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
        /// <returns>A task representing the asynchronous operation, returning the aggregate result as a JSON node.</returns>
        [HttpPost("aggregatesummary/multivalue", Name = $"{nameof(BuildingDataController)}_{nameof(GetMultivalueAggregateSummaryAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(JsonNode), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetMultivalueAggregateSummaryAsync([FromBody] MultivalueAggregateRequestParameter multivalueAggregateRequestParameter, [FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(BuildingDataController), nameof(GetMultivalueAggregateSummaryAsync));

            if (commandTimeout < 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "CommandTimeout cannot be negative");
                return BadRequest();
            }

            try
            {
                JsonNode? resultNode = await buildingDataPostgreSQLConverter.GetAggregateSummaryAsync(multivalueAggregateRequestParameter.ColumnUniqueId, multivalueAggregateRequestParameter.MultivalueAggregateFunction, multivalueAggregateRequestParameter.CountyId, multivalueAggregateRequestParameter.Separator, multivalueAggregateRequestParameter.FilterGroup, commandTimeout, cancellationToken);

                if (resultNode is null)
                {
                    return NotFound();
                }

                string json = resultNode.ToJsonString();
                return Content(json, "application/json");
            }
            catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                throw;
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "{Type}:{Name} failed", nameof(BuildingDataController), nameof(GetMultivalueAggregateSummaryAsync));
                return StatusCode(500, "Internal server error during database query");
            }
        }

        /// <summary>
        /// Computes single-value statistical summaries (Avg, Sum, Min, Max, Count, DistinctCount) on a partition column.
        /// </summary>
        /// <param name="singlevalueAggregateRequestParameter">The parameter containing target column, single-value aggregate function, and county identifier.</param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
        /// <returns>A task representing the asynchronous operation, returning the aggregate result as a JSON node.</returns>
        [HttpPost("aggregatesummary/singlevalue", Name = $"{nameof(BuildingDataController)}_{nameof(GetSinglevalueAggregateSummaryAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(JsonNode), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetSinglevalueAggregateSummaryAsync([FromBody] SinglevalueAggregateRequestParameter singlevalueAggregateRequestParameter, [FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(BuildingDataController), nameof(GetSinglevalueAggregateSummaryAsync));

            if (commandTimeout < 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "CommandTimeout cannot be negative");
                return BadRequest();
            }

            try
            {
                JsonNode? resultNode = await buildingDataPostgreSQLConverter.GetAggregateSummaryAsync(singlevalueAggregateRequestParameter.ColumnUniqueId, singlevalueAggregateRequestParameter.SinglevalueAggregateFunction, singlevalueAggregateRequestParameter.CountyId, singlevalueAggregateRequestParameter.FilterGroup, commandTimeout, cancellationToken);

                if (resultNode is null)
                {
                    return NotFound();
                }

                string json = resultNode.ToJsonString();
                return Content(json, "application/json");
            }
            catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                throw;
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "{Type}:{Name} failed", nameof(BuildingDataController), nameof(GetSinglevalueAggregateSummaryAsync));
                return StatusCode(500, "Internal server error during database query");
            }
        }

        /// <summary>
        /// Retrieves a building data table using keyset-based paginated cursor streaming.
        /// </summary>
        /// <param name="buildingDataByPagingParameter">The parameter containing paging options, including column projections, county identifier, cursor, and page size.</param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
        /// <returns>A task representing the asynchronous operation, returning the populated table.</returns>
        [HttpPost("tablebybuildingdatabypagingparameter", Name = $"{nameof(BuildingDataController)}_{nameof(GetTableByBuildingDataByPagingParameterAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(DiGi.PostgreSQL.Table.Classes.Table), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTableByBuildingDataByPagingParameterAsync([FromBody] BuildingDataByPagingParameter buildingDataByPagingParameter, [FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(BuildingDataController), nameof(GetTableByBuildingDataByPagingParameterAsync));

            if (commandTimeout < 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "CommandTimeout cannot be negative");
                return BadRequest();
            }

            try
            {
                IEnumerable<string>? columnUniqueIds = buildingDataByPagingParameter.ColumnUniqueIds;
                if (columnUniqueIds is not null && !columnUniqueIds.Any())
                {
                    columnUniqueIds = null;
                }

                Table? table = await buildingDataPostgreSQLConverter.PullAsync(
                    buildingDataByPagingParameter.CountyId,
                    columnUniqueIds,
                    buildingDataByPagingParameter.Cursor,
                    buildingDataByPagingParameter.PageSize,
                    commandTimeout,
                    cancellationToken);

                if (table is null)
                {
                    return NotFound();
                }

                string? json = Core.IO.Table.Convert.ToSystem_String<Table, Column, Row>(table);
                if (string.IsNullOrWhiteSpace(json))
                {
                    return NotFound();
                }

                return Content(json, "application/json");
            }
            catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                throw;
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "{Type}:{Name} failed", nameof(BuildingDataController), nameof(GetTableByBuildingDataByPagingParameterAsync));
                return StatusCode(500, "Internal server error during database query");
            }
        }

        /// <summary> Retrieves a building data table by building data by references parameter (column unique ids, county id and references).</summary>
        /// <param name="buildingDataByReferencesParameter">The parameter containing references for querying building data, including column unique identifiers, county identifier, and specific references.</param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
        /// <returns>An <see cref="IActionResult" /> representing the result of the operation, typically containing a <see cref="DiGi.PostgreSQL.Table.Classes.Table" /> if found.</returns>
        [HttpPost("tablebybuildingdatabyreferencesparameter", Name = $"{nameof(BuildingDataController)}_{nameof(GetTableByBuildingDataByReferencesParameterAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(DiGi.PostgreSQL.Table.Classes.Table), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTableByBuildingDataByReferencesParameterAsync([FromBody] BuildingDataByReferencesParameter buildingDataByReferencesParameter, [FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(BuildingDataController), nameof(GetTableByBuildingDataByReferencesParameterAsync));

            if (commandTimeout < 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "CommandTimeout cannot be negative");
                return BadRequest();
            }

            try
            {
                IEnumerable<string>? references = buildingDataByReferencesParameter.References;
                if (references is null || !references.Any())
                {
                    Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "At least one reference has to be provided");
                    return BadRequest();
                }

                if (references.Count() > referenceCount_Maximum)
                {
                    Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "At most {Maximum} references can be asked for in one request", referenceCount_Maximum);
                    return BadRequest();
                }


                IEnumerable<string>? columnUniqueIds = buildingDataByReferencesParameter.ColumnUniqueIds;
                if (columnUniqueIds is not null && !columnUniqueIds.Any())
                {
                    columnUniqueIds = null;
                    Serilog.Modify.Log("No column Ids have been provided");
                }

                Table? table = await buildingDataPostgreSQLConverter.PullAsync(buildingDataByReferencesParameter.References, buildingDataByReferencesParameter.CountyId, columnUniqueIds, commandTimeout: commandTimeout, cancellationToken: cancellationToken);
                if (table is null)
                {
                    Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Table could not be extracted from Converter");
                    return NotFound();
                }

                string? json = Core.IO.Table.Convert.ToSystem_String<Table, Column, Row>(table);
                if (string.IsNullOrWhiteSpace(json))
                {
                    Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Table could not be converted to json");
                    return NotFound();
                }

                return Content(json, "application/json");
            }
            catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                throw;
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "{Type}:{Name} failed", nameof(BuildingDataController), nameof(GetTableByBuildingDataByReferencesParameterAsync));
                return StatusCode(500, "Internal server error during database query");
            }
        }

        /// <summary> Retrieves a building data table by building data by subdivision ids parameter (column unique ids, subdivision ids). </summary>
        /// <param name="buildingDataBySubdivisionIdsParameter">The parameter containing the subdivision IDs and optional column unique identifiers for querying building data.</param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        [HttpPost("tablebybuildingdatabysubdivisionidsparameter", Name = $"{nameof(BuildingDataController)}_{nameof(GetTableByBuildingDataBySubdivisionIdsParameterAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(DiGi.PostgreSQL.Table.Classes.Table), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTableByBuildingDataBySubdivisionIdsParameterAsync([FromBody] BuildingDataBySubdivisionIdsParameter buildingDataBySubdivisionIdsParameter, [FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(BuildingDataController), nameof(GetTableByBuildingDataBySubdivisionIdsParameterAsync));

            if (commandTimeout < 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "CommandTimeout cannot be negative");
                return BadRequest();
            }

            try
            {
                IEnumerable<string>? columnUniqueIds = buildingDataBySubdivisionIdsParameter.ColumnUniqueIds;
                if (columnUniqueIds is not null && !columnUniqueIds.Any())
                {
                    columnUniqueIds = null;
                }

                Table? table = await buildingDataPostgreSQLConverter.PullAsync(IO.Constants.Column.SubdivisionId.UniqueId()!, buildingDataBySubdivisionIdsParameter.SubdivisionIds, columnUniqueIds, commandTimeout, cancellationToken);
                if (table is null)
                {
                    return NotFound();
                }

                string? json = Core.IO.Table.Convert.ToSystem_String<Table, Column, Row>(table);
                if (string.IsNullOrWhiteSpace(json))
                {
                    return NotFound();
                }

                return Content(json, "application/json");
            }
            catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                throw;
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "{Type}:{Name} failed", nameof(BuildingDataController), nameof(GetTableByBuildingDataBySubdivisionIdsParameterAsync));
                return StatusCode(500, "Internal server error during database query");
            }
        }

        /// <summary>
        /// Retrieves a building data table filtered by the specified dynamic hierarchical filters.
        /// </summary>
        /// <param name="buildingDataByFilterGroupParameter">The parameter containing the dynamic filter group and optional column unique identifiers.</param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
        /// <returns>A task representing the asynchronous operation, returning the populated filtered table.</returns>
        [HttpPost("tablebyfiltergroup", Name = $"{nameof(BuildingDataController)}_{nameof(GetTableByFilterGroupAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(DiGi.PostgreSQL.Table.Classes.Table), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTableByFilterGroupAsync([FromBody] BuildingDataByFilterGroupParameter buildingDataByFilterGroupParameter, [FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(BuildingDataController), nameof(GetTableByFilterGroupAsync));

            if (commandTimeout < 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "CommandTimeout cannot be negative");
                return BadRequest();
            }

            try
            {
                List<string>? strings_ColumnUniqueIds = buildingDataByFilterGroupParameter.ColumnUniqueIds;
                if (strings_ColumnUniqueIds is not null && strings_ColumnUniqueIds.Count == 0)
                {
                    strings_ColumnUniqueIds = null;
                }

                List<Column>? columns = await buildingDataPostgreSQLConverter.GetColumnsByUniqueIdsAsync(strings_ColumnUniqueIds, commandTimeout, cancellationToken);
                if (columns is null || columns.Count == 0)
                {
                    return NotFound();
                }

                Table table_Result = new Table(columns);

                bool isSuccess = await buildingDataPostgreSQLConverter.PullAsync(table_Result, buildingDataByFilterGroupParameter.FilterGroup, commandTimeout: commandTimeout, cancellationToken: cancellationToken);
                if (!isSuccess)
                {
                    return NotFound();
                }

                string? string_Json = Core.IO.Table.Convert.ToSystem_String<Table, Column, Row>(table_Result);
                if (string.IsNullOrWhiteSpace(string_Json))
                {
                    return NotFound();
                }

                return Content(string_Json, "application/json");
            }
            catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                throw;
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "{Type}:{Name} failed", nameof(BuildingDataController), nameof(GetTableByFilterGroupAsync));
                return StatusCode(500, "Internal server error during database query");
            }
        }

        /// <summary>
        /// Retrieves a building data table for one specific building.
        /// </summary>
        /// <param name="reference">Building reference</param>
        /// <param name="countyId">The unique identifier of the county for which building belongs to.</param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
        /// <returns>A task representing the asynchronous operation, returning the populated filtered table with data for sigle building.</returns>
        [HttpGet("tablebyreference", Name = $"{nameof(BuildingDataController)}_{nameof(GetTableByReferenceAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(DiGi.PostgreSQL.Table.Classes.Table), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetTableByReferenceAsync([FromQuery(Name = "reference")] string reference, [FromQuery(Name = "countyid")] int? countyId = null, [FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(BuildingDataController), nameof(GetTableByReferenceAsync));

            if (commandTimeout < 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "CommandTimeout cannot be negative");
                return BadRequest();
            }

            try
            {
                Serilog.Modify.Log("Reference provided: {Reference}", reference ?? string.Empty);
                Serilog.Modify.Log("CountyId provided: {CountyId}", countyId?.ToString() ?? string.Empty);

                if (string.IsNullOrWhiteSpace(reference))
                {
                    Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Reference cannot be null");
                    return BadRequest();
                }

                BuildingDataByReferencesParameter buildingDataByReferencesParameter = new()
                {
                    References = [reference],
                    CountyId = countyId
                };

                return await GetTableByBuildingDataByReferencesParameterAsync(buildingDataByReferencesParameter, commandTimeout, cancellationToken);
            }
            catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                throw;
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "{Type}:{Name} failed", nameof(BuildingDataController), nameof(GetTableByReferenceAsync));
                return StatusCode(500, "Internal server error during database query");
            }
        }

        /// <summary> Retrieves unique values for a specified column unique identifier and an optional county identifier. </summary>
        /// <param name="columnUniqueId">The unique identifier of the column from which to retrieve unique values.</param>
        /// <param name="countyId">The optional integer identifier of the county used to filter the results.</param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        [HttpGet("uniquevalues", Name = $"{nameof(BuildingDataController)}_{nameof(GetUniqueValuesAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(List<object>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUniqueValuesAsync([FromQuery(Name = "columnuniqueid")] string columnUniqueId, [FromQuery(Name = "countyid")] int? countyId = null, [FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(BuildingDataController), nameof(GetUniqueValuesAsync));

            if (commandTimeout < 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "CommandTimeout cannot be negative");
                return BadRequest();
            }

            try
            {
                Serilog.Modify.Log("ColumnUniqueId provided: {ColumnUniqueId}", columnUniqueId ?? string.Empty);
                Serilog.Modify.Log("CountyId provided: {CountyId}", countyId?.ToString() ?? string.Empty);
                IEnumerable<object?>? values;
                if (countyId is null)
                {
                    values = await buildingDataPostgreSQLConverter.GetUniqueValuesAsync<object?>(columnUniqueId, commandTimeout: commandTimeout, cancellationToken: cancellationToken);
                }
                else
                {
                    values = await buildingDataPostgreSQLConverter.GetUniqueValuesAsync<object?>(columnUniqueId, countyId.Value, commandTimeout: commandTimeout, cancellationToken: cancellationToken);
                }

                if (values is null || !values.Any())
                {
                    return NotFound();
                }

                JsonArray jsonArray = [];
                foreach (object? value in values)
                {
                    jsonArray.Add(value);
                }

                string? json = jsonArray.ToJsonString();
                if (string.IsNullOrWhiteSpace(json))
                {
                    return NotFound();
                }

                return Content(json, "application/json");
            }
            catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                throw;
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "{Type}:{Name} failed", nameof(BuildingDataController), nameof(GetUniqueValuesAsync));
                return StatusCode(500, "Internal server error during database query");
            }
        }

        /// <summary> Retrieves unique values for a given <see cref="UniqueValuesByColumnUniqueIdParameter" /> (column unique id and optionally county id), applying optional dynamic filters. </summary>
        /// <param name="uniqueValuesByColumnUniqueIdParameter">The parameter containing the column unique identifier, optional county identifier, and optional dynamic filters.</param>
        /// <param name="commandTimeout">The timeout in seconds for the execution of the command. A value of 0 disables the timeout.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
        /// <returns>An <see cref="IActionResult" /> representing the result of the operation, typically a list of unique values or a not found status.</returns>
        [HttpPost("uniquevaluesbycolumnuniqueidparameter", Name = $"{nameof(BuildingDataController)}_{nameof(GetUniqueValuesByColumnUniqueIdParameterAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(List<object>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUniqueValuesByColumnUniqueIdParameterAsync([FromBody] UniqueValuesByColumnUniqueIdParameter uniqueValuesByColumnUniqueIdParameter, [FromQuery(Name = "commandtimeout")] int commandTimeout = 600, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(BuildingDataController), nameof(GetUniqueValuesByColumnUniqueIdParameterAsync));

            if (commandTimeout < 0)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "CommandTimeout cannot be negative");
                return BadRequest();
            }

            try
            {
                IEnumerable<object?>? values;
                if (uniqueValuesByColumnUniqueIdParameter.CountyId is null)
                {
                    values = await buildingDataPostgreSQLConverter.GetUniqueValuesAsync<object?>(
                        uniqueValuesByColumnUniqueIdParameter.ColumnUniqueId,
                        uniqueValuesByColumnUniqueIdParameter.FilterGroup,
                        commandTimeout,
                        cancellationToken);
                }
                else
                {
                    values = await buildingDataPostgreSQLConverter.GetUniqueValuesAsync<object?>(
                        uniqueValuesByColumnUniqueIdParameter.ColumnUniqueId,
                        uniqueValuesByColumnUniqueIdParameter.CountyId.Value,
                        uniqueValuesByColumnUniqueIdParameter.FilterGroup,
                        commandTimeout,
                        cancellationToken);
                }

                if (values is null || !values.Any())
                {
                    return NotFound();
                }

                JsonArray jsonArray = [];
                foreach (object? value in values)
                {
                    jsonArray.Add(value);
                }

                string? json = jsonArray.ToJsonString();
                if (string.IsNullOrWhiteSpace(json))
                {
                    return NotFound();
                }

                return Content(json, "application/json");
            }
            catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                throw;
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "{Type}:{Name} failed", nameof(BuildingDataController), nameof(GetUniqueValuesByColumnUniqueIdParameterAsync));
                return StatusCode(500, "Internal server error during database query");
            }
        }
    }
}