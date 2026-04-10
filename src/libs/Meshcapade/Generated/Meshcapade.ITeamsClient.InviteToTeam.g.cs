#nullable enable

namespace Meshcapade
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Invite user to team
        /// </summary>
        /// <param name="teamID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task InviteToTeamAsync(
            string teamID,

            global::Meshcapade.TeamInviteRequest request,
            global::Meshcapade.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invite user to team
        /// </summary>
        /// <param name="teamID"></param>
        /// <param name="email"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task InviteToTeamAsync(
            string teamID,
            string? email = default,
            global::Meshcapade.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}