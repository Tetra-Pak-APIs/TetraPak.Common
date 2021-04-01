using System;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using TetraPak.Serialization;

namespace TetraPak.DynamicEntities
{
    [Serializable, JsonConverter(typeof(DynamicEntityJsonConverter<DynamicEntity>))]
    public abstract class DynamicIdentifiableEntity<TId> : DynamicEntity, IIdProvider<TId>, IUniquelyIdentifiable
    {
        public const string KeyId = "id";
        int _hashCode;
    
        [JsonPropertyName(KeyId)]
        public virtual TId Id
        {
            [DebuggerStepThrough]
            get => Get<TId>(KeyId);
            set
            {
                Set(KeyId, value);
                _hashCode = value.GetHashCode();
            }
        }

        public override int GetHashCode() => _hashCode; // todo consider splitting serializable entities from "fixed" entities 
        
        public object GetUniqueIdentity() => Id;

        public virtual TEntity WithId<TEntity>(TId id) where TEntity : DynamicIdentifiableEntity<TId>
        {
            Id = id;
            return (TEntity) this;
        }

        protected DynamicIdentifiableEntity()
        {
        }

        protected DynamicIdentifiableEntity(TId id)
        {
            init(id);
        }
       
        void init(TId id)
        {
            Id = id;
        }
    }
    
    
    public class DynamicEntityConverter : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            throw new NotImplementedException();
        }

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }

    
}