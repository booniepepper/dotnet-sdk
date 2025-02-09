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


using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace OpenFga.Sdk.Model {
    /// <summary>
    /// Defines NotFoundErrorCode
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter<NotFoundErrorCode>))]
    public enum NotFoundErrorCode {
        /// <summary>
        /// Enum NoNotFoundError for value: no_not_found_error
        /// </summary>
        [EnumMember(Value = "no_not_found_error")]
        NoNotFoundError = 1,

        /// <summary>
        /// Enum UndefinedEndpoint for value: undefined_endpoint
        /// </summary>
        [EnumMember(Value = "undefined_endpoint")]
        UndefinedEndpoint = 2,

        /// <summary>
        /// Enum StoreIdNotFound for value: store_id_not_found
        /// </summary>
        [EnumMember(Value = "store_id_not_found")]
        StoreIdNotFound = 3,

        /// <summary>
        /// Enum Unimplemented for value: unimplemented
        /// </summary>
        [EnumMember(Value = "unimplemented")]
        Unimplemented = 4

    }

}