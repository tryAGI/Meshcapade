#nullable enable

namespace Meshcapade
{
    public partial interface IAvatarsFromScansClient
    {
        /// <summary>
        /// Start fitting avatar to uploaded scans
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.AssetResponse> FitToScansAsync(
            global::System.Guid assetID,

            global::Meshcapade.FitToScansRequest request,
            global::Meshcapade.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start fitting avatar to uploaded scans
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="initPose"></param>
        /// <param name="inputUnits"></param>
        /// <param name="lookAxis"></param>
        /// <param name="upAxis"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.AssetResponse> FitToScansAsync(
            global::System.Guid assetID,
            string? initPose = default,
            string? inputUnits = default,
            string? lookAxis = default,
            string? upAxis = default,
            global::Meshcapade.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}