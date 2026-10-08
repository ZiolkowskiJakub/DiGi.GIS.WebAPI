using DiGi.Core.Interfaces;
using DiGi.WebAPI.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.GIS.WebAPI
{
    public static partial class Modify
    {
        /// <summary>
        /// Asynchronously posts a list of building references to a protected maintenance endpoint and reads back the DiGi result it answers with.
        /// <para>The shared plumbing of the year built maintenance clients: the access key travels in the <c>key</c> header, never the query string; a null or empty <paramref name="references"/> sends no body, which those endpoints read as "every building of the parts"; and the per-attempt delay is stretched to the server's command timeout so a long delete is not cut off by the 20 s client default (<c>Coding - WebAPI Contracts.md</c> §3). A refused request - 401, 400, or 413 for a scope over its limit - and a failed one both answer null; the server log carries the reason.</para>
        /// </summary>
        /// <typeparam name="TSerializableObject">The type of the DiGi result the endpoint answers with.</typeparam>
        /// <param name="httpClient">The <see cref="HttpClient"/> to post with.</param>
        /// <param name="requestUri">The request URI, query string included.</param>
        /// <param name="references">The references to post, or null to post no body.</param>
        /// <param name="commandTimeout">The server command timeout the request carries, in seconds; the per-attempt delay is stretched to it.</param>
        /// <param name="postOptions">Optional configuration options for the HTTP request.</param>
        /// <param name="key">The access key of the protected endpoint.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
        /// <returns>A task returning the result, or null when the request was refused or failed.</returns>
        public static async Task<TSerializableObject?> PostReferencesAsync<TSerializableObject>(this HttpClient? httpClient, string? requestUri, IEnumerable<string>? references, int commandTimeout, PostOptions? postOptions, string? key, CancellationToken cancellationToken = default) where TSerializableObject : ISerializableObject
        {
            if (httpClient is null || string.IsNullOrWhiteSpace(requestUri))
            {
                return default;
            }

            if (!string.IsNullOrWhiteSpace(key))
            {
                if (httpClient.DefaultRequestHeaders.Contains("key"))
                {
                    httpClient.DefaultRequestHeaders.Remove("key");
                }

                httpClient.DefaultRequestHeaders.Add("key", key);
            }

            PostOptions postOptions_Resolved = postOptions is null ? new PostOptions() : new PostOptions(postOptions);
            postOptions_Resolved.RequestResult = true;

            TimeSpan delay = TimeSpan.FromSeconds(commandTimeout <= 0 ? 600 : commandTimeout + 30);
            if (postOptions_Resolved.Delay < delay)
            {
                postOptions_Resolved.Delay = delay;
            }

            List<string>? references_List = references?.Where(x => !string.IsNullOrWhiteSpace(x)).Distinct().ToList();

            try
            {
                // Passed as a factory: sending consumes the content, so a retry has to build it again.
                PostResponse<string?> postResponse = await DiGi.WebAPI.Modify.PostAsync<string>(httpClient, requestUri, async () => references_List is null || references_List.Count == 0 ? null : await Create.HttpContent(references_List, CancellationToken.None), postOptions_Resolved);
                if (postResponse is null || !postResponse.Succeeded || string.IsNullOrWhiteSpace(postResponse.Result))
                {
                    return default;
                }

                List<TSerializableObject>? serializableObjects = Core.Convert.ToDiGi<TSerializableObject>(postResponse.Result);
                return serializableObjects is null ? default : serializableObjects.FirstOrDefault();
            }
            catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                throw;
            }
            catch (Exception exception)
            {
                Serilog.Modify.Log(exception, "The maintenance request to {RequestUri} could not be completed", requestUri);
                return default;
            }
        }
    }
}
