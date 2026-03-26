
#nullable enable

namespace Meshcapade
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MeasurementAvatarRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Meshcapade.JsonConverters.GenderJsonConverter))]
        public global::Meshcapade.Gender? Gender { get; set; }

        /// <summary>
        /// Key-value pairs of measurement names to values
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("measurements")]
        public global::System.Collections.Generic.Dictionary<string, double>? Measurements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelVersion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Meshcapade.JsonConverters.ModelVersionJsonConverter))]
        public global::Meshcapade.ModelVersion? ModelVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementAvatarRequest" /> class.
        /// </summary>
        /// <param name="gender"></param>
        /// <param name="measurements">
        /// Key-value pairs of measurement names to values
        /// </param>
        /// <param name="modelVersion"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MeasurementAvatarRequest(
            global::Meshcapade.Gender? gender,
            global::System.Collections.Generic.Dictionary<string, double>? measurements,
            global::Meshcapade.ModelVersion? modelVersion,
            string? name)
        {
            this.Gender = gender;
            this.Measurements = measurements;
            this.ModelVersion = modelVersion;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementAvatarRequest" /> class.
        /// </summary>
        public MeasurementAvatarRequest()
        {
        }
    }
}