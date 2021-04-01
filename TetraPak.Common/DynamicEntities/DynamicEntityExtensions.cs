using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;
using TetraPak.Serialization;

namespace TetraPak.DynamicEntities
{
    public static class DynamicEntityExtensions
    {
        public static TEntity CloneFrom<TEntity>(
            this TEntity self, 
            DynamicEntity source, 
            bool overwrite = false, 
            bool recursive = false, 
            params DynamicPath[] ignore) where TEntity : DynamicEntity
        {
            var path = new DynamicPath();
            cloneFrom(self, source, overwrite, recursive, path, ignore);
            return self;
        }

        static void cloneFrom(DynamicEntity self, DynamicEntity source, bool overwrite, bool recursive, DynamicPath path, DynamicPath[] ignore)
        {
            var pairs = compileKeys(source).ToArray(); 
            foreach (var pair in pairs)
            {
                if (self.ContainsKey(pair.Key) && !overwrite)
                    continue;

                path.Push(pair.Key);
                if (ignore.Any(i => i.Equals(path)))
                    goto next;

                if (!tryGetValue(pair, out var value))
                    continue;

                if (value.IsCollectionOf<DynamicEntity>(out var items) && recursive)
                {
                    value = cloneDynamicBaseEntityCollection(pair.Key, items);
                    self.Set(pair.Key, value);
                    goto next;
                }
                    
                if (!(value is DynamicEntity entity))
                {
                    self.Set(pair.Key, value);
                    goto next;
                }

                if (!recursive)
                    goto next;

                value = cloneDynamicEntity(entity, true, path, ignore);
                self.Set(pair.Key, value);
                
                next:
                path.Pop();
            }
            
            bool tryGetValue(KeyValuePair<string,object> kvp, out object value)
            {
                value = null;
                if (kvp.Value is PropertyInfo property)
                {
                    if (!property.CanRead)
                        return false;
                    
                    value = property.GetValue(source, new object[0]);
                    return true;
                }
                
                value = kvp.Value;
                return true;
            }

            IEnumerable cloneDynamicBaseEntityCollection(string key, IEnumerable items)
            {
                Type type;
                var prop = source.GetPropertyWithJsonPropertyName(key);
                if (prop is null)
                {
                    type = source[key].GetType();
                }
                else
                {
                    var implementedAs = prop.GetCustomAttribute<ImplementedAsAttribute>();
                    type = implementedAs != null ? implementedAs.Type : typeof(List<DynamicEntity>);
                }

                IList list;
                var isArray = false;
                if (type.IsAssignableFrom(typeof(IList)))
                    list = (IList) Activator.CreateInstance(type);
                else if (typeof(Array).IsAssignableFrom(type))
                {
                    isArray = true;
                    list = new List<DynamicEntity>();
                }
                else
                    throw new NotImplementedException($"Cannot clone collection of type {type}");
                
                foreach (DynamicEntity item in items)
                {
                    var cloned = item.Clone(item.GetType());
                    list.Add(cloned);
                }

                if (!isArray) 
                    return list;
                
                var array = new DynamicEntity[list.Count];
                var i = 0;
                foreach (var item in list)
                {
                    array[i++] = (DynamicEntity) item;
                }
                return array;
            }
        }
        
        static IDictionary<string,object> compileKeys(DynamicEntity source)
        {
            // ensures that all properties are included, not just dictionary keys ...
            var keys = new Dictionary<string, object>(source);
            foreach (var property in source.GetType().GetProperties())
            {
                var jsonProperty = property.GetCustomAttribute<JsonPropertyNameAttribute>();
                if (jsonProperty is null)
                    continue;

                var key = jsonProperty.Name ?? property.Name.ToLowerInitial();
                if (keys.ContainsKey(key))
                    keys[key] = property;
                else
                    keys.Add(key, property);
            }

            return keys;
        }

        static DynamicEntity cloneDynamicEntity(DynamicEntity entity, bool recursive, DynamicPath path, DynamicPath[] ignore)
        {
            var type = entity.GetType();
            var ctors = type.GetConstructors();
            var emptyCtor = ctors.FirstOrDefault(c => c.GetParameters().Length == 0);
            if (emptyCtor == null)
                throw new NotImplementedException("Consider looking up ctor with params matching properties names & types"); // todo
            
            var cloned = (DynamicEntity) emptyCtor.Invoke(new object[0]);
            cloneFrom(cloned, entity, false, recursive, path, ignore);
            return cloned;
        }
    }
}