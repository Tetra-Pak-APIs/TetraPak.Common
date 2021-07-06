using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json.Serialization;
using TetraPak.Serialization;

namespace TetraPak
{
    [JsonConverter(typeof(JsonStringValueSerializer<ReadChunk>))]
    [DebuggerDisplay("{" + nameof(StringValue) + "}")]
    public class ReadChunk : IStringValue
    {
        int _skip;
        int _count;
        const string Separator = ",";

        /// <inheritdoc />
        public string StringValue { get; private set; }

        /// <summary>
        ///   Number of (leading) entities to be skipped in read operation.
        /// </summary>
        public int Skip
        {
            [DebuggerStepThrough]
            get => _skip;
            internal set
            {
                _skip = value;
                StringValue = compile(value, Count);
            }
        }

        /// <summary>
        ///   Number of entities to be included in read operation.
        /// </summary>
        public int Count
        {
            [DebuggerStepThrough]
            get => _count;
            internal set
            {
                _count = value;
                StringValue = compile(Skip, value);
            }
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
        [DebuggerStepThrough]
        public ReadChunk(string stringValue)
        {
            if (!tryParse(stringValue, out var skip, out var count))
                throw new FormatException(
                    $"Invalid {GetType()}: \"{stringValue}\". Expected format: \"<skip>{Separator}<count>\".");

            StringValue = compile(skip, count);
            Skip = skip;
            Count = count;
        }

        public ReadChunk(int skip, int count)
        {
            StringValue = compile(skip, count);
            Skip = skip;
            Count = count;
        }

        static bool tryParse(string stringValue, out int skip, out int count)
        {
            // note: Assumes string elements ...
            skip = count = -1;
            if (stringValue is null)
                return false;

            var split = stringValue.Split(new[] {Separator}, StringSplitOptions.RemoveEmptyEntries);

            return split.Length switch
            {
                1 => int.TryParse(split[0].Trim(), out skip),
                2 => int.TryParse(split[0].Trim(), out skip) && int.TryParse(split[1].Trim(), out count),
                _ => false
            };
        }

        static string compile(int skip, int count) => $"{skip}{Separator}{count}";

        public static ReadChunk Parse(string stringValue)
        {
            if (string.IsNullOrWhiteSpace(stringValue))
                return null;

            return tryParse(stringValue, out var skip, out var count)
                ? new ReadChunk(skip, count)
                : null;
        }

        public static bool TryParse(string stringValue, out ReadChunk chunk)
        {
            chunk = null;
            if (string.IsNullOrWhiteSpace(stringValue) || !tryParse(stringValue, out var skip, out var count))
                return false;

            chunk = new ReadChunk(skip, count);
            return true;
        }

        /// <summary>
        ///   Implicitly converts a string literal into a <see cref="ReadChunk"/>.
        /// </summary>
        /// <param name="stringValue">
        ///   A string representation of the <see cref="ReadChunk"/> value.
        /// </param>
        /// <returns>
        ///   A <see cref="ReadChunk"/> value.
        /// </returns>
        /// <exception cref="FormatException">
        ///   The <paramref name="stringValue"/> string representation was incorrectly formed.
        /// </exception>
        public static implicit operator ReadChunk(string stringValue) 
            => stringValue is {} ? new ReadChunk(stringValue) : null;

        /// <summary>
        ///   Implicitly converts a <see cref="ReadChunk"/> value into its <see cref="string"/> representation.
        /// </summary>
        /// <param name="value">
        ///   A <see cref="ReadChunk"/> value to be implicitly converted into its <see cref="string"/> representation.
        /// </param>
        /// <returns>
        ///   The <see cref="string"/> representation of <paramref name="value"/>.
        /// </returns>
        public static implicit operator string(ReadChunk value) => value?.StringValue;

        /// <inheritdoc />
        public override string ToString() => StringValue;

        #region .  Equality  .

        /// <summary>
        ///   Determines whether the specified value is equal to the current value.
        /// </summary>
        /// <param name="other">
        ///   A <see cref="ReadChunk"/> value to compare to this value.
        /// </param>
        /// <returns>
        ///   <c>true</c> if <paramref name="other"/> is equal to the current value; otherwise <c>false</c>.
        /// </returns>
        public bool Equals(ReadChunk other)
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
            return !(obj is null) && (obj is ReadChunk other && Equals(other));
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
        public static bool operator ==(ReadChunk left, ReadChunk right)
        {
            return left?.Equals(right) ?? right is null;
        }

        /// <summary>
        ///   Comparison operator overload.
        /// </summary>
        public static bool operator !=(ReadChunk left, ReadChunk right)
        {
            return !left?.Equals(right) ?? !(right is null);
        }

        #endregion
    }

    public static class ReadChunkHelper
    {
        public static IEnumerable<T> TakeEnumerable<T>(this IEnumerable<T> self, ReadChunk chunk)
        {
            return self.Skip(chunk.Skip).Take(chunk.Count);
        }

        public static T[] Take<T>(this List<T> self, ReadChunk chunk)
        {
            if (chunk is null ||chunk.Count < 1) 
                return self.ToArray();

            if (chunk.Skip <= self.Count)
            {
                chunk.Count = Math.Min(chunk.Count, self.Count);
                return self.Skip(chunk.Skip).Take(chunk.Count).ToArray();
            }
            
            chunk.Skip = 0;
            chunk.Count = self.Count;
            return self.ToArray();
        }

        public static T[] Take<T>(this IEnumerable<T> self, ReadChunk chunk)
        {
            if (chunk is null || chunk.Count < 1) 
                return self.ToArray();

            if (chunk.Skip <= self.Count())
            {
                var a1 = self.Skip(chunk.Skip).Take(chunk.Count).ToArray();
                chunk.Count = Math.Min(chunk.Count, a1.Length);
                return a1;
            }

            var a2 = self.ToArray();
            chunk.Skip = 0;
            chunk.Count = a2.Length;
            return a2;
        }

        public static T[] Take<T>(this IReadOnlyCollection<T> self, ReadChunk chunk)
        {
            if (chunk is null || chunk.Count < 1) 
                return self.ToArray();

            if (chunk.Skip <= self.Count)
            {
                var a1 = self.Skip(chunk.Skip).Take(chunk.Count).ToArray();
                chunk.Count = Math.Min(chunk.Count, a1.Length);
                return a1;
            }

            var a2 = self.ToArray();
            chunk.Skip = 0;
            chunk.Count = a2.Length;
            return a2;
        }

        public static T[] Take<T>(this T[] self, ReadChunk chunk)
        {
            if (chunk is null || chunk.Count < 1) 
                return self;

            if (chunk.Skip <= self.Length)
            {
                var a1 = self.Skip(chunk.Skip).Take(chunk.Count).ToArray();
                chunk.Count = Math.Min(chunk.Count, a1.Length);
                return a1;
            }

            chunk.Skip = 0;
            chunk.Count = self.Length;
            return self;
        }
        
        public static ReadChunk Next(this ReadChunk self)
        {
            self.Skip += self.Count;
            return self;
        }
    }
}