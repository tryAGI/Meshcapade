#nullable enable

namespace Meshcapade
{
    public partial interface IMotionsClient
    {
        /// <summary>
        /// Blend two or more motions
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.AssetResponse> BlendMotionsAsync(

            global::Meshcapade.MotionBlendRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Blend two or more motions
        /// </summary>
        /// <param name="avatarName"></param>
        /// <param name="gender"></param>
        /// <param name="motions"></param>
        /// <param name="shapeParameters"></param>
        /// <param name="sourceAvatarID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Meshcapade.AssetResponse> BlendMotionsAsync(
            string? avatarName = default,
            string? gender = default,
            global::System.Collections.Generic.IList<global::Meshcapade.MotionBlendMotion>? motions = default,
            global::System.Collections.Generic.IList<double>? shapeParameters = default,
            string? sourceAvatarID = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}