using System;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using tetrapak.dynamicEntities;
using tetrapak.serialization;

namespace tetrapak
{
    [Newtonsoft.Json.JsonConverter(typeof(DynamicEntityJsonConverter<Credentials>))]
    public class Credentials : DynamicIdentifiableEntity<string>, IDisposable
    {
        [Newtonsoft.Json.JsonIgnore]
        public string Identity
        {
            get => Id;
            set => Id = value;
        }

        [JsonPropertyName("secret")]
        public string Secret
        {
            get => Get<string>("secret");
            set => Set("secret", value);
        }

        [JsonPropertyName("newSecret")]
        public string NewSecret
        {
            get => Get<string>("newSecret");
            set => Set("newSecret", value);
        }

        public virtual bool IsAssigned => !string.IsNullOrWhiteSpace(Identity) && !string.IsNullOrWhiteSpace(Secret);

        public Credentials()
        {
        }

        public Credentials(string identity, string secret, string newSecret = null) : base(identity)
        {
            Secret = secret;
            NewSecret = newSecret;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

    public class BasicAuthCredentials : Credentials
    {
        const string SecretQualifier = ":";
        const string NewSecretQualifier = " ; ";
        const string BasicAuthQualifier = "Basic ";

        public string Encoded => encode();

        string encode()
        {
            var bytes = string.IsNullOrWhiteSpace(NewSecret)
                ? Encoding.ASCII.GetBytes($"{Identity}{SecretQualifier}{Secret}")
                : Encoding.ASCII.GetBytes($"{Identity}{SecretQualifier}{Secret}{NewSecretQualifier}{NewSecret}");

            return Convert.ToBase64String(bytes);
        }

        static Outcome<(string identity, string secret, string newSecret)> decode(string encoded)
        {

            if (encoded.StartsWith(BasicAuthQualifier, StringComparison.OrdinalIgnoreCase))
            {
                encoded = encoded.Substring(BasicAuthQualifier.Length);
            }

            var bytes = Convert.FromBase64String(encoded);
            var creds = Encoding.UTF8.GetString(bytes).Split(new[] {SecretQualifier[0]});
            if (creds.Length != 2)
                return Outcome<(string, string, string)>.Fail();

            var splitSecret = creds[1].Split(NewSecretQualifier, StringSplitOptions.RemoveEmptyEntries);
            return Outcome<(string identity, string secret, string newSecret)>.Success(splitSecret.Length == 1
                ? (creds[0], creds[1], null)
                : (creds[0], splitSecret[0], splitSecret[1]));
        }

        public static BasicAuthCredentials Parse(string stringValue)
        {
            var outcome = decode(stringValue);
            return !outcome 
                ? null 
                : new BasicAuthCredentials(outcome.Value.identity, outcome.Value.secret);
        }

        public static bool TryParse(HttpRequest request, out BasicAuthCredentials credentials)
        {

            var authHeader = AuthenticationHeaderValue.Parse(request.Headers["Authorization"]);
            var bytes = Convert.FromBase64String(authHeader.Parameter);
            credentials = Parse(Encoding.UTF8.GetString(bytes));
            return credentials is {};
        }

        public BasicAuthCredentials(string encoded)
        {
            if (string.IsNullOrWhiteSpace(encoded))
            {
                Identity = "";
                Secret = "";
                return;
            }

            var outcome = decode(encoded);
            if (!outcome)
                throw new FormatException($"Invalid basic auth: '{encoded}'");

            Identity = outcome.Value.identity;
            Secret = outcome.Value.secret;
            NewSecret = outcome.Value.newSecret;
        }

        public BasicAuthCredentials(string identity, string secret, string newSecret = null)
            : base(identity, secret, newSecret)
        {
        }
    }
    
    public static class CredentialsHelper
    {
        public static AuthenticationHeaderValue ToAuthenticationHeaderValue(this BasicAuthCredentials credentials)
        {
            return new AuthenticationHeaderValue("Basic", credentials.Encoded);
        }
    }

    public abstract class ActorToken : Credentials
    {
        public string Value => Identity;

        public override bool IsAssigned => !string.IsNullOrWhiteSpace(Identity);

        protected abstract bool OnTryParse(string value, out string identity);
        
        bool tryParse(string value, out string identity) => OnTryParse(value, out identity);

        public ActorToken()
        {
        }
        
        public ActorToken(string value)
        {
            if (tryParse(value, out var identity))
                Identity = identity;
        }
    }

    public class BearerToken : ActorToken
    {
        const string BearerQualifier = "Bearer ";

        public static BearerToken Parse(string value)
        {
            return tryParse(value, out var identity) 
                ? new BearerToken { Identity = identity } 
                : null;
        }

        protected override bool OnTryParse(string value, out string identity) => tryParse(value, out identity);

        static bool tryParse(string value, out string identity)
        {
            identity = null;
            if (string.IsNullOrWhiteSpace(value))
                return false;

            value = value.Trim();
            if (!value.StartsWith(BearerQualifier))
                return false;

            identity = value.Substring(BearerQualifier.Length);
            return true;
        }

        BearerToken()
        {
        }

        public BearerToken(string value) : base(value)
        {
        }
    }
}