using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;

namespace DiGi.GIS.WebAPI.Classes
{
    /// <summary>
    /// Represents a parameter containing text for querying administrative area references.
    /// </summary>
    public class AdministrativeAreal2DReferencesByNameParameter : DiGi.WebAPI.Classes.Parameter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DReferencesByNameParameter"/> class.
        /// </summary>
        public AdministrativeAreal2DReferencesByNameParameter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DReferencesByNameParameter"/> class with the specified text.
        /// </summary>
        /// <param name="text">The text to search for.</param>
        public AdministrativeAreal2DReferencesByNameParameter(string text)
        {
            Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DReferencesByNameParameter"/> class using a <see cref="JsonObject"/> instance.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the parameter values.</param>
        public AdministrativeAreal2DReferencesByNameParameter(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the text to search for in the names of administrative areal 2D references.
        /// </summary>
        [Required]
        public string? Text { get; set; } = string.Empty;
    }
}
