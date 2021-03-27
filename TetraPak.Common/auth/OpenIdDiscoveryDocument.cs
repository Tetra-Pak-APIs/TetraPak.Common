﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace tetrapak.auth
{
    public class OpenIdDiscoveryDocument
    {
        /// <summary>
        ///   The default path for a well known open id discovery document (a.k.a 'metadata document')
        /// </summary>
        public const string DefaultPath = "/.well-known/openid-configuration";
        public const string DefaultAuthorizationPath = "/oauth2/authorize";
        public const string DefaultTokenPath = "/oauth2/token";
        public const string DefaultUserInfoPath = "/idp/userinfo";
        public const string DefaultJwksPath = "/jwks";
        
        [JsonPropertyName("issuer")]
        public string Issuer { get; set; }

        [JsonPropertyName("authorization_endpoint")]
        public string AuthorizationEndpoint { get; set; }

        [JsonPropertyName("token_endpoint")]
        public string TokenEndpoint { get; set; }

        [JsonPropertyName("userinfo_endpoint")]
        public string UserInfoEndpoint { get; set; }

        [JsonPropertyName("jwks_uri")]
        public string JwksUri { get; set; }

        [JsonPropertyName("response_types_supported")]
        public IEnumerable<string> ResponseTypesSupported { get; set; }

        [JsonPropertyName("subject_types_supported")]
        public IEnumerable<string> SubjectTypesSupported { get; set; }

        [JsonPropertyName("scopes_supported")]
        public IEnumerable<string> ScopesSupported { get; set; }

        [JsonPropertyName("grant_types_supported")]
        public IEnumerable<string> GrantTypesSupported { get; set; }

        [JsonPropertyName("id_token_signing_alg_values_supported")]
        public IEnumerable<string> IdTokenSigningAlgValuesSupported { get; set; }

        public static OpenIdDiscoveryDocument GetDefault(
            string issuer,
            string supportedResponseType = "code", 
            string supportedSubjectTypes = "openid, profile, email, groups, domain", 
            string supportedGrantTypes = "authorization_code, refresh_token, urn:ietf:params:oauth:grant-type:token-exchange", 
            string supportedIdTokenSigningAlgValues = "RS256")
        {
            var document = new OpenIdDiscoveryDocument
            {
                Issuer = issuer,
                AuthorizationEndpoint = $"{issuer}{DefaultAuthorizationPath}",
                TokenEndpoint = $"{issuer}{DefaultTokenPath}",
                UserInfoEndpoint = $"{issuer}{DefaultUserInfoPath}",
                JwksUri = $"{issuer}{DefaultJwksPath}",
            };
            if (!string.IsNullOrWhiteSpace(supportedResponseType))
            {
                document.ResponseTypesSupported = new MultiStringValue(supportedResponseType).Items;
            }
            if (!string.IsNullOrWhiteSpace(supportedSubjectTypes))
            {
                document.SubjectTypesSupported = new MultiStringValue(supportedSubjectTypes).Items;
            }
            if (!string.IsNullOrWhiteSpace(supportedGrantTypes))
            {
                document.GrantTypesSupported = new MultiStringValue(supportedGrantTypes).Items;
            }
            if (!string.IsNullOrWhiteSpace(supportedIdTokenSigningAlgValues))
            {
                document.IdTokenSigningAlgValuesSupported = new MultiStringValue(supportedIdTokenSigningAlgValues).Items;
            }

            return document;
        }

        public static async Task<Outcome<OpenIdDiscoveryDocument>> LoadAsync(
            string url, 
            ILogger<OpenIdDiscoveryDocument> logger = null)
        {
            try
            {
                using var client = new HttpClient();
                var response = await client.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    logger?.LogWarning("Failed to download discovery document. Status: {StatusCode} {Phrase}", 
                        (int) response.StatusCode,
                        response.ReasonPhrase);
                    return Outcome<OpenIdDiscoveryDocument>.Fail();
                }

                var stream = await response.Content.ReadAsStreamAsync();
                var discoveryDocument = await JsonSerializer.DeserializeAsync<OpenIdDiscoveryDocument>(stream);
                logger?.LogDebug("Successfully downloaded discovery document from {Url}", url);
                return Outcome<OpenIdDiscoveryDocument>.Success(discoveryDocument);
            }
            catch (Exception ex)
            {
                logger?.LogError(ex, "Failed to download discovery document");
                return Outcome<OpenIdDiscoveryDocument>.Fail(new Exception("Failed to download discovery document", ex));
            }
        }
    }
}