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
        public const char Separator = ',';
        
        [JsonIgnore]
        public string[] Items { get; private set; }
        
        public static MultiStringValue Empty { get; } = new MultiStringValue();

        public static bool TryParse(string stringValue, out MultiStringValue multiStringValue,
            StringComparison comparison = StringComparison.Ordinal)
        {
            return TryParse<MultiStringValue>(stringValue, out multiStringValue, comparison);
        }
        
        public static bool TryParse<T>(string stringValue, out T multiStringValue, StringComparison comparison = StringComparison.Ordinal)
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

            var split = value.Split(new[] {Separator}, StringSplitOptions.RemoveEmptyEntries);
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

        protected virtual Outcome<string> OnValidateItem(string item, StringComparison comparison = StringComparison.Ordinal) 
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
        public static implicit operator MultiStringValue(string stringValue) => stringValue is null ? Empty : new MultiStringValue(stringValue);

        /// <inheritdoc />
        public override string ToString() => StringValue;

        public IEnumerator<string> GetEnumerator() => new ArrayEnumerator<string>(Items);

        #region .  Equality  .

        /// <summary>
        ///   Compares with another <see cref="MultiStringValue"/> and returns a value to indicate
        ///   whether all items in this value are present in the other.
        /// </summary>
        /// <param name="other">
        ///   The other <see cref="MultiStringValue"/> to compare with.
        /// </param>
        /// <param name="comparison">
        ///   Specifies how to compare string values.
        /// </param>
        /// <returns>
        ///   <c>true</c> both values contains same number of <see cref="Items"/>
        ///   and all <see cref="Items"/> in this value are present in <paramref name="other"/>.
        /// </returns>
        public virtual bool EqualsSemantically(MultiStringValue other, StringComparison comparison = StringComparison.InvariantCulture)
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
        
        public MultiStringValue() : base("")
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
            if (IsError)
                return;
            
            var parseOutcome = tryParse(stringValue);
            if (!parseOutcome)
                throw parseOutcome.Exception;

            Items = parseOutcome.Value;
            StringValue = stringValue ?? throw new ArgumentNullException(nameof(stringValue));
        }

        public MultiStringValue(string[] items) : base("")
        {
            if (items.Length == 0)
                return;

            validateSupported(items);
            Items = items;
            StringValue = Items.ConcatCollection();
        }

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

        void validateSupported(IEnumerable<string> items)
        {
            foreach (var item in items)
            {
                var isValid = OnValidateItem(item);
                if (!isValid)
                    throw isValid.Exception;
            }
        }
    }

    public static class MultiStringValueHelper
    {
        public static bool IsEmpty(this MultiStringValue self) => !self?.Items.Any() ?? true;

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
            return !other.IsEmpty() && other.Items.Any(item => self.Items.Any(i => i == item));
        }

    }
}