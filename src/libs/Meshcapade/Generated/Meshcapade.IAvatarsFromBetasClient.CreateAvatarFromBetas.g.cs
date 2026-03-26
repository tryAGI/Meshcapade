#nullable enable

namespace Meshcapade
{
    public partial interface IAvatarsFromBetasClient
    {
        /// <summary>
        /// Create avatar from SMPL shape parameters
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.AssetResponse> CreateAvatarFromBetasAsync(

            global::Meshcapade.BetasAvatarRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create avatar from SMPL shape parameters
        /// </summary>
        /// <param name="betas">
        /// SMPL shape parameters
        /// </param>
        /// <param name="fps"></param>
        /// <param name="gender"></param>
        /// <param name="images"></param>
        /// <param name="inputMeasurements"></param>
        /// <param name="modelVersion"></param>
        /// <param name="name"></param>
        /// <param name="poseName"></param>
        /// <param name="poses"></param>
        /// <param name="predictedMeasurements"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.AssetResponse> CreateAvatarFromBetasAsync(
            global::System.Collections.Generic.IList<double>? betas = default,
            double? fps = default,
            global::Meshcapade.Gender? gender = default,
            global::Meshcapade.ImageTagLinks? images = default,
            global::System.Collections.Generic.Dictionary<string, double>? inputMeasurements = default,
            global::Meshcapade.ModelVersion? modelVersion = default,
            string? name = default,
            string? poseName = default,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? poses = default,
            global::System.Collections.Generic.Dictionary<string, double>? predictedMeasurements = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}