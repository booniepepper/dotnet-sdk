//
// OpenFGA/.NET SDK for OpenFGA
//
// API version: 0.1
// Website: https://openfga.dev
// Documentation: https://openfga.dev/docs
// Support: https://discord.gg/8naAwJfWN6
// License: [Apache-2.0](https://github.com/openfga/dotnet-sdk/blob/main/LICENSE)
//
// NOTE: This file was auto generated. DO NOT EDIT.
//


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenFga.Sdk.Model {
    /// <summary>
    /// ListObjectsResponse
    /// </summary>
    [DataContract(Name = "ListObjectsResponse")]
    public partial class ListObjectsResponse : IEquatable<ListObjectsResponse>, IValidatableObject {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListObjectsResponse" /> class.
        /// </summary>
        [JsonConstructor]
        public ListObjectsResponse() {
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListObjectsResponse" /> class.
        /// </summary>
        /// <param name="objects">objects.</param>
        public ListObjectsResponse(List<string> objects = default(List<string>)) {
            this.Objects = objects;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Objects
        /// </summary>
        [DataMember(Name = "objects", EmitDefaultValue = false)]
        [JsonPropertyName("objects")]
        public List<string>? Objects { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }


        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson() {
            return JsonSerializer.Serialize(this);
        }

        /// <summary>
        /// Builds a ListObjectsResponse from the JSON string presentation of the object
        /// </summary>
        /// <returns>ListObjectsResponse</returns>
        public static ListObjectsResponse FromJson(string jsonString) {
            return JsonSerializer.Deserialize<ListObjectsResponse>(jsonString) ?? throw new InvalidOperationException();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input) {
            return this.Equals(input as ListObjectsResponse);
        }

        /// <summary>
        /// Returns true if ListObjectsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListObjectsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListObjectsResponse input) {
            if (input == null) {
                return false;
            }
            return
                (
                    this.Objects == input.Objects ||
                    this.Objects != null &&
                    input.Objects != null &&
                    this.Objects.SequenceEqual(input.Objects)
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode() {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 9661;
                if (this.Objects != null) {
                    hashCode = (hashCode * 9923) + this.Objects.GetHashCode();
                }
                if (this.AdditionalProperties != null) {
                    hashCode = (hashCode * 9923) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) {
            yield break;
        }

    }

}