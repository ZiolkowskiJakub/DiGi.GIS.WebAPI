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
    /// Represents a task for posting occupancy data to the GIS PostgreSQL Web API.
    /// </summary>
    public class OccupancyDatasPostTask : SerializableObjectsPostTask<OccupancyData>
    {
        /// <summary>
        /// Initializes a new instance of the OccupancyDatasPostTask class.
        /// </summary>
        /// <param name="GISWebAPIManager">The manager used to handle GIS PostgreSQL Web API operations.</param>
        public OccupancyDatasPostTask(GISWebAPIManager GISWebAPIManager)
            : base(GISWebAPIManager)
        {
        }

        /// <summary>
        /// Gets or sets the code associated with the occupancy data post task.
        /// <para>A code does not identify a single county row - a multi-part county holds one row per polygon part - so set <see cref="CountyId"/> instead wherever the identifier is already known. <see cref="CountyId"/> takes precedence when both are set.</para>
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the county row the building 2D occupancy data belong to. When set it is used in preference to <see cref="Code"/>, which leaves the server to choose between the rows of a multi-part county. It does not affect <see cref="Values_AdministrativeAreal2D"/>, which is not county-keyed.
        /// </summary>
        public int? CountyId { get; set; }

        /// <summary>
        /// Gets or sets the collection of <see cref="OccupancyData"/> values for administrative areal 2D.
        /// </summary>
        public IEnumerable<OccupancyData>? Values_AdministrativeAreal2D { get; set; }

        protected async Task<bool> ExecuteAsync(IEnumerable<OccupancyData>? occupancyData_Building2D, string? code, LongProgressWrapper? longProgressWrapper, CancellationToken cancellationToken)
        {
            if (occupancyData_Building2D is null || !occupancyData_Building2D.Any())
            {
                return false;
            }

            List<OccupancyData>? occupancyDatas;

            bool result = false;

            MemorySizeSplitter<OccupancyData> memorySizeSplitter = new(occupancyData_Building2D);
            while ((occupancyDatas = memorySizeSplitter.Next(SerializableObjectsPostOptions.BatchMemorySize)) is not null)
            {
                cancellationToken.ThrowIfCancellationRequested();

                longProgressWrapper?.Increment(occupancyDatas.Count);

                result = await GISWebAPIManager.UpdateItemsAsync(occupancyDatas, code, SerializableObjectsPostOptions);
                if (!result)
                {
                    break;
                }
            }

            return result;
        }

        protected async Task<bool> ExecuteAsync(IEnumerable<OccupancyData>? occupancyData_AdministrativeAreal2D, LongProgressWrapper? longProgressWrapper, CancellationToken cancellationToken)
        {
            if (occupancyData_AdministrativeAreal2D is null || !occupancyData_AdministrativeAreal2D.Any())
            {
                return false;
            }

            List<OccupancyData>? occupancyDatas;

            bool result = false;

            MemorySizeSplitter<OccupancyData> memorySizeSplitter = new(occupancyData_AdministrativeAreal2D);
            while ((occupancyDatas = memorySizeSplitter.Next(SerializableObjectsPostOptions.BatchMemorySize)) is not null)
            {
                cancellationToken.ThrowIfCancellationRequested();

                longProgressWrapper?.Increment(occupancyDatas.Count);

                result = await GISWebAPIManager.UpdateItemsAsync(occupancyDatas, SerializableObjectsPostOptions);
                if (!result)
                {
                    break;
                }
            }

            return result;
        }

        protected async Task<bool> ExecuteAsync(IEnumerable<OccupancyData>? occupancyData_Building2D, int countyId, LongProgressWrapper? longProgressWrapper, CancellationToken cancellationToken)
        {
            if (occupancyData_Building2D is null || !occupancyData_Building2D.Any())
            {
                return false;
            }

            List<OccupancyData>? occupancyDatas;

            bool result = false;

            MemorySizeSplitter<OccupancyData> memorySizeSplitter = new(occupancyData_Building2D);
            while ((occupancyDatas = memorySizeSplitter.Next(SerializableObjectsPostOptions.BatchMemorySize)) is not null)
            {
                cancellationToken.ThrowIfCancellationRequested();

                longProgressWrapper?.Increment(occupancyDatas.Count);

                result = await GISWebAPIManager.UpdateItemsAsync(occupancyDatas, countyId, SerializableObjectsPostOptions);
                if (!result)
                {
                    break;
                }
            }

            return result;
        }

        protected override async Task<bool> ExecuteAsync(IProgress<long> progress, CancellationToken cancellationToken)
        {
            // An identifier names the county row outright; a code only narrows it to the rows of a
            // multi-part county and lets the server pick one, so it is the fallback.
            bool result_1 = CountyId is int countyId
                ? await ExecuteAsync(Values, countyId, Core.Create.LongProgressWrapper(progress), cancellationToken)
                : await ExecuteAsync(Values, Code, Core.Create.LongProgressWrapper(progress), cancellationToken);

            bool result_2 = await ExecuteAsync(Values_AdministrativeAreal2D, Core.Create.LongProgressWrapper(progress), cancellationToken);

            return result_1 || result_2;
        }
    }
}