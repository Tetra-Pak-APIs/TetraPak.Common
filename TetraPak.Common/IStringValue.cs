using System;
using System.Text.Json.Serialization;
using TetraPak.Serialization;

namespace TetraPak
{
    /// <summary>
    ///   A string compatible value.
    /// </summary>
    public interface IStringValue
    {
        /// <summary>
        ///   The value's string representation.
        /// </summary>
        string StringValue { get; }
    }

    public static class StringValueError
    {
        public const string Qualifier = "#ERROR:";
    }
    
    [Serializable, JsonConverter(typeof(JsonStringValueSerializer<StringValueBase>))]
    public class StringValueBase : IStringValue
    {
        [JsonIgnore]
        public bool IsError { get; set; }
        
        public string StringValue { get; protected set; } // todo consider making StringValueBase immutable

        string parse(string stringValue) => OnParse(stringValue);

        protected virtual string OnParse(string stringValue)
        {
            if (string.IsNullOrEmpty(stringValue) || !stringValue.StartsWith(StringValueError.Qualifier))
                return stringValue;

            IsError = true;
            return stringValue;
        }

        #region .  Equality  .

        /// <summary>
        ///   Determines whether the specified value is equal to the current value.
        /// </summary>
        /// <param name="other">
        ///   A <see cref="StringValueBase"/> value to compare to this value.
        /// </param>
        /// <returns>
        ///   <c>true</c> if <paramref name="other"/> is equal to the current value; otherwise <c>false</c>.
        /// </returns>
        public bool Equals(StringValueBase other)
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
            return !(obj is null) && (obj is MultiStringValue other && Equals(other));
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
        
        /// <summary>
        ///   Comparison operator overload.
        /// </summary>
        public static bool operator ==(StringValueBase left, StringValueBase right)
        {
            return left?.Equals(right) ?? right is null;
        }

        /// <summary>
        ///   Comparison operator overload.
        /// </summary>
        public static bool operator !=(StringValueBase left, StringValueBase right)
        {
            return !left?.Equals(right) ?? !(right is null);
        }

        #endregion        
        
        public StringValueBase(string stringValue)
        {
            StringValue = parse(stringValue);
        }
    }
}