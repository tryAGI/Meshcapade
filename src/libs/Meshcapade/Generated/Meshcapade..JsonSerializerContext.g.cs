
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Meshcapade
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Meshcapade.JsonConverters.GenderJsonConverter),
            typeof(global::Meshcapade.JsonConverters.GenderNullableJsonConverter),
            typeof(global::Meshcapade.JsonConverters.ModelVersionJsonConverter),
            typeof(global::Meshcapade.JsonConverters.ModelVersionNullableJsonConverter),
            typeof(global::Meshcapade.JsonConverters.AssetStateJsonConverter),
            typeof(global::Meshcapade.JsonConverters.AssetStateNullableJsonConverter),
            typeof(global::Meshcapade.JsonConverters.AssetTypeJsonConverter),
            typeof(global::Meshcapade.JsonConverters.AssetTypeNullableJsonConverter),
            typeof(global::Meshcapade.JsonConverters.BuildStateJsonConverter),
            typeof(global::Meshcapade.JsonConverters.BuildStateNullableJsonConverter),
            typeof(global::Meshcapade.JsonConverters.BuildMethodJsonConverter),
            typeof(global::Meshcapade.JsonConverters.BuildMethodNullableJsonConverter),
            typeof(global::Meshcapade.JsonConverters.FileSourceJsonConverter),
            typeof(global::Meshcapade.JsonConverters.FileSourceNullableJsonConverter),
            typeof(global::Meshcapade.JsonConverters.ExportFormatJsonConverter),
            typeof(global::Meshcapade.JsonConverters.ExportFormatNullableJsonConverter),
            typeof(global::Meshcapade.JsonConverters.ExportPoseJsonConverter),
            typeof(global::Meshcapade.JsonConverters.ExportPoseNullableJsonConverter),
            typeof(global::Meshcapade.JsonConverters.CompatibilityModeJsonConverter),
            typeof(global::Meshcapade.JsonConverters.CompatibilityModeNullableJsonConverter),
            typeof(global::Meshcapade.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.Gender))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.ModelVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.AssetState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.AssetType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.BuildState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.BuildMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.FileSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.ExportFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.ExportPose))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.CompatibilityMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.URLResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.MeshMeasurements))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.BodyShape))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.AvatarMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.AvatarAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.RelationshipItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.AssetRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.AssetRelationshipsExportedMesh))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Meshcapade.RelationshipItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.AssetLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.AssetResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.AssetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.AssetListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Meshcapade.AssetResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.ErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Meshcapade.ErrorDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.ExportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.PatchAvatarRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.MeasurementAvatarRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.ImageTagLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.BetasAvatarRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.CreateFromSMPLRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.FitToImagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.FitToScansRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.FitToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.SceneFromVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.MotionBlendMotion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.MotionBlendRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Meshcapade.MotionBlendMotion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.SearchMotionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.TeamCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.TeamRenameRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.TeamInviteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.SubscriptionPaymentLinkRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.InfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.HealthCheckResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Meshcapade.RandomNameResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Meshcapade.RelationshipItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Meshcapade.AssetResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Meshcapade.ErrorDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Meshcapade.MotionBlendMotion>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}