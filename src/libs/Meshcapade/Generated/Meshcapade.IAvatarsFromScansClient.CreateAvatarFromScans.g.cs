#nullable enable

namespace Meshcapade
{
    public partial interface IAvatarsFromScansClient
    {
        /// <summary>
        /// Initiate avatar creation from 3D scans
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.AssetResponse> CreateAvatarFromScansAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}