using System.Collections.Generic;

namespace DiGi.GIS.WebAPI.Classes
{
    /// <summary>
    /// The outcome of a write endpoint: how much was stored, and which rows were not.
    /// <para>A partial write still answers 200 - the rows that resolved really were stored, and failing the whole batch would discard them - but it is no longer silent. <see cref="Rejected"/> names what did not reach the database so the caller can correct and repost it, or report it onwards.</para>
    /// </summary>
    public partial class UpdateItemsResult
    {
        /// <summary>
        /// Gets or sets the number of rows handed to the database.
        /// </summary>
        /// <example>5000</example>
        public int Sent { get; set; }

        /// <summary>
        /// Gets or sets the number of distinct identifiers the database returned.
        /// <para>Not a row count. Identifiers arrive as a set, and rows of one batch colliding on the conflict key return the same identifier, so this can be lower than the number stored. <see cref="Rejected"/> is the exact account of what was lost.</para>
        /// </summary>
        /// <example>4987</example>
        public int Updated { get; set; }

        /// <summary>
        /// Gets or sets the rows dropped before the database, each named with the reason it was dropped.
        /// </summary>
        public List<Rejection> Rejected { get; set; } = [];
    }
}
