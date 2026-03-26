#nullable enable

namespace Meshcapade
{
    public partial interface IAvatarsFromVideoClient
    {
        /// <summary>
        /// Initiate avatar creation from video
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.AssetResponse> CreateAvatarFromVideoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}