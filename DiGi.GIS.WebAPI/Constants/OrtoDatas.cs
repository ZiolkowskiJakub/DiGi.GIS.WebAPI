namespace DiGi.GIS.WebAPI.Constants
{
    /// <summary>
    /// Provides the limits applied to orthophoto queries served by the GIS PostgreSQL Web API.
    /// </summary>
    public static class OrtoDatas
    {
        /// <summary>
        /// The largest number of counties a summary or queue request may name at once.
        /// <para>Each county costs a grouped aggregate over one partition, which is cheap, but the request is unauthenticated and naming every county in the country in one call is not what these are for. Omitting the identifiers entirely is still allowed and answers every partition in a single grouped statement, which is one query rather than many.</para>
        /// </summary>
        public static readonly int MaximumSummaryCountyCount = 100;

        /// <summary>
        /// The largest number of references a subdivision comparison may name back per category.
        /// <para>The comparison itself walks a whole county, and the counts it returns are exact whatever this is set to. The samples exist to make a disagreement actionable without returning a hundred thousand strings, so the ceiling bounds the response rather than the work.</para>
        /// </summary>
        public static readonly int MaximumSampleCount = 1000;
    }
}
