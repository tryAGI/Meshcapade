#nullable enable

namespace Meshcapade
{
    public partial interface ISubscriptionsClient
    {
        /// <summary>
        /// Get subscription checkout link
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task GetSubscriptionPaymentLinkAsync(

            global::Meshcapade.SubscriptionPaymentLinkRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get subscription checkout link
        /// </summary>
        /// <param name="planId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task GetSubscriptionPaymentLinkAsync(
            string? planId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}