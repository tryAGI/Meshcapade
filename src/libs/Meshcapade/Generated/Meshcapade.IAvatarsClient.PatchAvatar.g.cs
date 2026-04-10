#nullable enable

namespace Meshcapade
{
    public partial interface IAvatarsClient
    {
        /// <summary>
        /// Update avatar name
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.AssetResponse> PatchAvatarAsync(
            global::System.Guid assetID,

            global::Meshcapade.PatchAvatarRequest request,
            global::Meshcapade.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update avatar name
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.AssetResponse> PatchAvatarAsync(
            global::System.Guid assetID,
            string? name = default,
            global::Meshcapade.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}