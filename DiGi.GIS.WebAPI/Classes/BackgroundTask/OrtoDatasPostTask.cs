using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.GIS.WebAPI.Classes
{
    /// <summary>
    /// Handles the posting of OrtoDatas objects to the PostgreSQL web API.
    /// </summary>
    public class OrtoDatasPostTask : SerializableObjectsPostTask<OrtoDatas>
    {
        /// <summary>
        /// Handles the posting of OrtoDatas objects to the PostgreSQL web API.
        /// </summary>
        /// <param name="GISWebAPIManager">The manager instance used to handle PostgreSQL web API operations.</param>
        public OrtoDatasPostTask(GISWebAPIManager GISWebAPIManager)
            : base(GISWebAPIManager)
        {
        }

        /// <summary>
        /// Gets or sets the code associated with the OrtoDatas post task.
        /// <para>A code does not identify a single county row - a multi-part county holds one row per polygon part - so set <see cref="CountyId"/> instead wherever the identifier is already known. <see cref="CountyId"/> takes precedence when both are set.</para>
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the county row the OrtoDatas belong to. When set it is used in preference to <see cref="Code"/>, which leaves the server to choose between the rows of a multi-part county.
        /// </summary>
        public int? CountyId { get; set; }

        protected async Task<bool> ExecuteAsync(IEnumerable<OrtoDatas>? values, string? code, LongProgressWrapper? longProgressWrapper, CancellationToken cancellationToken)
        {
            if (values is null || !values.Any())
            {
                return false;
            }

            List<OrtoDatas>? ortoDatasList;
            bool result = true;

            MemorySizeSplitter<OrtoDatas> memorySizeSplitter = new(values);
            while ((ortoDatasList = memorySizeSplitter.Next(SerializableObjectsPostOptions.BatchMemorySize)) is not null)
            {
                cancellationToken.ThrowIfCancellationRequested();

                longProgressWrapper?.Increment(ortoDatasList.Count);

                result = await GISWebAPIManager.UpdateItemsAsync(ortoDatasList, code, SerializableObjectsPostOptions);
                if (!result)
                {
                    break;
                }
            }

            return result;
        }

        protected async Task<bool> ExecuteAsync(IEnumerable<OrtoDatas>? values, int countyId, LongProgressWrapper? longProgressWrapper, CancellationToken cancellationToken)
        {
            if (values is null || !values.Any())
            {
                return false;
            }

            List<OrtoDatas>? ortoDatasList;
            bool result = true;

            MemorySizeSplitter<OrtoDatas> memorySizeSplitter = new(values);
            while ((ortoDatasList = memorySizeSplitter.Next(SerializableObjectsPostOptions.BatchMemorySize)) is not null)
            {
                cancellationToken.ThrowIfCancellationRequested();

                longProgressWrapper?.Increment(ortoDatasList.Count);

                result = await GISWebAPIManager.UpdateItemsAsync(ortoDatasList, countyId, SerializableObjectsPostOptions);
                if (!result)
                {
                    break;
                }
            }

            return result;
        }

        protected override async Task<bool> ExecuteAsync(IProgress<long> progress, CancellationToken cancellationToken)
        {
            LongProgressWrapper? longProgressWrapper = Core.Create.LongProgressWrapper(progress);

            // An identifier names the county row outright; a code only narrows it to the rows of a
            // multi-part county and lets the server pick one, so it is the fallback.
            if (CountyId is int countyId)
            {
                return await ExecuteAsync(Values, countyId, longProgressWrapper, cancellationToken);
            }

            return await ExecuteAsync(Values, Code, longProgressWrapper, cancellationToken);
        }
    }
}