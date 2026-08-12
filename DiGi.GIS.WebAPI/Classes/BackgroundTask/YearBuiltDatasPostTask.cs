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
    /// Provides functionality to handle the asynchronous posting of <see cref="YearBuiltData"/> collections to the PostgreSQL database.
    /// </summary>
    public class YearBuiltDatasPostTask : SerializableObjectsPostTask<YearBuiltData>
    {
        /// <summary>
        /// Initializes a new instance of the YearBuiltDatasPostTask class.
        /// </summary>
        /// <param name="GISWebAPIManager">The GIS PostgreSQL Web API manager used to handle data persistence.</param>
        public YearBuiltDatasPostTask(GISWebAPIManager GISWebAPIManager)
            : base(GISWebAPIManager)
        {
        }

        /// <summary>
        /// Gets or sets the code associated with the year built data post task.
        /// <para>A code does not identify a single county row - a multi-part county holds one row per polygon part - so set <see cref="CountyId"/> instead wherever the identifier is already known. <see cref="CountyId"/> takes precedence when both are set.</para>
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the county row the year built data belong to. When set it is used in preference to <see cref="Code"/>, which leaves the server to choose between the rows of a multi-part county.
        /// </summary>
        public int? CountyId { get; set; }

        protected async Task<bool> ExecuteAsync(IEnumerable<YearBuiltData>? values, string? code, LongProgressWrapper? longProgressWrapper, CancellationToken cancellationToken)
        {
            if (values is null || !values.Any())
            {
                return false;
            }

            List<YearBuiltData>? yearBuiltDatas;

            bool result = true;

            MemorySizeSplitter<YearBuiltData> memorySizeSplitter = new(values);
            while ((yearBuiltDatas = memorySizeSplitter.Next(SerializableObjectsPostOptions.BatchMemorySize)) is not null)
            {
                cancellationToken.ThrowIfCancellationRequested();

                longProgressWrapper?.Increment(yearBuiltDatas.Count);

                result = await GISWebAPIManager.UpdateItemsAsync(yearBuiltDatas, code, SerializableObjectsPostOptions);
                if (!result)
                {
                    break;
                }
            }

            return result;
        }

        protected async Task<bool> ExecuteAsync(IEnumerable<YearBuiltData>? values, int countyId, LongProgressWrapper? longProgressWrapper, CancellationToken cancellationToken)
        {
            if (values is null || !values.Any())
            {
                return false;
            }

            List<YearBuiltData>? yearBuiltDatas;

            bool result = true;

            MemorySizeSplitter<YearBuiltData> memorySizeSplitter = new(values);
            while ((yearBuiltDatas = memorySizeSplitter.Next(SerializableObjectsPostOptions.BatchMemorySize)) is not null)
            {
                cancellationToken.ThrowIfCancellationRequested();

                longProgressWrapper?.Increment(yearBuiltDatas.Count);

                result = await GISWebAPIManager.UpdateItemsAsync(yearBuiltDatas, countyId, SerializableObjectsPostOptions);
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