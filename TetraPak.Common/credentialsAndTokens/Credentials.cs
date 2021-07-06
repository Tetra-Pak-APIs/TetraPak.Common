using System;
using System.Text.Json.Serialization;
using TetraPak.DynamicEntities;
using TetraPak.Serialization;

namespace TetraPak
{
    [JsonConverter(typeof(DynamicEntityJsonConverter<Credentials>))]
    public class Credentials : DynamicIdentifiableEntity<string>, IDisposable
    {
        const string KeySecret = "secret";
        const string KeyNewSecret = "newSecret";
        
        [Newtonsoft.Json.JsonIgnore]
        [JsonIgnore]
        public string Identity
        {
            get => Id;
            set => Id = value;
        }

        [JsonPropertyName(KeySecret)]
        public string Secret
        {
            get => GetValue<string>(KeySecret);
            set => SetValue(KeySecret, value);
        }

        [JsonPropertyName(KeyNewSecret)]
        public string NewSecret
        {
            get => GetValue<string>(KeyNewSecret);
            set => SetValue(KeyNewSecret, value);
        }

        /// <summary>
        ///   Clones the entity without any secrets, to support scenarios where secrets are not necessary.
        /// </summary>
        /// <returns>
        ///   A cloned <see cref="Credentials"/>.
        /// </returns>
        public Credentials CloneWithoutSecrets()
        {
            var clone = Clone<Credentials>();
            clone.SetValue<string>(KeySecret, null);
            clone.SetValue<string>(KeyNewSecret, null);
            return clone;
        }

        public virtual bool IsAssigned => !string.IsNullOrWhiteSpace(Identity) && !string.IsNullOrWhiteSpace(Secret);

#if NET5_0_OR_GREATER            
        [JsonConstructor]
#endif
        public Credentials()
        {
        }

        public Credentials(string identity, string secret, string newSecret = null) 
        : base(identity)
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
}