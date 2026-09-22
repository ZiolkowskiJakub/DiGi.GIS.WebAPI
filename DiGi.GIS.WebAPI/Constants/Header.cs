namespace DiGi.GIS.WebAPI.Constants
{
    /// <summary>
    /// Provides the names of the HTTP headers the GIS Web API sets on its responses.
    /// </summary>
    public static class Header
    {
        /// <summary>
        /// The response header carrying the cursor of the next page of a physical-order building data read. Absent when the county part is exhausted, and absent when the endpoint answered in reference order instead.
        /// </summary>
        public const string NextCursor = "DiGi-Next-Cursor";
    }
}
