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

                            using CancellationTokenSource cancellationTokenSource = new(postOptions.Delay);

                            using (HttpContent? httpContent = await Create.HttpContent(building2DReferences_Claimed, cancellationTokenSource.Token).ConfigureAwait(false))
                            {
                                if (httpContent is null)
                                {
                                    Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "HttpContent for Building2D references could not be created");
                                    return false;
                                }

                                PostResponse<List<GIS.Classes.Building2D>?> postResponse_Building2Ds = await DiGi.WebAPI.Modify.PostAsync<List<GIS.Classes.Building2D>>(httpClient_Building2D, requestUri_Building2D, httpContent, postOptions);
                                if (postResponse_Building2Ds is null || !postResponse_Building2Ds.Succeeded)
                                {
                                    Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Building2Ds could not be fetched for {Count} references", building2DReferences_Claimed.Count);
                                    continue;
                                }

                                building2Ds = postResponse_Building2Ds.Result;
                            }

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
                                        using CancellationTokenSource cancellationTokenSource_Ack = new(postOptions.Delay);
                                        string? json_Ack = System.Text.Json.JsonSerializer.Serialize(ids);
                                        if (!string.IsNullOrWhiteSpace(json_Ack))
                                        {
                                            using HttpContent? httpContent_Ack = await Create.HttpContent(json_Ack, cancellationTokenSource_Ack.Token).ConfigureAwait(false);
                                            if (httpContent_Ack is not null)
                                            {
                                                await DiGi.WebAPI.Modify.PostAsync(httpClient_OrtoDatas_Acknowledge, path_OrtoDatas_Acknowledge, httpContent_Ack, postOptions);
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
                                }
                            }
                            else
                            {
                                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "No OrtoDatas imagery extracted for {Count} buildings in county {CountyId}", building2Ds.Count, countyId.Value);
                            }
                        }
                        catch (OperationCanceledException)
                        {
                            Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "{Type}:{Name} canceled", nameof(OrtoDatasFromDatabasePostTask), nameof(ExecuteAsync));
                            throw;
                        }
                        catch (HttpRequestException httpRequestException)
                        {
                            Serilog.Modify.Log(httpRequestException, "HTTP error during OrtoDatas processing in county {CountyId}", countyId.Value);
                        }
                        catch (Exception exception)
                        {
                            Serilog.Modify.Log(exception, "Unexpected error during OrtoDatas processing in county {CountyId}", countyId.Value);
                            throw;
                        }
                    }
                }

                cancellationToken.ThrowIfCancellationRequested();

                try
                {
                    postResponse_Building2DReferences = await DiGi.WebAPI.Modify.PostAsync<List<Building2DReference>>(httpClient_OrtoDatas, requestUri_OrtoDatas, (HttpContent?)null, postOptions);
                }
                catch (Exception exception)
                {
                    Serilog.Modify.Log(exception, "Failed to claim next batch of Building2DReferences");
                    throw;
                }
            }

            Serilog.Modify.Log("{Type}:{Name} completed successfully", nameof(OrtoDatasFromDatabasePostTask), nameof(ExecuteAsync));
            return true;
        }
    }
}