
#nullable enable

namespace Meshcapade
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssetRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exported_mesh")]
        public global::Meshcapade.AssetRelationshipsExportedMesh? ExportedMesh { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetRelationships" /> class.
        /// </summary>
        /// <param name="exportedMesh"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetRelationships(
            global::Meshcapade.AssetRelationshipsExportedMesh? exportedMesh)
        {
            this.ExportedMesh = exportedMesh;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetRelationships" /> class.
        /// </summary>
        public AssetRelationships()
        {
        }
    }
}