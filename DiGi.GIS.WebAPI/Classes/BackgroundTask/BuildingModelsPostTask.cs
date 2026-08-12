using DiGi.Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.GIS.WebAPI.Classes
{
    /// <summary>
    /// Provides functionality to handle the asynchronous posting of <see cref="DiGi.Analytical.Building.Classes.BuildingModel"/> collections to the PostgreSQL database.
    /// </summary>
    public class BuildingModelsPostTask : SerializableObjectsPostTask<DiGi.Analytical.Building.Classes.BuildingModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingModelsPostTask"/> class.
        /// </summary>
        /// <param name="GISWebAPIManager">The <see cref="GISWebAPIManager"/> instance used to communicate with the server.</param>
        public BuildingModelsPostTask(GISWebAPIManager GISWebAPIManager)
            : base(GISWebAPIManager)
        {
        }

        /// <summary>
        /// Gets or sets the administrative area code the building models belong to. It is resolved server-side to a county identifier.
        /// <para>A code does not identify a single county row - a multi-part county holds one row per polygon part - so set <see cref="CountyId"/> instead wherever the identifier is already known. <see cref="CountyId"/> takes precedence when both are set.</para>
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the county row the building models belong to. When set it is used in preference to <see cref="Code"/>, which leaves the server to choose between the rows of a multi-part county.
        /// </summary>
        public int? CountyId { get; set; }

        /// <summary>
        /// Asynchronously executes the task of posting building models to the database in memory-size-split batches.
        /// </summary>
        /// <param name="buildingModels">The collection of <see cref="DiGi.Analytical.Building.Classes.BuildingModel"/> instances to post.</param>
        /// <param name="code">The administrative area code the building models belong to.</param>
        /// <param name="longProgressWrapper">A <see cref="LongProgressWrapper"/> tracking the progress of the operation.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> to observe for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation. The task result is true if all batches were posted successfully; otherwise, false.</returns>
        protected async Task<bool> ExecuteAsync(IEnumerable<DiGi.Analytical.Building.Classes.BuildingModel>? buildingModels, string? code, LongProgressWrapper? longProgressWrapper, CancellationToken cancellationToken = default)
        {
            if (buildingModels is null || !buildingModels.Any())
            {
                return false;
            }

            List<DiGi.Analytical.Building.Classes.BuildingModel>? buildingModels_Batch;

            bool result = true;

            MemorySizeSplitter<DiGi.Analytical.Building.Classes.BuildingModel> memorySizeSplitter = new(buildingModels);
            while ((buildingModels_Batch = memorySizeSplitter.Next(SerializableObjectsPostOptions.BatchMemorySize)) is not null)
            {
                cancellationToken.ThrowIfCancellationRequested();

                longProgressWrapper?.Increment(buildingModels_Batch.Count);

                result = await GISWebAPIManager.UpdateItemsAsync(buildingModels_Batch, code, SerializableObjectsPostOptions);
                if (!result)
                {
                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// Asynchronously executes the task of posting building models to the database in memory-size-split batches, keyed by county identifier.
        /// </summary>
        /// <param name="buildingModels">The collection of <see cref="DiGi.Analytical.Building.Classes.BuildingModel"/> instances to post.</param>
        /// <param name="countyId">The identifier of the county row the building models belong to.</param>
        /// <param name="longProgressWrapper">A <see cref="LongProgressWrapper"/> tracking the progress of the operation.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> to observe for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation. The task result is true if all batches were posted successfully; otherwise, false.</returns>
        protected async Task<bool> ExecuteAsync(IEnumerable<DiGi.Analytical.Building.Classes.BuildingModel>? buildingModels, int countyId, LongProgressWrapper? longProgressWrapper, CancellationToken cancellationToken = default)
        {
            if (buildingModels is null || !buildingModels.Any())
            {
                return false;
            }

            List<DiGi.Analytical.Building.Classes.BuildingModel>? buildingModels_Batch;

            bool result = true;

            MemorySizeSplitter<DiGi.Analytical.Building.Classes.BuildingModel> memorySizeSplitter = new(buildingModels);
            while ((buildingModels_Batch = memorySizeSplitter.Next(SerializableObjectsPostOptions.BatchMemorySize)) is not null)
            {
                cancellationToken.ThrowIfCancellationRequested();

                longProgressWrapper?.Increment(buildingModels_Batch.Count);

                result = await GISWebAPIManager.UpdateItemsAsync(buildingModels_Batch, countyId, SerializableObjectsPostOptions);
                if (!result)
                {
                    break;
                }
            }

            return result;
        }

        /// <inheritdoc />
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