using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using TetraPak.Logging;
using TetraPak.Serialization;

namespace TetraPak.DynamicEntities
{
    [Serializable]
    [JsonConverter(typeof(DynamicEntityJsonConverter<DynamicEntity>))]
    public partial class DynamicEntity : IDictionary<string,object> 
    {
        IDictionary<string, object> _dictionary = new Dictionary<string, object>();

#if DEBUG
        static int s_counter;

        [JsonIgnore]
        public int DebugInstanceId { get; } = ++s_counter;
#endif

        protected Dictionary<string, object> GetDictionary() => (Dictionary<string, object>) _dictionary;
        
        protected void SetDictionary(IDictionary<string, object> dictionary) => _dictionary = dictionary;
        
        [DebuggerStepThrough]
        public virtual TValue Get<TValue>(string key, TValue useDefault = default)
        {
            if (!_dictionary.TryGetValue(key, out var obj)) 
                return useDefault;
        
            if (obj is TValue castValue)
                return castValue;

            if (obj is null)
                return typeof(TValue).IsGenericBase(typeof(Nullable<>)) 
                    ? TypeHelper.GetDefaultValue<TValue>() 
                    : useDefault;
        
            throw new Exception($"{key} cannot be cast to {typeof(TValue)} (was {obj.GetType()})");
        }

        protected virtual Outcome<TValue> OnTryGetPropertyValue<TValue>(string key)
        {
            var property = GetPropertyWithJsonPropertyName(key);
            if (property is null || !property.CanRead)
                return Outcome<TValue>.Fail();

            var value = property.GetValue(this);
            if (!(value is TValue castValue))
                return Outcome<TValue>.Fail(new InvalidCastException($"{key} cannot be cast to {typeof(TValue)}"));
            
            return Outcome<TValue>.Success(castValue);
        }

