using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json.Serialization;
using TetraPak.Serialization;

namespace TetraPak
{
    /// <summary>
    ///   Represents one or more supported user roles.
    /// </summary>
    [Serializable, JsonConverter(typeof(JsonStringValueSerializer<MultiStringValue>))]
    [DebuggerDisplay("{" + nameof(StringValue) + "}")]
    public class MultiStringValue : StringValueBase 
    {
        /// <summary>
        ///   The default separator used for parsing a <see cref="MultiStringValue"/>. 
        /// </summary>
        public const char DefaultSeparator = ',';
        
        /// <summary>
        ///   Gets the string elements of the value as an <see cref="Array"/> of <see cref="string"/>.
        /// </summary>
        [JsonIgnore]
        public string[] Items { get; private set; }

        /// <summary>
        ///   Gets the number of <see cref="Items"/> in the value.
        /// </summary>
        public int Count => (Items?.Length ?? 0);
        
        /// <summary>
        ///   Creates and returns an empty <see cref="MultiStringValue"/>.
        /// </summary>
        public static MultiStringValue Empty { get; } = new();

        /// <summary>
        ///   Gets a value indicating whether the <see cref="MultiStringValue"/> is empty.
        /// </summary>
        public bool IsEmpty => Count == 0;

        protected virtual string OnGetSeparator() => DefaultSeparator.ToString();

        /// <summary>
        ///   Converts a string to its <see cref="MultiStringValue"/> equivalent.
        ///   A return value indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="stringValue">
        ///   A string containing a <see cref="MultiStringValue"/> to convert.
        /// </param>
        /// <param name="multiStringValue">
        ///   The successfully parsed <see cref="MultiStringValue"/>.
        /// </param>
        /// <param name="comparison">
        ///   (optional)<br/>
        ///   A <see cref="StringComparer"/> used for parsing the <see cref="MultiStringValue"/>.
        ///   This is mainly intended for the need in derived classes that needs to override the
        ///   <see cref="OnValidateItem"/> method. The comparer have no effect in this class. 
        /// </param>
        /// <returns>
        ///   <c>true</c> if <paramref name="stringValue"/> was converted successfully; otherwise, <c>false</c>.
        /// </returns>
        /// <seealso cref="TryParse{T}"/>
        public static bool TryParse(string stringValue, out MultiStringValue multiStringValue,
            StringComparison comparison = StringComparison.Ordinal)
        {
            return TryParse<MultiStringValue>(stringValue, out multiStringValue, comparison);
        }
        
        /// <summary>
        ///   Converts a string to its <see cref="MultiStringValue"/>-compatible equivalent.
        ///   A return value indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="stringValue"></param>
        /// <param name="multiStringValue"></param>
        /// <param name="comparison"></param>
        /// <typeparam name="T">
        ///   A <see cref="Type"/>, deriving from <see cref="MultiStringValue"/>,
        ///   for <paramref name="stringValue"/> to be converted to. 
        /// </typeparam>
        /// <returns>
        ///   <c>true</c> if <paramref name="stringValue"/> was converted successfully; otherwise, <c>false</c>.
        /// </returns>
        /// <seealso cref="TryParse"/>
        public static bool TryParse<T>(
            string stringValue, 
            out T multiStringValue, 
            StringComparison comparison = StringComparison.Ordinal)
        where T : MultiStringValue
        {
            multiStringValue = (T) Activator.CreateInstance(typeof(T));
            if (multiStringValue is null)
                return false;
                
            var parseOutcome = multiStringValue.tryParse(stringValue, comparison);
            if (parseOutcome)
            {
                multiStringValue.setInternal(stringValue, parseOutcome.Value);
                return true;
            }
            
            multiStringValue = null;
            return false;
        }

        void setInternal(string stringValue, string[] items)
        {
            StringValue = stringValue;
            Items = items;
        }

