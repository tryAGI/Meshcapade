#nullable enable

namespace Meshcapade
{
    public partial interface IInfoClient
    {
        /// <summary>
        /// API health check
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.HealthCheckResponse> GetHealthCheckAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}