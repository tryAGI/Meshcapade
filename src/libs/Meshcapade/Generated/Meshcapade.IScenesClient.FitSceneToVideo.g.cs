#nullable enable

namespace Meshcapade
{
    public partial interface IScenesClient
    {
        /// <summary>
        /// Start scene fitting to video
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.AssetResponse> FitSceneToVideoAsync(
            global::System.Guid assetID,

            global::Meshcapade.FitToVideoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start scene fitting to video
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="lockFeet"></param>
        /// <param name="modelVersion"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.AssetResponse> FitSceneToVideoAsync(
            global::System.Guid assetID,
            bool? lockFeet = default,
            string? modelVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}