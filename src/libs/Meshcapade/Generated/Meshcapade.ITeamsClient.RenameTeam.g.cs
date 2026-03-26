#nullable enable

namespace Meshcapade
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Rename team
        /// </summary>
        /// <param name="teamID"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task RenameTeamAsync(
            string teamID,

            global::Meshcapade.TeamRenameRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rename team
        /// </summary>
        /// <param name="teamID"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task RenameTeamAsync(
            string teamID,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}