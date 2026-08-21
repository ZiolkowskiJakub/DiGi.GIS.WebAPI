namespace DiGi.GIS.WebAPI.Constants
{
    /// <summary>
    /// Provides the limits applied to terrain queries served by the GIS PostgreSQL Web API.
    /// </summary>
    public static class Terrain
    {
        /// <summary>
        /// The largest search radius, in model units, a terrain request may ask for.
        /// <para>The terrain endpoints are unauthenticated reads with no natural ceiling of their own: the radius alone decides how many stored points are gathered, triangulated and serialised, and the store is partitioned by county rather than capped by extent. Without this a single request can ask for the whole country.</para>
        /// <para>The cap is a half-extent, so the largest search area is 4 km by 4 km. Counties are sampled onto a lattice between 10 m and 100 m, which puts the worst case at roughly 160 000 points. Raising this is safe only if the finest lattice is never queried at the new size - at 5 000 m the same lattice yields about a million points.</para>
        /// </summary>
        public static readonly double MaximumRadius = 2000;

        /// <summary>
        /// The longest edge, in model units, a terrain mesh triangle may have.
        /// <para>A Delaunay triangulation covers the convex hull of its sites, so without a limit the mesh bridges county edges, no-data gaps and concave outlines with a skirt of long thin triangles that look like terrain and are not.</para>
        /// <para>The value has to clear the diagonal of the coarsest lattice cell or it would shred genuine data: a regular 100 m lattice needs edges of 141.4 m. The cost of clearing it is that on a 10 m lattice a real gap of up to this width is still bridged.</para>
        /// </summary>
        public static readonly double MaximumEdgeLength = 150;

        /// <summary>
        /// The finest lattice, in model units, a coverage or gap request may be measured against.
        /// <para>The work of those endpoints rises with the square of how fine the lattice is: they generate every node of a county and decide each one against its outlines. A county of 1 000 square kilometres is 100 000 nodes at 100 m and 10 million at 10 m, and below that the request stops being a diagnostic and becomes a denial of service that anyone can send.</para>
        /// </summary>
        public static readonly double MinimumGridSize = 10;

        /// <summary>
        /// The largest number of lattice nodes a single coverage or gap request may generate.
        /// <para>Checked against the requested area before any node is built, so an area and a lattice that would together exceed it are refused rather than started. This is the cap that holds when a large county meets a fine lattice, both of which are individually allowed.</para>
        /// </summary>
        public static readonly long MaximumNodeCount = 5000000;

        /// <summary>
        /// The longest side, in model units, a gap request may ask for.
        /// <para>Larger than the mesh endpoints admit, because a gap request returns coordinates rather than a triangulated surface and is meant for looking over a region at once. It is still bounded by <see cref="MaximumNodeCount"/> at any given lattice.</para>
        /// </summary>
        public static readonly double MaximumGapExtent = 50000;

        /// <summary>
        /// The largest number of counties a single density request may name.
        /// <para>A density costs the reading of every subdivision outline of the county it is asked for, so this is what keeps one request from pulling the administrative geometry of the whole country. Sweeping every county means several requests, which is also what makes the sweep interruptible.</para>
        /// </summary>
        public static readonly int MaximumDensityCountyCount = 50;
    }
}