        protected virtual Outcome<TValue> OnTrySetPropertyValue<TValue>(string key, TValue value)
        {
            var property = GetPropertyWithJsonPropertyName(key);
            if (property is null || !property.CanWrite)
                return Outcome<TValue>.Fail();

            try
            {
                property.SetValue(this, value);
                var o = OnTryGetPropertyValue<TValue>(key);
                return o ? o : Outcome<TValue>.Fail();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public PropertyInfo GetPropertyWithJsonPropertyName(string key)
        {
            PropertyInfo namedCandidate = null;
            var propertyInfo = GetType().GetProperties()
                .FirstOrDefault(p =>
                {
                    var attr = p.GetCustomAttribute<JsonPropertyNameAttribute>();
                    if (attr?.Name.Equals(key) ?? false)
                        return true;

                    if (p.Name.ToLowerInitial().Equals(key))
                        namedCandidate = p;

                    return false;
                });
            return propertyInfo ?? namedCandidate;
        }

        public virtual void Set<TValue>(string key, TValue value) => _dictionary[key] = convertDeserializedArray(key, value);

        protected void SetRaw(string key, object value) => _dictionary[key] = convertDeserializedArray(key, value);

        protected object GetRaw(string key) => _dictionary.TryGetValue(key, out var value) ? value : null;

        object convertDeserializedArray(string key, object value)
        {
            if (!(value is Array array))
                return value;
            
            var property = GetPropertyWithJsonPropertyName(key);
            if (property is null)
                return value;

            if (property.PropertyType.IsGenericBase(typeof(IEnumerable<>)))
            {
                var itemType = property.PropertyType.GenericTypeArguments[0];
                var listType = typeof(List<>).MakeGenericType(itemType);
                var list = (IList) Activator.CreateInstance(listType);
                foreach (var item in array)
                {
                    list.Add(item);
                }

                return list;
            }

            return value;
        }

        public DynamicEntity ApplyFrom(object source) => onApplyFrom(source);

        DynamicEntity onApplyFrom(object source)
        {
            var assigned = new HashSet<string>();
            if (source is IDictionary<string, object> dictionary)
                onApplyFromDictionary(dictionary, assigned);

            var sourceProps = source.GetType().GetProperties().Where(pi => pi.CanRead).ToArray();
            for (var i = 0; i < sourceProps.Length; i++)
            {
                var targetProp = GetType().GetProperty(sourceProps[i].Name);
                if (targetProp is null || !targetProp.CanWrite || targetProp.IsIndexer() || assigned.Contains(targetProp.Name))
                    continue;

                targetProp.SetValue(this, sourceProps[i].GetValue(source));
            }

            return this;
        }

        void onApplyFromDictionary(IDictionary<string, object> source, ISet<string> assigned)
        {
            var isDynamicEntity = source is DynamicEntity;
            foreach (var (key, value) in source)
            {
                Set(key, value);
                if (isDynamicEntity)
                    assigned.Add(key);
            }
        }
        
        // todo Make into extension method
        public static TEntity FromJson<TEntity>(string json) where TEntity : DynamicEntity
        {
            var entity = JsonSerializer.Deserialize<TEntity>(json);
            return entity;
        }

        public static object FromJson(string json, Type returnType)
        {
            if (!typeof(DynamicEntity).IsAssignableFrom(returnType))
                throw new InvalidCastException($"Cannot deserialize type {returnType}");
            
            return JsonSerializer.Deserialize(json, returnType);
        }

        public string ToJson(bool indented = false, IEnumerable<string> ignoreKeys = null)
        {
            if (ignoreKeys is {})
            {
                removeKeys(ignoreKeys); 
            }
            var options = new JsonSerializerOptions { WriteIndented = indented  };
            return JsonSerializer.Serialize(this, options);  
        }

        void removeKeys(IEnumerable<string> keys)
        {
            foreach (var key in keys)
            {
                if (_dictionary.ContainsKey(key))
                {
                    _dictionary.Remove(key);
                }
            }
        }

        void pruneKeys(IEnumerable<string> protectedKeys)
        {
            var hash = new HashSet<string>(protectedKeys);
            var keys = _dictionary.Keys.ToArray();
            // ReSharper disable once ForCanBeConvertedToForeach
            for (var i = 0; i < keys.Length; i++)
            {
                var key = keys[i];
                if (hash.Contains(key))
                    continue;
                
                _dictionary.Remove(key);
            }
        }

        public virtual TEntity Clone<TEntity>(ILog log = null) where TEntity : DynamicEntity
        {
            var json = ToJson(true);
            try
            {
                var entity = (TEntity) FromJson<TEntity>(json).ObjectifyJsonElements();
                return entity;
            }
            catch (Exception ex)
            {
                if (log is null)
                    throw;
                
                using (log = log.Section(LogRank.Debug, $"Error while cloning {this} ({typeof(TEntity)}):"))
                {
                    log?.Error(ex, "Dumping troublesome JSON ...");
                    log?.Debug(json);
                }

                throw;
            }
        }

        public object ObjectifyJsonElements() 
        {
            if (!_dictionary.Any(pair => pair.Value is JsonElement))
                return this;

            var target = new Dictionary<string, object>();
            foreach (var pair in this)
            {
                var property = GetPropertyWithJsonPropertyName(pair.Key);
                if (!(pair.Value is JsonElement jsonElement) || property is null)
                {
                    target[pair.Key] = pair.Value;
                    continue;
                }

                var value = jsonElement.ToObject(property.PropertyType);
                target[pair.Key] = value;
                if (value is DynamicEntity entity)
                {
                    entity.ObjectifyJsonElements();
                }
                else if (value.IsCollectionOf<DynamicEntity>(out var items))
                {
                    foreach (DynamicEntity entityItem in items)
                    {
                        entityItem.ObjectifyJsonElements();
                    }
                }
            }

            _dictionary = target;
            return this;
        }
        
        public virtual object Clone(Type returnType)
        {
            return FromJson(ToJson(), returnType);
        }
    }
}