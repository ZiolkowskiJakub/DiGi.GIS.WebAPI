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
    }
}