        Outcome<string[]> tryParse(string value, StringComparison comparison = StringComparison.Ordinal)
        {
            if (string.IsNullOrEmpty(value))
                return Outcome<string[]>.Fail(new FormatException($"Invalid {typeof(MultiStringValue)} format: \"{value}\""));

            var separator = OnGetSeparator();
            var split = value.Split(new[] {separator}, StringSplitOptions.RemoveEmptyEntries);
            if (split.Length == 0)
                return Outcome<string[]>.Fail(new FormatException($"Invalid {typeof(MultiStringValue)} format: \"{value}\""));

            var roles = new List<string>();
            foreach (var s in split)
            {
                var trimmed = s.Trim();
                var isValidItem = OnValidateItem(trimmed, comparison);
                if (!isValidItem)
                    return Outcome<string[]>.Fail(isValidItem.Exception);
                
                roles.Add(trimmed);
            }
            return Outcome<string[]>.Success(roles.ToArray());
        }

        /// <summary>
        ///   Called during the parsing process to allow validation of a string item.
        ///   Intended for derived <see cref="MultiStringValue"/> classes. This implementation always returns
        ///   a successful result. 
        /// </summary>
        /// <param name="item">
        ///   A <see cref="string"/> item to be validated.
        /// </param>
        /// <param name="comparison">
        ///   (optional; default=<see cref="StringComparison.Ordinal"/>)<br/>
        ///   A string comparison value to be honored by the validation. 
        /// </param>
        /// <returns>
        ///   An <see cref="Outcome{T}"/> to indicate success/failure and, on success, also carry
        ///   a <see cref="string"/> or, on failure, an <see cref="Exception"/>.
        /// </returns>
        protected virtual Outcome<string> OnValidateItem(string item, 
            StringComparison comparison = StringComparison.Ordinal) 
            => Outcome<string>.Success(item);

        /// <summary>
        ///   Implicitly converts a <see cref="MultiStringValue"/> value into its <see cref="string"/> representation.
        /// </summary>
        /// <param name="value">
        ///   A <see cref="MultiStringValue"/> value to be implicitly converted into its <see cref="string"/> representation.
        /// </param>
        /// <returns>
        ///   The <see cref="string"/> representation of <paramref name="value"/>.
        /// </returns>
        public static implicit operator string(MultiStringValue value) => value?.StringValue;
        
        [DebuggerStepThrough]
        public static implicit operator MultiStringValue(string stringValue) => 
            stringValue is null 
                ? Empty 
                : new MultiStringValue(stringValue);

        /// <inheritdoc />
        public override string ToString() => StringValue;

        /// <inheritdoc cref="IEnumerable{T}.GetEnumerator"/>
        public IEnumerator<string> GetEnumerator() => new ArrayEnumerator<string>(Items);

        /// <summary>
        ///   Creates a new <see cref="MultiStringValue"/> from this one, but without one or more leading element(s).
        /// </summary>
        /// <param name="count">
        ///   (optional; default=1)<br/>
        ///   Specifies how many items to pop from the <see cref="MultiStringValue"/>.
        /// </param>
        /// <param name="safe">
        ///   (optional; default=<c>false</c>)<br/>
        ///   When set an invalid <paramref name="count"/> (too high) an <see cref="Empty"/> value is returned;
        ///   otherwise a <see cref="ArgumentOutOfRangeException"/> exception is thrown.
        /// </param>
        /// <returns>
        ///   A <see cref="MultiStringValue"/> with <paramref name="count"/> items removed from the start.
        /// </returns>
        public MultiStringValue TrimFirst(int count = 1, bool safe = false)
        {
            count = Math.Max(0, count);
            if (count == 0)
                return new MultiStringValue(Items);
                
            if (count == Items.Length)
                return Empty;
                
            if (count > Items.Length)
                return safe 
                    ? Empty
                    : throw new ArgumentOutOfRangeException(nameof(count), $"Cannot pop {count} items from end of {this}");
            
            var items = new string[Items.Length - count];
            var j = count;
            // var length = Items.Length - count; obsolete
            for (var i = 0; i < items.Length; i++, j++)
            {
                items[i] = Items[j];
            }

            return new MultiStringValue(items);
        }

