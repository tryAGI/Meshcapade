#nullable enable

namespace Meshcapade
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Get current user info
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}