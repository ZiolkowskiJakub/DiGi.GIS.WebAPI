using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using DiGi.GIS.PostgreSQL.Classes;
using DiGi.WebAPI.Classes;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.GIS.WebAPI.Classes
{
    /// <summary>
    /// Handles the process of posting orthodata retrieved from the database.
    /// </summary>
    public class OrtoDatasFromDatabasePostTask : OrtoDatasPostTask
    {
        /// <summary>
        /// Handles the process of posting orthodata retrieved from the database.
        /// </summary>
        /// <param name="GISWebAPIManager">The manager responsible for handling GIS PostgreSQL Web API communications.</param>
        public OrtoDatasFromDatabasePostTask(GISWebAPIManager GISWebAPIManager)
            : base(GISWebAPIManager)
        {
        }

        /// <summary>
        /// Gets or sets the number of items to claim per batch from the update queue. Defaults to 5.
        /// </summary>
        public int Count { get; set; } = 5;

        /// <summary>
        /// Gets or sets the options used for retrieving 2D building orthophoto data.
        /// </summary>
        public OrtoDatasBuilding2DOptions? OrtoDatasBuilding2DOptions { get; set; } = new();

        /// <summary>
        /// Gets or sets the number of consecutive failed batches (request timeouts, HTTP errors, failed fetches or uploads) after which the task stops. Defaults to 3.
        /// <para>A single failed batch is logged and skipped - its references stay claimed and return to the queue when their lease expires - so only a server that keeps failing ends the run. Values below 1 are treated as 1.</para>
        /// </summary>
        public int MaxConsecutiveFailureCount { get; set; } = 3;

        /// <inheritdoc />
        protected override async Task<bool> ExecuteAsync(IProgress<long> progress, CancellationToken cancellationToken)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(OrtoDatasFromDatabasePostTask), nameof(ExecuteAsync));

            if (GISWebAPIManager is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "GISWebAPIManager cannot be null");
                return false;
            }

            HttpClient? httpClient_OrtoDatas = GISWebAPIManager.CreateHttpClient<OrtoDatasController>(nameof(OrtoDatasController.NextBuilding2DReferencesAsync), out string? path_OrtoDatas);
            if (httpClient_OrtoDatas is null || string.IsNullOrWhiteSpace(path_OrtoDatas))
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "OrtoDatas HttpClient could not be created");
                return false;
            }

            string requestUri_OrtoDatas = new UrlBuilder(path_OrtoDatas).AddParameter("count", Count > 0 ? Count : 5).ToString();

            HttpClient? httpClient_Building2D = GISWebAPIManager.CreateHttpClient<Building2DController>(nameof(Building2DController.GetItemsByBuilding2DReferencesAsync), out string? path_Building2D);
            if (httpClient_Building2D is null || string.IsNullOrWhiteSpace(path_Building2D))
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Building2D HttpClient could not be created");
                return false;
            }

            HttpClient? httpClient_Geoportal = Create.HttpClient_Geoportal(GISWebAPIManager);
            if (httpClient_Geoportal is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Geoportal HttpClient could not be created");
                return false;
            }

            HttpClient? httpClient_OrtoDatas_Acknowledge = GISWebAPIManager.CreateHttpClient<OrtoDatasController>(nameof(OrtoDatasController.AcknowledgeBuilding2DReferencesAsync), out string? path_OrtoDatas_Acknowledge);

            string requestUri_Building2D = new UrlBuilder(path_Building2D).ToString();

            PostOptions postOptions = new() { RequestResult = true };

            PostResponse<List<Building2DReference>?> postResponse_Building2DReferences;
            try
            {
                postResponse_Building2DReferences = await DiGi.WebAPI.Modify.PostAsync<List<Building2DReference>>(httpClient_OrtoDatas, requestUri_OrtoDatas, (HttpContent?)null, postOptions);
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "Failed to claim initial Building2DReferences from queue");
                throw;
            }

            if (postResponse_Building2DReferences is null || !postResponse_Building2DReferences.Succeeded)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Building2DReferences could not be retrieved from the queue");
                return false;
            }

            LongProgressWrapper? longProgressWrapper = Core.Create.LongProgressWrapper(progress);
            OrtoDatasBuilding2DOptions ortoDatasBuilding2DOptions = OrtoDatasBuilding2DOptions ?? new();

            int maxConsecutiveFailureCount = MaxConsecutiveFailureCount < 1 ? 1 : MaxConsecutiveFailureCount;
            int failureCount = 0;
            int? countyId_Failed = null;
            Exception? exception_Failed = null;

            while (postResponse_Building2DReferences is not null && postResponse_Building2DReferences.Succeeded && postResponse_Building2DReferences.Result is List<Building2DReference> building2DReferences && building2DReferences.Count > 0)
            {
                cancellationToken.ThrowIfCancellationRequested();

                while (building2DReferences.Count > 0)
                {
                    int? countyId = building2DReferences[0].CountyId;

                    Core.Query.Filter(building2DReferences, x => x?.CountyId == countyId, out List<Building2DReference>? building2DReference_In, out List<Building2DReference>? building2DReferences_Out);
                    building2DReferences = building2DReferences_Out ?? [];

                    if (building2DReference_In != null && building2DReference_In.Count != 0 && countyId is not null && countyId.HasValue)
                    {
                        List<Building2DReference> building2DReferences_Claimed = building2DReference_In;

                        try
                        {
                            List<GIS.Classes.Building2D>? building2Ds = null;

                            // A factory rather than a single-use HttpContent - the body is rebuilt per attempt, so a dropped pooled
                            // connection is retried instead of skipping the batch. A null body means the references failed to
                            // serialize; the exception is the failure signal, handled by the catch below.
                            PostResponse<List<GIS.Classes.Building2D>?> postResponse_Building2Ds = await DiGi.WebAPI.Modify.PostAsync<List<GIS.Classes.Building2D>>(httpClient_Building2D, requestUri_Building2D, async () => await Create.HttpContent(building2DReferences_Claimed, cancellationToken).ConfigureAwait(false) ?? throw new InvalidOperationException("HttpContent for Building2D references could not be created"), postOptions);
                            if (postResponse_Building2Ds is null || !postResponse_Building2Ds.Succeeded)
                            {
                                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Building2Ds could not be fetched for {Count} references", building2DReferences_Claimed.Count);
                                failureCount++;
                                countyId_Failed = countyId.Value;
                                ThrowIfFailureLimitReached(failureCount, maxConsecutiveFailureCount, countyId_Failed, postOptions, exception_Failed);
                                continue;
                            }

                            building2Ds = postResponse_Building2Ds.Result;

                            if (building2Ds is null || building2Ds.Count == 0)
                            {
                                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "No Building2Ds returned for {Count} references", building2DReferences_Claimed.Count);
                                continue;
                            }

                            List<GIS.Classes.OrtoDatas> ortoDatasList = [];
                            foreach (GIS.Classes.Building2D building2D in building2Ds)
                            {
                                cancellationToken.ThrowIfCancellationRequested();

                                GIS.Classes.OrtoDatas? ortoDatas = await GIS.Create.OrtoDatas(httpClient_Geoportal, building2D, ortoDatasBuilding2DOptions.Years, ortoDatasBuilding2DOptions.Offset, ortoDatasBuilding2DOptions.Width, ortoDatasBuilding2DOptions.Reduce, squared: true);
                                if (ortoDatas is null)
                                {
                                    continue;
                                }

                                ortoDatasList.Add(ortoDatas);
                            }

                            if (ortoDatasList.Count > 0)
                            {
                                bool succeeded = await ExecuteAsync(ortoDatasList, countyId.Value, longProgressWrapper, cancellationToken);
                                if (succeeded)
                                {
                                    failureCount = 0;
                                    exception_Failed = null;

                                    HashSet<string> references_Stored = [];
                                    foreach (GIS.Classes.OrtoDatas ortoDatas in ortoDatasList)
                                    {
                                        if (!string.IsNullOrWhiteSpace(ortoDatas?.Reference))
                                        {
                                            references_Stored.Add(ortoDatas.Reference);
                                        }
                                    }

                                    List<long> ids = [];
                                    foreach (Building2DReference building2DReference in building2DReferences_Claimed)
                                    {
                                        if (building2DReference is not null && building2DReference.Id > 0 && !string.IsNullOrWhiteSpace(building2DReference.Reference) && references_Stored.Contains(building2DReference.Reference))
                                        {
                                            ids.Add(building2DReference.Id);
                                        }
                                    }

                                    if (ids.Count > 0 && httpClient_OrtoDatas_Acknowledge is not null && !string.IsNullOrWhiteSpace(path_OrtoDatas_Acknowledge))
                                    {
                                        string? json_Ack = System.Text.Json.JsonSerializer.Serialize(ids);
                                        if (!string.IsNullOrWhiteSpace(json_Ack))
                                        {
                                            // A factory rather than a single-use HttpContent - the body is rebuilt per attempt, so a dropped
                                            // connection is retried instead of leaving the stored references claimed until lease expiry.
                                            PostResponse postResponse_Ack = await DiGi.WebAPI.Modify.PostAsync(httpClient_OrtoDatas_Acknowledge, path_OrtoDatas_Acknowledge, async () => await Create.HttpContent(json_Ack, cancellationToken).ConfigureAwait(false) ?? throw new InvalidOperationException("HttpContent for acknowledge could not be created"), postOptions);
                                            if (postResponse_Ack is null || !postResponse_Ack.Succeeded)
                                            {
                                                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "OrtoDatas stored but not acknowledged for {Count} references in county {CountyId}; they are re-processed after lease expiry", ids.Count, countyId.Value);
                                            }
                                        }
                                    }

                                    if (ids.Count != building2DReferences_Claimed.Count)
                                    {
                                        Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "OrtoDatas claimed but not stored: {Count}/{Total} references stay claimed and return to the queue when their lease expires", building2DReferences_Claimed.Count - ids.Count, building2DReferences_Claimed.Count);
                                    }
                                }
                                else
                                {
                                    Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "OrtoDatas could not be updated for county {CountyId}. References remain claimed and will retry on lease expiry.", countyId.Value);
                                    failureCount++;
                                    countyId_Failed = countyId.Value;
                                    ThrowIfFailureLimitReached(failureCount, maxConsecutiveFailureCount, countyId_Failed, postOptions, exception_Failed);
                                }
                            }
                            else
                            {
                                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "No OrtoDatas imagery extracted for {Count} buildings in county {CountyId}", building2Ds.Count, countyId.Value);
                            }
                        }
                        catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
                        {
                            Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "{Type}:{Name} canceled", nameof(OrtoDatasFromDatabasePostTask), nameof(ExecuteAsync));
                            throw;
                        }
                        catch (OperationCanceledException operationCanceledException)
                        {
                            // A request timeout, not a user cancel: skip the batch - the lease expiry re-queues its references.
                            Serilog.Modify.Log(operationCanceledException, "Request timed out during OrtoDatas processing in county {CountyId}; {Count} references stay claimed until lease expiry", countyId.Value, building2DReferences_Claimed.Count);
                            failureCount++;
                            countyId_Failed = countyId.Value;
                            exception_Failed = operationCanceledException;
                        }
                        catch (HttpRequestException httpRequestException)
                        {
                            Serilog.Modify.Log(httpRequestException, "HTTP error during OrtoDatas processing in county {CountyId}; {Count} references stay claimed until lease expiry", countyId.Value, building2DReferences_Claimed.Count);
                            failureCount++;
                            countyId_Failed = countyId.Value;
                            exception_Failed = httpRequestException;
                        }
                        catch (Exception exception)
                        {
                            Serilog.Modify.Log(exception, "Unexpected error during OrtoDatas processing in county {CountyId}", countyId.Value);
                            throw;
                        }

                        ThrowIfFailureLimitReached(failureCount, maxConsecutiveFailureCount, countyId_Failed, postOptions, exception_Failed);
                    }
                }

                cancellationToken.ThrowIfCancellationRequested();

                while (true)
                {
                    try
                    {
                        postResponse_Building2DReferences = await DiGi.WebAPI.Modify.PostAsync<List<Building2DReference>>(httpClient_OrtoDatas, requestUri_OrtoDatas, (HttpContent?)null, postOptions);
                        break;
                    }
                    catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
                    {
                        Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "{Type}:{Name} canceled", nameof(OrtoDatasFromDatabasePostTask), nameof(ExecuteAsync));
                        throw;
                    }
                    catch (Exception exception) when (exception is OperationCanceledException || exception is HttpRequestException)
                    {
                        // A timeout or dropped connection on the claim: retry the claim, bounded by the failure limit.
                        Serilog.Modify.Log(exception, "Failed to claim next batch of Building2DReferences; retrying");
                        failureCount++;
                        exception_Failed = exception;
                        ThrowIfFailureLimitReached(failureCount, maxConsecutiveFailureCount, countyId_Failed, postOptions, exception_Failed);
                    }
                    catch (Exception exception)
                    {
                        Serilog.Modify.Log(exception, "Failed to claim next batch of Building2DReferences");
                        throw;
                    }
                }
            }

            Serilog.Modify.Log("{Type}:{Name} completed successfully", nameof(OrtoDatasFromDatabasePostTask), nameof(ExecuteAsync));
            return true;
        }

        private static void ThrowIfFailureLimitReached(int failureCount, int maxConsecutiveFailureCount, int? countyId, PostOptions postOptions, Exception? exception)
        {
            if (failureCount < maxConsecutiveFailureCount)
            {
                return;
            }

            string message = string.Format("OrtoDatas upload stopped after {0} consecutive failed batches (last: county {1}); the server did not answer successfully within {2}s per attempt", failureCount, countyId?.ToString() ?? "-", postOptions.Delay.TotalSeconds);

            Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, message);

            throw new TimeoutException(message, exception);
        }
    }
}