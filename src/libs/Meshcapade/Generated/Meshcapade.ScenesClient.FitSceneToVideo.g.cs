
#nullable enable

namespace Meshcapade
{
    public partial class ScenesClient
    {


        private static readonly global::Meshcapade.EndPointSecurityRequirement s_FitSceneToVideoSecurityRequirement0 =
            new global::Meshcapade.EndPointSecurityRequirement
            {
                Authorizations = new global::Meshcapade.EndPointAuthorizationRequirement[]
                {                    new global::Meshcapade.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Meshcapade.EndPointSecurityRequirement[] s_FitSceneToVideoSecurityRequirements =
            new global::Meshcapade.EndPointSecurityRequirement[]
            {                s_FitSceneToVideoSecurityRequirement0,
            };
        partial void PrepareFitSceneToVideoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid assetID,
            global::Meshcapade.FitToVideoRequest request);
        partial void PrepareFitSceneToVideoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid assetID,
            global::Meshcapade.FitToVideoRequest request);
        partial void ProcessFitSceneToVideoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessFitSceneToVideoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Start scene fitting to video
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Meshcapade.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Meshcapade.AssetResponse> FitSceneToVideoAsync(
            global::System.Guid assetID,

            global::Meshcapade.FitToVideoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareFitSceneToVideoArguments(
                httpClient: HttpClient,
                assetID: ref assetID,
                request: request);


            var __authorizations = global::Meshcapade.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_FitSceneToVideoSecurityRequirements,
                operationName: "FitSceneToVideoAsync");

            var __pathBuilder = new global::Meshcapade.PathBuilder(
                path: $"/scenes/{assetID}/fit-to-video",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareFitSceneToVideoRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                assetID: assetID,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessFitSceneToVideoResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessFitSceneToVideoResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Meshcapade.AssetResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Meshcapade.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Meshcapade.AssetResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Meshcapade.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Start scene fitting to video
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="lockFeet"></param>
        /// <param name="modelVersion"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Meshcapade.AssetResponse> FitSceneToVideoAsync(
            global::System.Guid assetID,
            bool? lockFeet = default,
            string? modelVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Meshcapade.FitToVideoRequest
            {
                LockFeet = lockFeet,
                ModelVersion = modelVersion,
            };

            return await FitSceneToVideoAsync(
                assetID: assetID,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}