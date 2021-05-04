using System;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace TetraPak
{
    [DebuggerDisplay("{ToString()}")]

    public class ActorToken : Credentials, IStringValue
    {
        public string Value => Identity;

        /// <inheritdoc />
        public string StringValue => Value;

        public override string ToString() => StringValue;

        public override bool IsAssigned => !string.IsNullOrWhiteSpace(Identity);

        /// <summary>
        ///   Attempts parsing the value. 
        /// </summary>
        /// <param name="value">
        ///   The value to be parsed.
        /// </param>
        /// <param name="identity">
        ///   Passes back the identity (token).
        /// </param>
        /// <returns>
        ///   <c>true</c> if parsing was successful; otherwise <c>false</c>.
        /// </returns>
        protected virtual bool OnTryParse(string value, out string identity)
        {
            identity = value;
            return true;
        }

        /// <summary>
        ///   Converts the string representation of a token.
        ///   A return value indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="s">
        ///   A string containing a token to convert.
        /// </param>
        /// <param name="token">
        ///   When this method returns, contains the token equivalent of the value contained in <paramref name="s"/>,
        ///   if the conversion succeeded, or null if the conversion failed.
        ///   The conversion fails if the s parameter is null or Empty, or is not of the correct format.
        ///   This parameter is passed uninitialized; any value originally supplied in result will be overwritten.
        /// </param>
        /// <returns>
        ///   <c>true</c> if <paramref name="s"/> was converted successfully; otherwise, <c>false</c>.
        /// </returns>
        public static bool TryParse(string s, out ActorToken token)
        {
            if (BearerToken.TryParse(s, out var bearerToken))
            {
                token = bearerToken;
                return true;
            }

            token = null;
            if (string.IsNullOrWhiteSpace(s))
                return false;

            token = new ActorToken(s, false);
            return true;
        }
        
        bool tryParse(string value, out string identity) => OnTryParse(value, out identity);

        public static implicit operator string(ActorToken token) => token.ToString();
        
        public static implicit operator ActorToken(string stringValue) => new ActorToken(stringValue);

        [JsonConstructor]
        public ActorToken()
        {
        }

        protected ActorToken(string value, bool parse = true) : this()
        {
            if (!parse)
            {
                Identity = value;
                return;
            }
            if (tryParse(value, out var identity))
                Identity = identity;
        }
    }
}