#nullable enable

namespace Meshcapade
{
    public partial interface IScenesClient
    {
        /// <summary>
        /// Create scene from video
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.AssetResponse> CreateSceneFromVideoAsync(

            global::Meshcapade.SceneFromVideoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create scene from video
        /// </summary>
        /// <param name="lockFeet"></param>
        /// <param name="maxPersonCount"></param>
        /// <param name="modelVersion"></param>
        /// <param name="sceneName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.AssetResponse> CreateSceneFromVideoAsync(
            bool? lockFeet = default,
            int? maxPersonCount = default,
            string? modelVersion = default,
            string? sceneName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}