        /// <summary>
        ///   Creates a new <see cref="MultiStringValue"/> from this one, but without one or more trailing element(s).
        /// </summary>
        /// <param name="count">
        ///   (optional; default=1)<br/>
        ///   Specifies how many items to pop from the <see cref="MultiStringValue"/>.
        /// </param>
        /// <param name="safe">
        ///   (optional; default=<c>false</c>)<br/>
        ///   When set an invalid <paramref name="count"/> (too high) an <see cref="Empty"/> value is returned;
        ///   otherwise a <see cref="ArgumentOutOfRangeException"/> exception is thrown.
        /// </param>
        /// <returns>
        ///   A <see cref="MultiStringValue"/> with <paramref name="count"/> items removed from the end.
        /// </returns>
        public MultiStringValue TrimLast(uint count = 1, bool safe = false)
        {
            if (count == 0)
                return new MultiStringValue(Items);
                
            if (count == Items.Length)
                return Empty;
                
            if (count > Items.Length)
                return safe 
                    ? Empty
                    : throw new ArgumentOutOfRangeException(nameof(count), $"Cannot pop {count} items from end of {this}");
            
            var items = new string[Items.Length - count];
            for (var i = 0; i < items.Length; i++)
            {
                items[i] = Items[i];
            }

            return new MultiStringValue(items);
        }
        
        /// <summary>
        ///   Copies the leading <see cref="Items"/> of this value to create a new <see cref="MultiStringValue"/>.
        /// </summary>
        /// <param name="count">
        ///   (optional; default=1)<br/>
        ///   The number of elements to be copied.
        /// </param>
        /// <param name="safe">
        ///   (optional; default=<c>false</c>)<bt/>
        ///   When set an invalid <paramref name="count"/> value will return an <see cref="Empty"/> value;
        ///   otherwise an <see cref="ArgumentOutOfRangeException"/> will be thrown.
        /// </param>
        /// <returns>
        ///   A <see cref="MultiStringValue"/> from the first leading items of this one.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///   The <paramref name="count"/> value implied more <see cref="Items"/> than was supported by this value,
        ///   and <paramref name="safe"/> was not set.  
        /// </exception>
        public MultiStringValue CopyFirst(int count = 1, bool safe = false)
        {
            count = Math.Max(0, count);
            if (count == Items.Length)
                return new MultiStringValue(Items);
            
            if (count < 1)
                return safe
                    ? Empty
                    : throw new ArgumentOutOfRangeException(nameof(count), $"Cannot extract last {count} items from end of {this}");
            
            if (count > Items.Length)
                return safe 
                    ? new MultiStringValue(Items)
                    : throw new ArgumentOutOfRangeException(nameof(count), $"Cannot pop {count} items from end of {this}");

            if (count == 1)
                return new MultiStringValue(Items[0]);

            var items = new string[count];
            for (var i = 0; i < count; i++)
            {
                items[i] = Items[i];
            }

            return new MultiStringValue(items);
        }

        /// <summary>
        ///   Copies the trailing <see cref="Items"/> of this value to create a new <see cref="MultiStringValue"/>.
        /// </summary>
        /// <param name="count">
        ///   (optional; default=1)<br/>
        ///   The number of elements to be copied.
        /// </param>
        /// <param name="safe">
        ///   (optional; default=<c>false</c>)<bt/>
        ///   When set an invalid <paramref name="count"/> value will return an <see cref="Empty"/> value;
        ///   otherwise an <see cref="ArgumentOutOfRangeException"/> will be thrown.
        /// </param>
        /// <returns>
        ///   A <see cref="MultiStringValue"/> from the trailing items of this one.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///   The <paramref name="count"/> value implied more <see cref="Items"/> than was supported by this value,
        ///   and <paramref name="safe"/> was not set.  
        /// </exception>
        public MultiStringValue CopyLast(uint count = 1, bool safe = false)
        {
            if (count == Items.Length)
                return new MultiStringValue(Items);
            
            if (count < 1)
                return safe
                    ? Empty
                    : throw new ArgumentOutOfRangeException(nameof(count), $"Cannot extract last {count} items from end of {this}");
            
            if (count > Items.Length)
                return safe 
                    ? new MultiStringValue(Items)
                    : throw new ArgumentOutOfRangeException(nameof(count), $"Cannot pop {count} items from end of {this}");

            if (count == 1)
                return new MultiStringValue(Items[^1]);

            var items = new string[count];
            var j = 0;
            for (var i = Count-count; i < Count; i++, j++)
            {
                items[j] = Items[i];
            }

            return new MultiStringValue(items);
        }

