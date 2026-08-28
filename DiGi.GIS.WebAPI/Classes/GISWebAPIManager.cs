using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace DiGi.GIS.WebAPI.Classes
{
    /// <summary>
    /// Manages the creation and lifecycle of <see cref="HttpClient"/> instances used to interact with the GIS PostgreSQL Web API.
    /// </summary>
    public class GISWebAPIManager
    {
        private readonly IHttpClientFactory? httpClientFactory;
        private string? key;

        /// <summary>
        /// Initializes a new instance of the <see cref="GISWebAPIManager"/> class.
        /// </summary>
        /// <param name="httpClientFactory">The HTTP client factory used to create and manage <see cref="HttpClient"/> instances.</param>
        /// <param name="key">The optional API authorization key used for authenticating requests to protected endpoints.</param>
        public GISWebAPIManager(IHttpClientFactory? httpClientFactory, string? key = null)
        {
            this.httpClientFactory = httpClientFactory;
            this.key = key;
        }

        /// <summary>
        /// Gets or sets the API authorization key used for authenticating requests to protected endpoints.
        /// </summary>
        public string? Key
        {
            get
            {
                return key;
            }
            set
            {
                key = value;
            }
        }

        /// <summary>
        /// Creates an HttpClient instance with the specified name.
        /// </summary>
        /// <param name="name">The unique identifier or name of the HTTP client to be created.</param>
        /// <returns>An <see cref="HttpClient"/> instance configured with the specified client name and authorization key header if configured.</returns>
        public HttpClient? CreateHttpClient(string name)
        {
            HttpClient? httpClient = httpClientFactory?.CreateClient(name);
            if (httpClient is not null && !string.IsNullOrWhiteSpace(key))
            {
                if (httpClient.DefaultRequestHeaders.Contains("key"))
                {
                    httpClient.DefaultRequestHeaders.Remove("key");
                }

                httpClient.DefaultRequestHeaders.Add("key", key);
            }

            return httpClient;
        }

        /// <summary>
        /// Creates an <see cref="HttpClient"/> instance configured for the Web API, resolving the route associated with the specified controller type.
        /// </summary>
        /// <typeparam name="TControllerBase">The TControllerBase type parameter.</typeparam>
        /// <param name="route">The route.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public HttpClient? CreateHttpClient<TControllerBase>(out string? route) where TControllerBase : ControllerBase
        {
            route = DiGi.WebAPI.Query.Route<TControllerBase>();
            if (string.IsNullOrWhiteSpace(route))
            {
                return null;
            }

            return CreateHttpClient(Constants.Name.Client.GIS);
        }

        /// <summary>
        /// Creates an <see cref="HttpClient"/> instance configured for the specified controller's method and retrieves the corresponding API path.
        /// </summary>
        /// <typeparam name="TControllerBase">The type of the base controller used to resolve the endpoint path.</typeparam>
        /// <param name="methodName">The name of the method within the controller to resolve.</param>
        /// <param name="path">The path.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public HttpClient? CreateHttpClient<TControllerBase>(string methodName, out string? path) where TControllerBase : ControllerBase
        {
            path = DiGi.WebAPI.Query.Path<TControllerBase>(methodName);
            if (string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            return CreateHttpClient(Constants.Name.Client.GIS);
        }
    }
}