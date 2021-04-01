using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using TetraPak.Serialization;

namespace TetraPak.DynamicEntities
{
    [JsonConverter(typeof(JsonStringValueSerializer<DynamicPath>))]
    [DebuggerDisplay("{" + nameof(StringValue) + "}")]
    public class DynamicPath : IStringValue
    {
        const string DefaultSeparator = "/";
        
        public string Separator { get; set; }
        
        readonly List<string> _stack = new List<string>();
        string _stringValue;

        /// <inheritdoc />
        public string StringValue
        {
            get
            {
                if (_stringValue != null)
                    return _stringValue;

                if (_stack.Count == 0)
                    return string.Empty;
                
                var sb = new StringBuilder();
                sb.Append(_stack[0]);
                for (var i = 1; i < _stack.Count; i++)
                {
                    sb.Append(Separator);
                    sb.Append(_stack[i]);
                }

                return _stringValue = sb.ToString();
            }
        }

        /// <summary>
        ///   Pushes item(s) to the end of the path.<br/>
        ///   (fluent API)
        /// </summary>
        /// <returns>
        ///   The resulting value.
        /// </returns>
        public DynamicPath Push(params string[] items)
        {
            _stack.AddRange(items);
            _stringValue = null;
            return this;
        }

        /// <summary>
        ///   Pops item(s) from the end of the path and returns the result.<br/>
        ///   (fluent API)
        /// </summary>
        /// <param name="count">
        ///   (optional; default=1)<br/>
        ///   Specifies the number of items to remove from end of path.
        /// </param>
        /// <returns>
        ///   The resulting value.
        /// </returns>
        public DynamicPath Pop(uint count = 1)
        {
            while (_stack.Count != 0 && count-- != 0)
            {
                _stack.RemoveAt(_stack.Count-1);
            }

            _stringValue = null;
            return this;
        }

        /// <summary>
        ///   Initializes the value.
        /// </summary>
        /// <param name="stringValue">
        ///   The new value's string representation (will automatically be parsed).
        /// </param>
        /// <param name="separator">
        ///   (optional)<br/>
        ///   Specifies a (custom) separator. 
        /// </param>
        /// <exception cref="FormatException">
        ///   The <paramref name="stringValue"/> string representation was incorrectly formed.
        /// </exception>
        [DebuggerStepThrough]
        public DynamicPath(string stringValue, string separator = null)
        {
            Separator = separator ?? DefaultSeparator;
            _stack.AddRange(stringValue.Split(new[] {Separator}, StringSplitOptions.RemoveEmptyEntries));
        }

        /// <summary>
        ///   Initializes the value from one or more items.
        /// </summary>
        public DynamicPath(params string[] items)
        {
            Separator = DefaultSeparator;
            _stack.AddRange(items);
        }
        
        /// <summary>
        ///   Sets the <see cref="Separator"/> (fluent API).
        /// </summary>
        /// <returns>
        ///   This value.
        /// </returns>
        public DynamicPath WithSeparator(string separator)
        {
            Separator = separator ?? throw new ArgumentNullException(nameof(separator));
            return this;
        }
        
        /// <summary>
        ///   Implicitly converts a string literal into a <see cref="DynamicPath"/>.
        /// </summary>
        /// <param name="stringValue">
        ///   A string representation of the <see cref="DynamicPath"/> value.
        /// </param>
        /// <returns>
        ///   A <see cref="DynamicPath"/> value.
        /// </returns>
        /// <exception cref="FormatException">
        ///   The <paramref name="stringValue"/> string representation was incorrectly formed.
        /// </exception>
        public static implicit operator DynamicPath(string stringValue) => new DynamicPath(stringValue);

        /// <summary>
        ///   Implicitly converts a <see cref="DynamicPath"/> value into its <see cref="string"/> representation.
        /// </summary>
        /// <param name="value">
        ///   A <see cref="DynamicPath"/> value to be implicitly converted into its <see cref="string"/> representation.
        /// </param>
        /// <returns>
        ///   The <see cref="string"/> representation of <paramref name="value"/>.
        /// </returns>
        public static implicit operator string(DynamicPath value) => value.StringValue;

        /// <inheritdoc />
        public override string ToString() => StringValue;

        #region .  Equality  .

        /// <summary>
        ///   Determines whether the specified value is equal to the current value.
        /// </summary>
        /// <param name="other">
        ///   A <see cref="DynamicPath"/> value to compare to this value.
        /// </param>
        /// <param name="stringComparison">
        ///   Specifies the string comparison strategy.
        /// </param>
        /// <returns>
        ///   <c>true</c> if <paramref name="other"/> is equal to the current value; otherwise <c>false</c>.
        /// </returns>
        public bool Equals(DynamicPath other, StringComparison stringComparison = StringComparison.InvariantCulture)
        {
            return !(other is null) && string.Equals(StringValue, other.StringValue, stringComparison);
        }

        /// <summary>
        ///   Determines whether the specified string collection matches the current value.
        /// </summary>
        /// <param name="items">
        ///   The string items to compare this value to.
        /// </param>
        /// <param name="stringComparison">
        ///   Specifies the string comparison strategy.
        /// </param>
        /// <returns>
        ///   <c>true</c> if the <paramref name="items"/> matches the internal items of the current value; otherwise <c>false</c>.
        /// </returns>
        public bool Equals(IEnumerable<string> items, StringComparison stringComparison = StringComparison.InvariantCulture)
        {
            return items != null && Equals(new DynamicPath(items.ToArray()), stringComparison);
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
            return !(obj is null) && (obj is DynamicPath other && Equals(other));
        }

        /// <summary>
        ///   Serves as the default hash function.
        /// </summary>
        /// <returns>
        ///   A hash code for the current value.
        /// </returns>
        public override int GetHashCode()
        {
            return (StringValue != null ? StringValue.GetHashCode() : 0);
        }

        /// <summary>
        ///   Comparison operator overload.
        /// </summary>
        public static bool operator ==(DynamicPath left, DynamicPath right)
        {
            return left?.Equals(right) ?? right is null;
        }

        /// <summary>
        ///   Comparison operator overload.
        /// </summary>
        public static bool operator !=(DynamicPath left, DynamicPath right)
        {
            return !left?.Equals(right) ?? !(right is null);
        }

        #endregion
    }
}