namespace DiGi.GIS.WebAPI.Classes
{
    public partial class UpdateItemsResult
    {
        /// <summary>
        /// One row that was dropped before the database, and why.
        /// </summary>
        public class Rejection
        {
            /// <summary>
            /// Gets or sets the reference of the dropped row. Null when the row carried none.
            /// <para>The host omits null properties, so a rejection with nothing to name arrives as <c>{"reason":"Undefined"}</c> - an absent <c>reference</c> is the null, not a serialization fault.</para>
            /// </summary>
            /// <example>1234.5678.AB_12</example>
            public string? Reference { get; set; }

            /// <summary>
            /// Gets or sets the reason the row was dropped. It decides whether reposting is worth anything: a payload defect is worth correcting, a footprint outside every candidate county part is not.
            /// </summary>
            /// <example>CountyUnresolved</example>
            public PostgreSQL.Enums.UpdateRejectionReason Reason { get; set; }
        }
    }
}
