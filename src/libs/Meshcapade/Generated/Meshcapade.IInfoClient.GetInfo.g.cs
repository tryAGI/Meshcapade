#nullable enable

namespace Meshcapade
{
    public partial interface IInfoClient
    {
        /// <summary>
        /// Get API info
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.InfoResponse> GetInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}