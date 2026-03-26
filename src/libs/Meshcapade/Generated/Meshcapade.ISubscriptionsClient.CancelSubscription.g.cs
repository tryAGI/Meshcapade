#nullable enable

namespace Meshcapade
{
    public partial interface ISubscriptionsClient
    {
        /// <summary>
        /// Cancel subscription
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task CancelSubscriptionAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}