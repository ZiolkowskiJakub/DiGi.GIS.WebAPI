using DiGi.GIS.WebAPI.Classes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;

namespace DiGi.GIS.WebAPI
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a new instance of the <see cref="Classes.GISWebAPIManager"/> class.
        /// </summary>
        /// <param name="key">The optional API authorization key used for authenticating requests to protected endpoints.</param>
        /// <returns>A new <see cref="Classes.GISWebAPIManager"/> instance configured with the registered services and optional authorization key.</returns>
        public static GISWebAPIManager? GISWebAPIManager(string? key = null)
        {
            IServiceProvider serviceProvider = ServiceProvider();
            if (serviceProvider is null)
            {
                return null;
            }

            return new GISWebAPIManager(serviceProvider?.GetRequiredService<IHttpClientFactory>(), key);
        }
    }
}