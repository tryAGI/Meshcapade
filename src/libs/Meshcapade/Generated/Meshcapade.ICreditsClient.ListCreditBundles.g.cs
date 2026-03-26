#nullable enable

namespace Meshcapade
{
    public partial interface ICreditsClient
    {
        /// <summary>
        /// List credit bundles
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ListCreditBundlesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}