#nullable enable

namespace Meshcapade
{
    public partial interface ICreditsClient
    {
        /// <summary>
        /// Get checkout link for credit bundle
        /// </summary>
        /// <param name="bundleID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task GetCreditBundlePaymentLinkAsync(
            string bundleID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}