#nullable enable

namespace Meshcapade
{
    public partial interface IAvatarsFromMeasurementsClient
    {
        /// <summary>
        /// Create avatar from body measurements
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.AssetResponse> CreateAvatarFromMeasurementsAsync(

            global::Meshcapade.MeasurementAvatarRequest request,
            global::Meshcapade.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create avatar from body measurements
        /// </summary>
        /// <param name="gender"></param>
        /// <param name="measurements">
        /// Key-value pairs of measurement names to values
        /// </param>
        /// <param name="modelVersion"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.AssetResponse> CreateAvatarFromMeasurementsAsync(
            global::Meshcapade.Gender? gender = default,
            global::System.Collections.Generic.Dictionary<string, double>? measurements = default,
            global::Meshcapade.ModelVersion? modelVersion = default,
            string? name = default,
            global::Meshcapade.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}