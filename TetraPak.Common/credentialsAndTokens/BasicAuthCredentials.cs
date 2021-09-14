using System;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace TetraPak
{
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
            var credentials = Encoding.UTF8.GetString(bytes).Split(new[] {SecretQualifier[0]});
            if (credentials.Length != 2)
                return Outcome<(string, string, string)>.Fail();

            var splitSecret = credentials[1].Split(NewSecretQualifier, StringSplitOptions.RemoveEmptyEntries);
            return Outcome<(string identity, string secret, string newSecret)>.Success(splitSecret.Length == 1
                ? (credentials[0], credentials[1], null)
                : (credentials[0], splitSecret[0], splitSecret[1]));
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
}