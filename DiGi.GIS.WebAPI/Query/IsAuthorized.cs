using DiGi.GIS.WebAPI.Classes;
using System.Security.Cryptography;
using System.Text;

namespace DiGi.GIS.WebAPI
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether a provided access key is authorized according to the GIS PostgreSQL Web API configuration.
        /// <para>Denies by default: a missing configuration watcher, disabled enforcement, a blank configured key or a blank supplied key all deny access. The only way to perform write operations without a key is the explicit <see cref="GISWebAPIConfigurationFileWatcher.Open"/> opt-out.</para>
        /// </summary>
        /// <param name="gISWebAPIConfigurationFileWatcher">The GIS PostgreSQL Web API configuration file watcher to validate against.</param>
        /// <param name="key">The access key to validate.</param>
        /// <returns>True if access is authorized; otherwise, false.</returns>
        public static bool IsAuthorized(this GISWebAPIConfigurationFileWatcher? gISWebAPIConfigurationFileWatcher, string? key)
        {
            if (gISWebAPIConfigurationFileWatcher is null)
            {
                return false;
            }

            if (gISWebAPIConfigurationFileWatcher.Open)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "GIS WebAPI: {FileName} sets Open=true - write endpoints are reachable WITHOUT a key. Never use this on a deployed host.", Constants.FileName.GISWebAPIConfigurationFile);
                return true;
            }

            if (!gISWebAPIConfigurationFileWatcher.Enabled)
            {
                return false;
            }

            string? key_Configured = gISWebAPIConfigurationFileWatcher.Key;
            if (string.IsNullOrWhiteSpace(key_Configured) || string.IsNullOrWhiteSpace(key))
            {
                return false;
            }

            byte[] bytes_Configured = Encoding.UTF8.GetBytes(key_Configured);
            byte[] bytes_Provided = Encoding.UTF8.GetBytes(key);

            return CryptographicOperations.FixedTimeEquals(bytes_Configured, bytes_Provided);
        }
    }
}
