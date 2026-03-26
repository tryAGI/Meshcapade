#nullable enable

namespace Meshcapade
{
    public partial interface IAvatarsClient
    {
        /// <summary>
        /// Export/download avatar
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.AssetResponse> ExportAvatarAsync(
            global::System.Guid assetID,

            global::Meshcapade.ExportRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export/download avatar
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="format"></param>
        /// <param name="pose"></param>
        /// <param name="compatibilityMode"></param>
        /// <param name="animation"></param>
        /// <param name="filename"></param>
        /// <param name="avatarSceneIndex"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.AssetResponse> ExportAvatarAsync(
            global::System.Guid assetID,
            global::Meshcapade.ExportFormat format,
            global::Meshcapade.ExportPose? pose = default,
            global::Meshcapade.CompatibilityMode? compatibilityMode = default,
            string? animation = default,
            string? filename = default,
            int? avatarSceneIndex = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}