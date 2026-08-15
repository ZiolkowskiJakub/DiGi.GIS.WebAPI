using DiGi.GIS.WebAPI.Classes;
using System.Collections.Generic;
using System.Text;

namespace DiGi.GIS.WebAPI
{
    public static partial class Query
    {
        /// <summary>
        /// Renders the first rejections of a write as a readable log fragment.
        /// <para>A count alone does not say what to do about a shortfall - the references identify the rows to repost, and the reason says whether reposting them unchanged would achieve anything.</para>
        /// </summary>
        /// <param name="rejections">The rejections to render; may be null.</param>
        /// <param name="count">The maximum number of rejections to include. Defaults to 20.</param>
        /// <returns>A comma-separated list of <c>reference (reason)</c> entries, empty when there is nothing to render.</returns>
        public static string RejectionSample(this IEnumerable<UpdateItemsResult.Rejection>? rejections, int count = 20)
        {
            if (rejections is null || count <= 0)
            {
                return string.Empty;
            }

            StringBuilder stringBuilder = new();

            int index = 0;
            foreach (UpdateItemsResult.Rejection rejection in rejections)
            {
                if (rejection is null)
                {
                    continue;
                }

                if (index >= count)
                {
                    stringBuilder.Append(", ...");
                    break;
                }

                if (index != 0)
                {
                    stringBuilder.Append(", ");
                }

                stringBuilder.Append(string.IsNullOrWhiteSpace(rejection.Reference) ? "???" : rejection.Reference);
                stringBuilder.Append(" (");
                stringBuilder.Append(rejection.Reason);
                stringBuilder.Append(')');

                index++;
            }

            return stringBuilder.ToString();
        }
    }
}
