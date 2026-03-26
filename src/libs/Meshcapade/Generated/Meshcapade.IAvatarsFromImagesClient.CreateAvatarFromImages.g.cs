#nullable enable

namespace Meshcapade
{
    public partial interface IAvatarsFromImagesClient
    {
        /// <summary>
        /// Initiate avatar creation from images
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.AssetResponse> CreateAvatarFromImagesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}