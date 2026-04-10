#nullable enable

namespace Meshcapade
{
    public partial interface IAvatarsClient
    {
        /// <summary>
        /// Cancel avatar build
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task CancelAvatarBuildAsync(
            global::System.Guid assetID,
            global::Meshcapade.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}