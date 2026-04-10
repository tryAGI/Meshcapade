#nullable enable

namespace Meshcapade
{
    public partial interface IAvatarsFromImagesClient
    {
        /// <summary>
        /// Start fitting avatar to uploaded images
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.AssetResponse> FitToImagesAsync(
            global::System.Guid assetID,

            global::Meshcapade.FitToImagesRequest request,
            global::Meshcapade.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start fitting avatar to uploaded images
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="imageMode"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.AssetResponse> FitToImagesAsync(
            global::System.Guid assetID,
            string? imageMode = default,
            global::Meshcapade.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}