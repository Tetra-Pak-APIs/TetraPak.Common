using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TetraPak
{
    /// <summary>
    ///   Convenience extension methods for <see cref="string"/> operations.
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        ///   Ensures the first letter in the string is lowercase.
        /// </summary>
        /// <param name="self">
        ///   The string to be transformed.
        /// </param>
        /// <param name="findFirstLetter">
        ///   (optional; default = <c>false</c>)<br/>
        ///   When set; the first occurence if a letter is automatically found (and transformed). 
        /// </param>
        /// <returns>
        ///   The transformed string.
        /// </returns>
        public static string ToLowerInitial(this string self, bool findFirstLetter = false)
        {
            if (string.IsNullOrEmpty(self))
                return self;

            // try quick-win scenario ...
            if (char.IsLetter(self[0]))
                return self.Length > 1
                    ? $"{char.ToLower(self[0]).ToString()}{self.Substring(1)}"
                    : char.ToLower(self[0]).ToString();

            // first char is not a letter ...
            if (!findFirstLetter)
                return self;

            var ca = self.ToCharArray();
            var sb = new StringBuilder();
            sb.Append(ca[0]);
            var i = 1;
            for (; i < ca.Length; i++)
            {
                if (char.IsLetter(ca[i]))
                {
                    sb.Append(char.ToLower(ca[i++]));
                    break;
                }

                sb.Append(ca[i]);
            }

            if (i < ca.Length)
                sb.Append(self.Substring(i));

            return sb.ToString();
        }

        /// <summary>
        ///   Ensures the first letter in the string is uppercase.
        /// </summary>
        /// <param name="self">
        ///   The string to be transformed.
        /// </param>
        /// <param name="findFirstLetter">
        ///   (optional; default = <c>false</c>)<br/>
        ///   When set; the first occurence if a letter is automatically found (and transformed). 
        /// </param>
        /// <returns>
        ///   The transformed string.
        /// </returns>
        public static string ToUpperInitial(this string self, bool findFirstLetter = false)
        {
            if (string.IsNullOrEmpty(self))
                return self;

            // try quick-win scenario ...
            if (char.IsLetter(self[0]))
                return self.Length > 1
                    ? $"{char.ToUpper(self[0]).ToString()}{self.Substring(1)}"
                    : char.ToUpper(self[0]).ToString();

            // first char is not a letter ...
            if (!findFirstLetter)
                return self;

            var ca = self.ToCharArray();
            var sb = new StringBuilder();
            sb.Append(ca[0]);
            var i = 1;
            for (; i < ca.Length; i++)
            {
                if (char.IsLetter(ca[i]))
                {
                    sb.Append(char.ToUpper(ca[i++]));
                    break;
                }

                sb.Append(ca[i]);
            }

            if (i < ca.Length)
                sb.Append(self.Substring(i));

            return sb.ToString();
        }

        public static string SplitCamelCase(this string self)
        {
            var ca = self.Trim().ToCharArray();
            var sb = new StringBuilder();
            for (var i = 0; i < ca.Length; i++)
            {
                var c = ca[i];
                if (i == 0)
                {
                    sb.Append(c);
                    continue;
                }

                if (char.IsUpper(c))
                {
                    sb.Append(' ');
                }

                sb.Append(c);
            }

            return sb.ToString();
        }

        public static bool IsPatternMatch(this string self, string test,
            StringComparison comparison = StringComparison.Ordinal, string replaceAllWildcard = "*",
            string replaceOneWildcard = "?")
        {
            string regexPattern = null;

            if (!string.IsNullOrWhiteSpace(replaceOneWildcard))
                regexPattern = self.Replace(replaceOneWildcard, ".?");

            if (!string.IsNullOrWhiteSpace(replaceAllWildcard))
                regexPattern = self.Replace(replaceAllWildcard, ".*");

            if (regexPattern is null)
                return self.Equals(test, comparison);

            var options = RegexOptions.None;
            if (comparison == StringComparison.InvariantCulture ||
                comparison == StringComparison.InvariantCultureIgnoreCase)
            {
                options = RegexOptions.CultureInvariant;
                if (comparison == StringComparison.InvariantCultureIgnoreCase)
                    options |= RegexOptions.IgnoreCase;
            }
            else if (comparison == StringComparison.CurrentCultureIgnoreCase ||
                     comparison == StringComparison.InvariantCultureIgnoreCase ||
                     comparison == StringComparison.OrdinalIgnoreCase)
            {
                options = RegexOptions.IgnoreCase;
            }

            var regex = new Regex(regexPattern, options);
            return regex.IsMatch(test);
        }

        public static string EnsurePrefix(this string self, string prefix,
            StringComparison comparison = StringComparison.Ordinal)
        {
            if (self.StartsWith(prefix, comparison))
                return self;

            return $"{prefix}{self}";
        }

        public static string EnsurePostfix(this string self, string postfix,
            StringComparison comparison = StringComparison.Ordinal)
        {
            if (self.EndsWith(postfix, comparison))
                return self;

            return $"{self}{postfix}";
        }

        public static string ReplaceLastChar(this string self, char replace)
        {
            var lastIndex = self.Length - 1;
            if (lastIndex == 0)
                return (char.IsUpper(self[lastIndex]) ? char.ToUpper(replace) : char.ToLower(replace)).ToString();

            var sb = new StringBuilder(self.Substring(0, self.Length - 2));
            sb.Append(char.IsUpper(self[lastIndex]) ? char.ToUpper(replace) : char.ToLower(replace));
            return sb.ToString();
        }

        public static string ReplaceEnding(this string self, string ending, string replace,
            StringComparison comparison = StringComparison.CurrentCultureIgnoreCase)
        {
            if (!self.EndsWith(ending, comparison))
                return self;

            var i = self.Length - ending.Length;
            var sb = new StringBuilder(self.Substring(0, self.Length - i));
            for (var j = 0; j < ending.Length; i++, j++)
            {
                var c = self[i];
                var e = ending[j];
                var isLower = char.IsLower(c);
                sb.Append(isLower ? char.ToLower(e) : char.ToUpper(e));
            }

            return sb.ToString();
        }

        public static bool IsVowel(this char c)
        {
            c = char.ToLower(c);
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y';
        }

        public static bool IsConsonant(this char c) => !IsVowel(c);

        public static bool Equals(this char self, char match, bool ignoreCase)
        {
            if (ignoreCase)
                return char.IsUpper(self) ? self == char.ToUpper(match) : self == char.ToLower(match);

            return self == match;
        }

        public static string ConcatCollection(
            this IEnumerable<object> values, 
            string separator = ", ",
            Func<object, string> callback = null, 
            int offset = 0)
        {
            var a = values?.ToArray();
            if (a is null || a.Length == 0)
                return string.Empty;

            var sb = new StringBuilder();
            sb.Append(callback?.Invoke(a[offset]) ?? SafeToString(a[offset]));
            for (var i = offset + 1; i < a.Length; i++)
            {
                sb.Append(separator);
                sb.Append(callback?.Invoke(a[i]) ?? SafeToString(a[i]));
            }

            return sb.ToString();
        }

        public static string ConcatDictionary<TKey, TValue>(
            this IDictionary<TKey, TValue> self,
            string separator = ", ",
            Func<object, string> callback = null)
        {
            var a = self?.ToArray();
            return Concat(a, separator, callback);
        }

        /// <summary>
        ///   Builds a <see cref="string"/> value from a collection of key/value pairs.
        /// </summary>
        /// <param name="self">
        ///   The collection of key value pairs.
        /// </param>
        /// <param name="separator">
        ///   (optional; default=", ")<br/>
        ///   A separator to be used for separating the individual items in the result.
        /// </param>
        /// <param name="callback">
        ///   (optional)<br/>
        ///   A callback method to customize the result (will be called once per item to produce a <see cref="string"/>
        ///   representation for that item.
        /// </param>
        /// <typeparam name="TKey">
        ///   The key value pair key type.
        /// </typeparam>
        /// <typeparam name="TValue">
        ///   The key value pair value type.
        /// </typeparam>
        /// <returns>
        ///   A <see cref="string"/> representation of the collection.
        /// </returns>
        public static string Concat<TKey, TValue>(
            this IEnumerable<KeyValuePair<TKey, TValue>> self,
            string separator = ", ",
            Func<object, string> callback = null)
        {
            var a = self?.ToArray();
            if (a is null || a.Length == 0)
                return string.Empty;
            
            var sb = new StringBuilder();
            sb.Append(callback?.Invoke(a[0]) ?? safeToString(a[0]));
            for (var i = 1; i < a.Length; i++)
            {
                sb.Append(separator);
                sb.Append(callback?.Invoke(a[i]) ?? safeToString(a[i]));
            }

            return sb.ToString();

            string safeToString(KeyValuePair<TKey, TValue> pair)
            {
                var (key, value) = pair;
                return $"{key}={SafeToString(value, separator:separator)}";
            }
        }

        public static string SafeToString(this object value, string nullIdentifier = "(null)", string separator = ", ")
        {
            if (ReferenceEquals(null, value))
                return nullIdentifier;

            if (!value.IsCollection(out _, out var items, out _)) return value.ToString();
            var enumerator = items.GetEnumerator();
            if (!enumerator.MoveNext())
                return string.Empty;
                
            var sb = new StringBuilder();
            sb.Append(SafeToString(enumerator.Current, separator:separator));
            while (enumerator.MoveNext())
            {
                sb.Append(separator);
                sb.Append(SafeToString(enumerator.Current, separator:separator));
            }

            return sb.ToString();
        }

        public static bool EqualsSubstring(this string self, int startIndex, int length, string match,
            StringComparison comparison)
        {
            if (startIndex < 0)
                startIndex = self.Length + startIndex;

            return self.Substring(startIndex, length).Equals(match, comparison);
        }

        public static int IndexOf(this string[] self, string pattern,
            StringComparison stringComparison = StringComparison.CurrentCulture)
        {
            for (var i = 0; i < self.Length; i++)
            {
                var s = self[i];
                if (s.Equals(pattern, stringComparison))
                    return i;
            }

            return -1;
        }

        public static string ToBase64String(this string self) => Convert.ToBase64String(Encoding.UTF8.GetBytes(self));

        public static string GetMatchingPrefix(this string self, string compare)
        {
            if (string.IsNullOrEmpty(self) || string.IsNullOrEmpty(compare))
                return string.Empty;

            var length = Math.Min(self.Length, compare.Length);
            var sb = new StringBuilder();
            for (var i = 0; i < length; i++)
            {
                if (self[i] != compare[i])
                    return sb.ToString();

                sb.Append(self[i]);
            }

            return sb.ToString();
        }

        public static bool IsNumericsOnly(this string self, params char[] allowedSymbols)
        {
            return self.All(c => char.IsNumber(c) || allowedSymbols.Any(i => i == c));
        }

        public static bool IsAssigned(this string self, bool isWhitespaceAllowed = false)
        {
            if ((self?.Length ?? 0) == 0)
                return false;
            
            return isWhitespaceAllowed || self.Any(c => !char.IsWhiteSpace(c));
        }

        public static bool IsUnassigned(this string self, bool isWhitespaceAllowed = false) =>
            !self.IsAssigned(isWhitespaceAllowed);

        public static string TrimWhitespace(this string self)
        {
            var sb = new StringBuilder();
            var ca = self.ToCharArray();
            for (var i = 0; i < ca.Length; i++)
            {
                var c = ca[i];
                if (!char.IsWhiteSpace(c))
                    sb.Append(c);

            }

            return sb.ToString();
        }
    }
}