using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;

namespace DiGi.GIS.WebAPI.Classes
{
    /// <summary>
    /// Parameter class containing options for paged building data queries, in reference (keyset) or physical order.
    /// </summary>
    public class BuildingDataByPagingParameter : DiGi.WebAPI.Classes.Parameter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingDataByPagingParameter"/> class.
        /// </summary>
        public BuildingDataByPagingParameter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingDataByPagingParameter"/> class using an <see cref="JsonObject"/> object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing data used to initialize the parameter.</param>
        public BuildingDataByPagingParameter(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the target partition identifier (County ID).
        /// </summary>
        /// <example>10365</example>
        [Required]
        public int CountyId { get; set; }

        /// <summary>
        /// Gets or sets the list of column unique identifiers to project in the result.
        /// </summary>
        /// <example>["building_id", "address"]</example>
        public List<string>? ColumnUniqueIds { get; set; }

        /// <summary>
        /// Gets or sets the maximum count of rows per page. Defaults to 250.
        /// <para>Capped because a building data row carries every derived column of a building, so a page is far heavier than its row count suggests. Ask for more pages rather than a bigger one.</para>
        /// </summary>
        /// <example>100</example>
        [DefaultValue(250)]
        [Range(1, 10000)]
        public int PageSize { get; set; } = 250;

        /// <summary>
        /// Gets or sets where the page continues from; null or omitted starts at the beginning of the county part.
        /// <para>In reference order it is the previous page's last <c>reference</c>, verbatim. In physical order it is the value of the previous response's <c>DiGi-Next-Cursor</c> header - an opaque heap position such as <c>(412,7)</c> - or, after a response that came back in reference order without the header, the last row's <c>reference</c>.</para>
        /// </summary>
        /// <example>30FA023C-190B-87D7-E053-CA2BA8C08B17</example>
        public string? Cursor { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the part is read in physical (heap) order rather than by <c>reference</c>. Defaults to false, the reference order this endpoint has always answered.
        /// <para>Physical order reads the part sequentially instead of one random heap read per row. Measured on production: 368-654 s for a cold 155 307-row part in reference order, against about 15 s per 100 000 rows read sequentially (DiGi.GIS.WebAPI.UI#29). Use it to read a whole part when row order does not matter. The next cursor then arrives in the <c>DiGi-Next-Cursor</c> response header, and the endpoint falls back to reference order where physical order is unavailable (see the action's remarks).</para>
        /// </summary>
        /// <example>true</example>
        [DefaultValue(false)]
        public bool PhysicalOrder { get; set; }
    }
}