        /// <summary>
        ///   Determines whether the leading <see cref="Items"/> matches another <see cref="MultiStringValue"/>. 
        /// </summary>
        /// <param name="pattern">
        ///   A <see cref="MultiStringValue"/> to compare with.
        /// </param>
        /// <param name="stringComparison">
        ///   (optional; default=<see cref="StringComparison.Ordinal"/>)<br/>
        ///   One of the enumeration values that specifies how the strings will be compared.
        /// </param>
        /// <returns>
        ///   <c>true</c> if the leading <see cref="Items"/> of this value matches all
        ///   items of the <paramref name="pattern"/>.
        /// </returns>
        /// <seealso cref="EndsWith"/>
        public bool StartsWith(MultiStringValue pattern, StringComparison stringComparison = StringComparison.Ordinal)
        {
            if (IsEmpty)
                return pattern.IsEmpty;

            if (pattern.Count > Count)
                return false;

            for (var i = 0; i < pattern.Count; i++)
            {
                if (!Items[i].Equals(pattern.Items[i], stringComparison))
                    return false;
            }

            return true;
        }

        /// <summary>
        ///   Determines whether the trailing <see cref="Items"/> matches another <see cref="MultiStringValue"/>. 
        /// </summary>
        /// <param name="pattern">
        ///   A <see cref="MultiStringValue"/> to compare with.
        /// </param>
        /// <param name="stringComparison">
        ///   (optional; default=<see cref="StringComparison.Ordinal"/>)<br/>
        ///   One of the enumeration values that specifies how the strings will be compared.
        /// </param>
        /// <returns>
        ///   <c>true</c> if the trailing <see cref="Items"/> of this value matches all
        ///   items of the <paramref name="pattern"/>.
        /// </returns>
        /// <seealso cref="StartsWith"/>
        public bool EndsWith(MultiStringValue pattern, StringComparison stringComparison = StringComparison.Ordinal)
        {
            if (IsEmpty)
                return pattern.IsEmpty;

            if (pattern.Count > Count)
                return false;

            var j = Count - pattern.Count;
            for (var i = 0; i < pattern.Count; i++, j++)
            {
                if (!Items[j].Equals(pattern.Items[i], stringComparison))
                    return false;
            }

            return true;
        }

        #region .  Equality  .

        /// <summary>
        ///   Compares with another <see cref="MultiStringValue"/> and returns a value to indicate
        ///   whether all items in this value are present in the other, regardless of item's order.
        /// </summary>
        /// <param name="other">
        ///   The other <see cref="MultiStringValue"/> to compare with.
        /// </param>
        /// <param name="comparison">
        ///   (optional; default=<see cref="StringComparison.Ordinal"/>)<br/>
        ///   Specifies how to compare string values.
        /// </param>
        /// <returns>
        ///   <c>true</c> both values contains same number of <see cref="Items"/>
        ///   and all <see cref="Items"/> in this value are present in <paramref name="other"/>.
        /// </returns>
        public virtual bool EqualsSemantically(
            MultiStringValue other, 
            StringComparison comparison = StringComparison.InvariantCulture)
        {
            var length = Items.Length;
            if (other is null || length != other.Items.Length)
                return false;

            for (var i = 0; i < length; i++)
            {
                var test = Items[i];
                var match = false;
                for (var j = 0; j < length && !match; j++)
                {
                    match = test.Equals(other.Items[j]);
                }

                if (!match)
                    return false;
            }

            return true;
        }

        /// <summary>
        ///   Determines whether the specified value is equal to the current value.
        /// </summary>
        /// <param name="other">
        ///   A <see cref="MultiStringValue"/> value to compare to this value.
        /// </param>
        /// <returns>
        ///   <c>true</c> if <paramref name="other"/> is equal to the current value; otherwise <c>false</c>.
        /// </returns>
        public virtual bool Equals(MultiStringValue other)
        {
            return !(other is null) && string.Equals(StringValue, other.StringValue);
        }

