#nullable enable

namespace Meshcapade
{
    public partial interface IAvatarsFromVideoClient
    {
        /// <summary>
        /// Initiate avatar creation from video
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.AssetResponse> CreateAvatarFromVideoAsync(
            global::Meshcapade.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}