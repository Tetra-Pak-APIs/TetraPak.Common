using System;
using System.Collections.Generic;
using System.Linq;
using TetraPak.Serialization;

namespace TetraPak
{
    public static class DictionaryExtensions
    {
        /// <summary>
        ///   Generates a new <see cref="IDictionary{TKey,TValue}"/> where all keys are
        ///   renamed according to a specified key map.
        /// </summary>
        /// <param name="self">
        ///   The source dictionary. 
        /// </param>
        /// <param name="keyMap">
        ///   A dictionary containing the key mapping (keys=source keys, values=target keys).
        /// </param>
        /// <param name="isRestricted">
        ///   (optional; default=<c>false</c>)<br/>
        ///   Specifies whether to only include attributes whose keys can be found in the <paramref name="keyMap"/>.  
        /// </param>
        /// <typeparam name="TValue">
        ///   The dictionary's value <see cref="Type"/>.
        /// </typeparam>
        /// <returns>
        ///   A remapped dictionary.
        /// </returns>
        /// <seealso cref="MapSafe{TValue}(System.Collections.Generic.IDictionary{string,TValue},KeyMapInfo,bool)"/>
        public static IDictionary<string, TValue> Map<TValue>(
            this IDictionary<string, TValue> self, 
            IDictionary<string,string> keyMap,
            bool isRestricted = false)
        {
            return new Dictionary<string, TValue>(self.ToArray().Map(keyMap, isRestricted));
        }

        /// <summary>
        ///   Generates a new <see cref="IDictionary{TKey,TValue}"/> where all keys are
        ///   renamed according to a specified key map.
        /// </summary>
        /// <param name="self">
        ///   The source dictionary. 
        /// </param>
        /// <param name="keyMap">
        ///   A dictionary containing the key mapping (keys=source keys, values=target keys).
        /// </param>
        /// <param name="isRestricted">
        ///   (optional; default=<c>false</c>)<br/>
        ///   Specifies whether to only include attributes whose keys can be found in the <paramref name="keyMap"/>.  
        /// </param>
        /// <typeparam name="TValue">
        ///   The dictionary's value <see cref="Type"/>.
        /// </typeparam>
        /// <returns>
        ///   A remapped dictionary.
        /// </returns>
        public static IDictionary<string, TValue> MapSafe<TValue>(
            this IDictionary<string, TValue> self, 
            KeyMapInfo keyMap,
            bool isRestricted = false)
        {
            var mapped = self.ToArray().MapSafe(keyMap);
            return new Dictionary<string, TValue>(mapped);
        }

        public static IEnumerable<KeyValuePair<string, TValue>> Map<TValue>(
            this KeyValuePair<string, TValue>[] self,
            IDictionary<string, string> keyMap, 
            bool isRestricted)
        {
            for (var i = 0; i < self.Length; i++)
            {
                var key = self[i].Key;
                var mappedKey = keyMap[key];
                yield return new KeyValuePair<string, TValue>(mappedKey, self[i].Value);
            }
        }
        
        public static IEnumerable<KeyValuePair<string, TValue>> MapSafe<TValue>(
            this KeyValuePair<string, TValue>[] self,
            KeyMapInfo keyMap)
        {
            for (var i = 0; i < self.Length; i++)
            {
                if (self[i].Value is null)
                    continue;

                var key = self[i].Key;
                if (keyMap.Map.TryGetValue(key, out var mappedKey))
                {
                    yield return new KeyValuePair<string, TValue>(mappedKey, self[i].Value);
                }
                else if (!keyMap.IsStrict)
                {
                    yield return new KeyValuePair<string, TValue>(self[i].Key, self[i].Value);
                }
            }
        }

        public static IDictionary<T,T> ToInverted<T>(this IDictionary<T,T> self)
        {
            var keys = (IEnumerable<KeyValuePair<T, T>>) self;
            return new Dictionary<T, T>(keys.ToInverted());
        }

        /// <summary>
        ///   Maps all key/value elements to a collection of items of a specified type.
        /// </summary>
        public static IEnumerable<T> MapTo<T, TKey, TValue>(
            this IDictionary<TKey, TValue> self,
            Func<KeyValuePair<TKey, TValue>, T> mapper)
        {
            return self.Select(mapper);
        }
        
        public static IEnumerable<KeyValuePair<T,T>> ToInverted<T>(this IEnumerable<KeyValuePair<T,T>> self)
        {
            foreach (var (key, value) in self)
            {
                yield return new KeyValuePair<T,T>(value, key);
            }
        }

    }
}