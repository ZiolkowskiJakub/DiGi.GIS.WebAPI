using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.PointCloud.Core.Enums;
using DiGi.Geometry.PointCloud.Spatial;
using DiGi.Geometry.PointCloud.Spatial.Classes;
using DiGi.Geometry.Spatial.Classes;
using DiGi.GIS.PostgreSQL.Classes;
using DiGi.GIS.PostgreSQL.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.GIS.WebAPI.Classes
{
    /// <summary>
    /// Controller responsible for handling API requests related to terrain, reconstructing a ground surface mesh from the stored elevation points of the counties a request covers.
    /// <para>Every mesh returned here is a two-and-a-half dimensional height field: exactly one elevation per plan position. It models ground, and cannot express a vertical face, an overhang or a canopy.</para>
    /// </summary>
    [ApiController]
    [Route("gis/[controller]")]
    public class TerrainController : DiGi.WebAPI.Classes.WebAPIController
    {
        private readonly TerrainPointPostgreSQLConverter terrainPointPostgreSQLConverter;
        private readonly AdministrativeAreal2DPostgreSQLConverter administrativeAreal2DPostgreSQLConverter;

        /// <summary>
        /// Initializes a new instance of the <see cref="TerrainController"/> class.
        /// </summary>
        /// <param name="terrainPointPostgreSQLConverter">The converter used for reading terrain points from the PostgreSQL database.</param>
        /// <param name="administrativeAreal2DPostgreSQLConverter">The converter used for resolving which counties an area covers.</param>
        public TerrainController(TerrainPointPostgreSQLConverter terrainPointPostgreSQLConverter, AdministrativeAreal2DPostgreSQLConverter administrativeAreal2DPostgreSQLConverter)
        {
            this.terrainPointPostgreSQLConverter = terrainPointPostgreSQLConverter;
            this.administrativeAreal2DPostgreSQLConverter = administrativeAreal2DPostgreSQLConverter;
        }

        /// <summary>
        /// Asynchronously retrieves the terrain surface inside a circle centred on the given plan coordinate.
        /// <para>The circle is honoured: the points outside it are excluded by the database, not trimmed afterwards, so no part of the returned mesh lies further from the centre than the radius.</para>
        /// <para>Either <paramref name="radius"/> or <paramref name="diameter"/> must be supplied; <paramref name="radius"/> wins when both are. The radius is capped by <see cref="Constants.Terrain.MaximumRadius"/>.</para>
        /// </summary>
        /// <param name="x">The X coordinate of the centre, in PL-1992 (EPSG:2180) metres, matching the coordinates the terrain points are stored in.</param>
        /// <param name="y">The Y coordinate of the centre, in PL-1992 (EPSG:2180) metres, matching the coordinates the terrain points are stored in.</param>
        /// <param name="radius">The search radius in metres. Optional when <paramref name="diameter"/> is supplied.</param>
        /// <param name="diameter">The search diameter in metres, used only when <paramref name="radius"/> is absent.</param>
        /// <param name="tolerance">An optional tolerance for the spatial query, in metres. If not provided or NaN, a default macro distance is used.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by the caller to cancel the asynchronous operation.</param>
        /// <returns>An <see cref="IActionResult"/> carrying the <see cref="Mesh3D"/> as JSON, or an error status.</returns>
        [HttpGet("mesh3dbycircle", Name = $"{nameof(TerrainController)}_{nameof(GetMesh3DByCircleAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(Mesh3D), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetMesh3DByCircleAsync([FromQuery(Name = "x")] double x, [FromQuery(Name = "y")] double y, [FromQuery(Name = "radius")] double? radius, [FromQuery(Name = "diameter")] double? diameter, [FromQuery(Name = "tolerance")] double? tolerance, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(TerrainController), nameof(GetMesh3DByCircleAsync));
            Serilog.Modify.Log("Coordinates provided: X={X}, Y={Y}", x, y);

            if (!IsFinite(x) || !IsFinite(y))
            {
                return BadRequest();
            }

            double radius_Temp = double.NaN;
            if (radius.HasValue && !double.IsNaN(radius.Value))
            {
                radius_Temp = radius.Value;
            }
            else if (diameter.HasValue && !double.IsNaN(diameter.Value))
            {
                radius_Temp = diameter.Value / 2;
            }

            // A radius that is absent, negative, zero, not a number, infinite or beyond the cap all end
            // here as bad input. Left to reach the database the last four produce an empty result or a
            // national scan, and both used to be reported as nothing found.
            if (!IsFinite(radius_Temp) || radius_Temp <= 0 || radius_Temp > Constants.Terrain.MaximumRadius)
            {
                return BadRequest();
            }

            if (!TryGetTolerance(tolerance, out double tolerance_Temp))
            {
                return BadRequest();
            }

            Serilog.Modify.Log("Radius resolved: {Radius}, Tolerance: {Tolerance}", radius_Temp, tolerance_Temp);

            Circle2D circle2D = new(new Point2D(x, y), radius_Temp);

            BoundingBox2D? boundingBox2D = circle2D.GetBoundingBox();
            if (boundingBox2D is null)
            {
                return BadRequest();
            }

            PointCloud3D? pointCloud3D;
            try
            {
                HashSet<int>? countyIds = await CountyIdsAsync(boundingBox2D, tolerance_Temp, cancellationToken);
                if (countyIds is null)
                {
                    Serilog.Modify.Log("No county covers the requested area");
                    return NotFound();
                }

                pointCloud3D = await terrainPointPostgreSQLConverter.GetPointCloud3DByCircle2DAsync(circle2D, countyIds, tolerance_Temp, cancellationToken: cancellationToken);
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "Database could not be queried");
                return StatusCode(500, "Internal server error during database query");
            }

            return Mesh3DResult(pointCloud3D);
        }

        /// <summary>
        /// Asynchronously retrieves the terrain surface inside an axis aligned bounding box given by two opposite corners.
        /// <para>Corner order does not matter. Each side of the box is capped at twice <see cref="Constants.Terrain.MaximumRadius"/>, so this endpoint and the circle admit the same largest area.</para>
        /// </summary>
        /// <param name="x_1">The X coordinate of the first corner, in PL-1992 (EPSG:2180) metres.</param>
        /// <param name="y_1">The Y coordinate of the first corner, in PL-1992 (EPSG:2180) metres.</param>
        /// <param name="x_2">The X coordinate of the second corner, in PL-1992 (EPSG:2180) metres.</param>
        /// <param name="y_2">The Y coordinate of the second corner, in PL-1992 (EPSG:2180) metres.</param>
        /// <param name="tolerance">An optional tolerance for the spatial query, in metres. If not provided or NaN, a default macro distance is used.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by the caller to cancel the asynchronous operation.</param>
        /// <returns>An <see cref="IActionResult"/> carrying the <see cref="Mesh3D"/> as JSON, or an error status.</returns>
        [HttpGet("mesh3dbyboundingbox", Name = $"{nameof(TerrainController)}_{nameof(GetMesh3DByBoundingBoxAsync)}")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [ProducesResponseType(typeof(Mesh3D), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetMesh3DByBoundingBoxAsync([FromQuery(Name = "x_1")] double x_1, [FromQuery(Name = "y_1")] double y_1, [FromQuery(Name = "x_2")] double x_2, [FromQuery(Name = "y_2")] double y_2, [FromQuery(Name = "tolerance")] double? tolerance, CancellationToken cancellationToken = default)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(TerrainController), nameof(GetMesh3DByBoundingBoxAsync));
            Serilog.Modify.Log("BoundingBox provided: X_1={X_1}, Y_1={Y_1}, X_2={X_2}, Y_2={Y_2}", x_1, y_1, x_2, y_2);

            if (!IsFinite(x_1) || !IsFinite(y_1) || !IsFinite(x_2) || !IsFinite(y_2))
            {
                return BadRequest();
            }

            double extent_Maximum = 2 * Constants.Terrain.MaximumRadius;
            if (System.Math.Abs(x_2 - x_1) > extent_Maximum || System.Math.Abs(y_2 - y_1) > extent_Maximum)
            {
                return BadRequest();
            }

            if (!TryGetTolerance(tolerance, out double tolerance_Temp))
            {
                return BadRequest();
            }

            BoundingBox2D boundingBox2D = new(new Core.Classes.Range<double>(x_1, x_2), new Core.Classes.Range<double>(y_1, y_2));

            PointCloud3D? pointCloud3D;
            try
            {
                HashSet<int>? countyIds = await CountyIdsAsync(boundingBox2D, tolerance_Temp, cancellationToken);
                if (countyIds is null)
                {
                    Serilog.Modify.Log("No county covers the requested area");
                    return NotFound();
                }

                pointCloud3D = await terrainPointPostgreSQLConverter.GetPointCloud3DByBoundingBox2DAsync(boundingBox2D, countyIds, tolerance_Temp, cancellationToken: cancellationToken);
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "Database could not be queried");
                return StatusCode(500, "Internal server error during database query");
            }

            return Mesh3DResult(pointCloud3D);
        }

        /// <summary>
        /// Resolves which county partitions an area covers.
        /// <para>This has to happen here rather than inside the terrain converter. The terrain points live in the Storage database and the administrative geometry in Main, and a PostgreSQL connection cannot reach across databases - so the only place both are available is the host, where each converter carries its own connection. The write side has always worked this way; see <c>PostgreSQLTerrainPointCreateTableTask</c>.</para>
        /// </summary>
        /// <param name="boundingBox2D">The area to resolve.</param>
        /// <param name="tolerance">The distance the search area is expanded by, in metres.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by the caller to cancel the asynchronous operation.</param>
        /// <returns>The identifiers of the counties the area meets, or <see langword="null"/> when it meets none.</returns>
        private async Task<HashSet<int>?> CountyIdsAsync(BoundingBox2D boundingBox2D, double tolerance, CancellationToken cancellationToken)
        {
            List<AdministrativeAreal2D>? administrativeAreal2Ds = await administrativeAreal2DPostgreSQLConverter.GetAdministrativeAreal2DsByBoundingBox2DAsync(boundingBox2D, [AdministrativeArealType.County], tolerance, cancellationToken: cancellationToken);
            if (administrativeAreal2Ds is null || administrativeAreal2Ds.Count == 0)
            {
                return null;
            }

            // A county row's own county_id is null - its identity is its id - so there is no second
            // candidate to fall back on here. A county with disconnected territory is stored as one row
            // per part, and every part is a partition of its own, so they all belong in the result.
            HashSet<int> countyIds = [];
            foreach (AdministrativeAreal2D administrativeAreal2D in administrativeAreal2Ds)
            {
                countyIds.Add(administrativeAreal2D.Id);
            }

            return countyIds;
        }

        /// <summary>
        /// Reconstructs the ground surface from the gathered terrain points and renders it as the JSON response body.
        /// <para>The three failure paths are reported separately, because "nothing stored here" and "too little stored here to triangulate" are answered by different fixes and both used to arrive as a bare 404.</para>
        /// </summary>
        /// <param name="pointCloud3D">The terrain points gathered for the requested area.</param>
        /// <returns>An <see cref="IActionResult"/> carrying the <see cref="Mesh3D"/> as JSON, or a not found status.</returns>
        private IActionResult Mesh3DResult(PointCloud3D? pointCloud3D)
        {
            if (pointCloud3D is null || pointCloud3D.Count == 0)
            {
                Serilog.Modify.Log("No TerrainPoints stored for the requested area");
                return NotFound();
            }

            // A decimation grid finer than the source spacing walks every point and removes none, and the
            // stored lattice is already regular at 10 m or coarser, so there is nothing to decimate.
            // Lowest rather than Highest because this is bare ground, not a surface model of canopy and
            // roofs. The edge limit is what stops Delaunay bridging county edges and no-data gaps with a
            // skirt of long thin triangles spanning the convex hull.
            HeightFieldPointCloud3DMeshSolver heightFieldPointCloud3DMeshSolver = new(0, Constants.Terrain.MaximumEdgeLength, PointCloudHeightSelection.Lowest);

            Mesh3D? mesh3D = pointCloud3D.Mesh3D(heightFieldPointCloud3DMeshSolver);
            if (mesh3D is null)
            {
                Serilog.Modify.Log("TerrainPoints found ({Count}) but none could be triangulated. A triangulation needs three points, so a radius below the lattice spacing lands here", pointCloud3D.Count);
                return NotFound();
            }

            string? json = Core.Convert.ToSystem_String(mesh3D);
            if (string.IsNullOrWhiteSpace(json))
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Mesh3D could not be serialized");
                return NotFound();
            }

            return Content(json, "application/json");
        }

        /// <summary>
        /// Resolves the tolerance a request asked for, falling back to the default when it was not supplied.
        /// </summary>
        /// <param name="tolerance">The tolerance as bound from the query string.</param>
        /// <param name="tolerance_Temp">The resolved tolerance, in metres.</param>
        /// <returns><see langword="true"/> when the tolerance is usable; otherwise <see langword="false"/>.</returns>
        private static bool TryGetTolerance(double? tolerance, out double tolerance_Temp)
        {
            tolerance_Temp = Core.Constants.Tolerance.MacroDistance;
            if (tolerance.HasValue && !double.IsNaN(tolerance.Value))
            {
                tolerance_Temp = tolerance.Value;
            }

            return IsFinite(tolerance_Temp) && tolerance_Temp >= 0;
        }

        /// <summary>
        /// Determines whether a bound query string value is a usable coordinate or distance.
        /// <para>Model binding accepts the literals NaN and Infinity for a double, so neither is a value the caller could only have reached by mistake.</para>
        /// </summary>
        /// <param name="value">The value to test.</param>
        /// <returns><see langword="true"/> when the value is neither NaN nor infinite; otherwise <see langword="false"/>.</returns>
        private static bool IsFinite(double value)
        {
            return !double.IsNaN(value) && !double.IsInfinity(value);
        }
    }
}