        /// <summary>
        ///   Determines whether the specified object is equal to the current version.
        /// </summary>
        /// <param name="obj">
        ///   An object to compare to this value.
        /// </param>
        /// <returns>
        ///   <c>true</c> if the specified object is equal to the current version; otherwise <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            return obj is MultiStringValue other && Equals(other);
        }

        /// <summary>
        ///   Serves as the default hash function.
        /// </summary>
        /// <returns>
        ///   A hash code for the current value.
        /// </returns>
        public override int GetHashCode()
        {
            return StringValue != null ? StringValue.GetHashCode() : 0;
        }
        
        public bool Contains(string value) => Items?.Contains(value) ?? false;

        /// <summary>
        ///   Comparison operator overload.
        /// </summary>
        public static bool operator ==(MultiStringValue left, MultiStringValue right)
        {
            return left?.Equals(right) ?? right is null;
        }

        /// <summary>
        ///   Comparison operator overload.
        /// </summary>
        public static bool operator !=(MultiStringValue left, MultiStringValue right)
        {
            return !left?.Equals(right) ?? !(right is null);
        }

        public static bool operator >=(MultiStringValue left, MultiStringValue right)
        {
            return !(right is null) && right.Items.All(i => left?.Contains(i) ?? false);
        }

        public static bool operator <=(MultiStringValue left, MultiStringValue right)
        {
            return right >= left;
        }
        #endregion
        
        MultiStringValue() : base("")
        {
        }
        
        /// <summary>
        ///   Initializes the value.
        /// </summary>
        /// <param name="stringValue">
        ///   The new value's string representation (will automatically be parsed).
        /// </param>
        /// <exception cref="FormatException">
        ///   The <paramref name="stringValue"/> string representation was incorrectly formed.
        /// </exception>
        //[DebuggerStepThrough] 
        public MultiStringValue(string stringValue) : base(stringValue)
        {
            if (IsError || string.IsNullOrWhiteSpace(stringValue))
                return;
            
            var parseOutcome = tryParse(stringValue);
            if (!parseOutcome)
                throw parseOutcome.Exception;

            Items = parseOutcome.Value;
            StringValue = stringValue;
        }
        
        void validateSupported(IEnumerable<string> items)
        {
            foreach (var item in items)
            {
                var isValid = OnValidateItem(item);
                if (!isValid)
                    throw isValid.Exception;
            }
        }

        /// <summary>
        ///   Creates a <see cref="MultiStringValue"/> from one or more <see cref="string"/> items,
        ///   automatically removing any duplicates.
        /// </summary>
        /// <param name="items">
        ///   The <see cref="string"/> items. 
        /// </param>
        /// <returns>
        ///   A <see cref="MultiStringValue"/>.
        /// </returns>
        public static MultiStringValue WithoutDuplicates(params string[] items)
        {
            var set = new HashSet<string>();
            foreach (var item in items)
            {
                if (set.Contains(item))
                    continue;
                
                set.Add(item);
            }
            return new MultiStringValue(set.ToArray());
        }

        void setStringValue() => StringValue = Items.ConcatCollection(OnGetSeparator());

        public MultiStringValue(string[] items) : base("")
        {
            if (items.Length == 0)
                return;

            validateSupported(items);
            Items = items;
            setStringValue();
        }

    }

    public static class MultiStringValueHelper
    {
        // public static bool IsEmpty(this MultiStringValue self) => !self?.Items.Any() ?? true; obsolete

        public static MultiStringValue Join(this MultiStringValue self, MultiStringValue other, bool trimDuplicates)
        {
            var list = new List<string>(self.Items);
            list.AddRange(other.Items);
            var items = list.ToArray();
            return trimDuplicates
                ? MultiStringValue.WithoutDuplicates(items)
                : new MultiStringValue(items);
        }
        
        public static MultiStringValue Join(this MultiStringValue self, string[] items, bool trimDuplicates)
        {
            var list = new List<string>(self.Items);
            list.AddRange(items);
            return trimDuplicates
                ? MultiStringValue.WithoutDuplicates(list.ToArray())
                : new MultiStringValue(list.ToArray());
        }
        
        public static bool Any(this MultiStringValue self, MultiStringValue other)
        {
            return !other.IsEmpty && other.Items.Any(item => self.Items.Any(i => i == item));
        }

    }
}