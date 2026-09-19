using System.Text.Json.Nodes;

namespace DiGi.GIS.WebAPI.Classes.Parameter
{
    /// <summary>
    /// The body of the <c>setuseryearbuilt</c> write: one user-supplied year built entry for a single building.
    /// <para>Every member is bound nullable so an omitted field is representable and can be rejected explicitly - a non-nullable binding cannot tell an omitted value from a legitimate one, and <c>Relation</c> must be checked against the <c>YearBuiltRelation</c> members rather than compared to a sentinel.</para>
    /// </summary>
    public class UserYearBuiltParameter : DiGi.WebAPI.Classes.Parameter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserYearBuiltParameter"/> class.
        /// </summary>
        public UserYearBuiltParameter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserYearBuiltParameter"/> class using the provided JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize the parameter.</param>
        public UserYearBuiltParameter(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserYearBuiltParameter"/> class by copying the values from an existing instance.
        /// </summary>
        /// <param name="userYearBuiltParameter">The source instance from which to copy the values.</param>
        public UserYearBuiltParameter(UserYearBuiltParameter userYearBuiltParameter)
            : base(userYearBuiltParameter)
        {
            if (userYearBuiltParameter is not null)
            {
                CountyId = userYearBuiltParameter.CountyId;
                Reference = userYearBuiltParameter.Reference;
                Year = userYearBuiltParameter.Year;
                Relation = userYearBuiltParameter.Relation;
            }
        }

        /// <summary>
        /// Gets or sets the identifier of the county part the building is filed under. A hint passed to the converter, which resolves the part itself; <c>null</c> is rejected.
        /// </summary>
        public int? CountyId { get; set; }

        /// <summary>
        /// Gets or sets the reference of the building the entry belongs to; blank is rejected.
        /// </summary>
        public string? Reference { get; set; }

        /// <summary>
        /// Gets or sets the year built the user is asserting; <c>null</c> (an omitted selection) is rejected.
        /// </summary>
        public short? Year { get; set; }

        /// <summary>
        /// Gets or sets how the stored year relates to the true construction year, as a <see cref="DiGi.GIS.Enums.YearBuiltRelation"/> member. <c>null</c> means <c>Exact</c>; a value that is not a <see cref="DiGi.GIS.Enums.YearBuiltRelation"/> member is rejected.
        /// </summary>
        public int? Relation { get; set; }
    }
}