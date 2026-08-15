using DiGi.GIS.WebAPI.Classes;

namespace DiGi.GIS.WebAPI
{
    public static partial class Create
    {
        /// <summary>
        /// Creates the response payload of a write endpoint from what the database converter reported.
        /// </summary>
        /// <param name="postgreSQLUpdateResult">The outcome returned by the converter's update.</param>
        /// <param name="sent">The number of rows handed to the converter.</param>
        /// <returns>A new <see cref="Classes.UpdateItemsResult"/>, or null if <paramref name="postgreSQLUpdateResult"/> is null.</returns>
        public static UpdateItemsResult? UpdateItemsResult(this PostgreSQL.Classes.PostgreSQLUpdateResult? postgreSQLUpdateResult, int sent)
        {
            if (postgreSQLUpdateResult is null)
            {
                return null;
            }

            UpdateItemsResult result = new()
            {
                Sent = sent,
                Updated = postgreSQLUpdateResult.Ids.Count,
            };

            foreach (PostgreSQL.Classes.Rejection rejection in postgreSQLUpdateResult.Rejections)
            {
                if (rejection is null)
                {
                    continue;
                }

                result.Rejected.Add(new UpdateItemsResult.Rejection { Reference = rejection.Reference, Reason = rejection.UpdateRejectionReason });
            }

            return result;
        }
    }
}
