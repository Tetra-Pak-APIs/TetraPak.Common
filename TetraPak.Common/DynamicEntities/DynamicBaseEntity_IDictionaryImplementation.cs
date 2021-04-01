using System.Collections;
using System.Collections.Generic;

namespace TetraPak.DynamicEntities
{
    partial class DynamicEntity
    {
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => _dictionary.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable) _dictionary).GetEnumerator();

        public void Add(KeyValuePair<string, object> item) => Add(item.Key, item.Value);

        public void Clear() => _dictionary.Clear();

        public bool Contains(KeyValuePair<string, object> item) => _dictionary.Contains(item);

        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
        {
            foreach (var kvp in array)
            {
                _dictionary.Add(kvp.Key, kvp.Value);
            }
        }

        public bool Remove(KeyValuePair<string, object> item) => _dictionary.Remove(item.Key);

        public int Count => _dictionary.Count;

        public bool IsReadOnly => _dictionary.IsReadOnly;

        public virtual void Add(string key, object value) => Set(key, value);

        public bool ContainsKey(string key) => _dictionary.ContainsKey(key);

        public bool Remove(string key) => _dictionary.Remove(key);

        public virtual bool TryGetValue(string key, out object value) => _dictionary.TryGetValue(key, out value);

        public object this[string key]
        {
            get
            {
                var o = OnTryGetPropertyValue<object>(key);
                return o
                    ? o.Value
                    : Get<object>(key);
            }
            set
            {
                var o = OnTrySetPropertyValue(key, value);
                if (!o)
                    Set(key, value);
            }
        }

        public ICollection<string> Keys => _dictionary.Keys;

        public ICollection<object> Values => _dictionary.Values;      
    }
}