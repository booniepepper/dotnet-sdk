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


namespace OpenFga.Sdk.Client.Model;

/// <summary>
///     ClientReadOptions - Client Options for Read
/// </summary>
public interface IClientReadOptions : ClientRequestOptions, ClientPaginationOptions {
}

/// <inheritdoc />
public class ClientReadOptions : IClientReadOptions {

    /// <inheritdoc />
    public int? PageSize { get; set; }

    /// <inheritdoc />
    public string? ContinuationToken { get; set; }
}