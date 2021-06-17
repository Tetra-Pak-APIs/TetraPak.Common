using System;
using System.Text.Json.Serialization;
using TetraPak.DynamicEntities;
using TetraPak.Serialization;

namespace TetraPak
{
    [JsonConverter(typeof(DynamicEntityJsonConverter<Credentials>))]
    public class Credentials : DynamicIdentifiableEntity<string>, IDisposable
    {
        [Newtonsoft.Json.JsonIgnore]
        [JsonIgnore]
        public string Identity
        {
            get => Id;
            set => Id = value;
        }

        [JsonPropertyName("secret")]
        public string Secret
        {
            get => GetValue<string>("secret");
            set => SetValue("secret", value);
        }

        [JsonPropertyName("newSecret")]
        public string NewSecret
        {
            get => GetValue<string>("newSecret");
            set => SetValue("newSecret", value);
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