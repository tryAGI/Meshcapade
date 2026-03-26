#nullable enable

namespace Meshcapade
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Generate a random asset name
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.RandomNameResponse> GetRandomNameAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}