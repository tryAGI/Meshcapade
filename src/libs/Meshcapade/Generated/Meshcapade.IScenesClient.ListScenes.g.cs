#nullable enable

namespace Meshcapade
{
    public partial interface IScenesClient
    {
        /// <summary>
        /// List all scenes
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.AssetListResponse> ListScenesAsync(
            int? limit = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}