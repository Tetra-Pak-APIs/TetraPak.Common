using System;
using System.Diagnostics;
using System.Linq;
using System.Text.Json.Serialization;
using TetraPak.Serialization;

namespace TetraPak
{
    [JsonConverter(typeof(JsonStringValueSerializer<CommandLineArgs>))]
    [DebuggerDisplay("{" + nameof(StringValue) + "}")]
    public class CommandLineArgs : IStringValue
    {
        readonly string[] _args;
        readonly bool _ignoreCase;

        /// <inheritdoc />
        public string StringValue { get; }

        public string[] Items => _args;

        /// <summary>
        ///   Initializes the value.
        /// </summary>
        /// <param name="args">
        ///   The command line arguments to be represented as a value.
        /// </param>
        /// <param name="ignoreCase">
        ///   (optional; default=<c>false</c>)<br/>
        ///   Specifies whether command line keys are case sensitive when looking up values (see <see cref="Get"/>).
        /// </param>
        /// <exception cref="FormatException">
        ///   The <paramref name="args"/> string representation was incorrectly formed.
        /// </exception>
        [DebuggerStepThrough]
        public CommandLineArgs(string[] args, bool ignoreCase = false)
        {
            StringValue = args.ConcatCollection(" ") ?? throw new ArgumentNullException(nameof(args));
            _args = args;
            _ignoreCase = ignoreCase;
        }

        /// <summary>
        ///   Looks for and returns a value identified by one or more keys.
        /// </summary>
        /// <param name="keys">
        ///   One or more keys to look for.
        /// </param>
        /// <returns></returns>
        public Outcome<string> Get(params string[] keys)
        {
            if (!keys.Any())
                return Outcome<string>.Fail(
                    new ArgumentOutOfRangeException(nameof(keys), $"No value found for key(s): {keys.ConcatCollection(" ")}"));

            var index = -1;
            var i = -1;
            var comparison = _ignoreCase ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture;
            foreach (var s in _args)
            {
                ++i;
                if (!keys.Any(i => i.Equals(s, comparison))) 
                    continue;
                
                index = i;
                break;
            }
            
            return index == -1 
                ? Outcome<string>.Fail(new ArgumentOutOfRangeException(nameof(keys), $"Value not found: {keys.ConcatCollection(" | ")}")) 
                : getValueForIndex(index);
        }

        Outcome<string> getValueForIndex(int index)
        {
            if (index+1 >= _args.Length)
                return Outcome<string>.Success(_args[index]);

            return isKey(index + 1)
                ? Outcome<string>.Success(_args[index])
                : Outcome<string>.Success(_args[index + 1]);
        }

        bool isKey(int index)
        {
            var s = _args[index];
            return s.StartsWith("-");
        }

        /// <summary>
        ///   Implicitly converts a string literal into a <see cref="CommandLineArgs"/>.
        /// </summary>
        /// <param name="stringValue">
        ///   A string representation of the <see cref="CommandLineArgs"/> value.
        /// </param>
        /// <returns>
        ///   A <see cref="CommandLineArgs"/> value.
        /// </returns>
        /// <exception cref="FormatException">
        ///   The <paramref name="stringValue"/> string representation was incorrectly formed.
        /// </exception>
        public static implicit operator CommandLineArgs(string stringValue) => new CommandLineArgs(stringValue.Split(" ", StringSplitOptions.RemoveEmptyEntries));

        /// <summary>
        ///   Implicitly converts a <see cref="CommandLineArgs"/> value into its <see cref="string"/> representation.
        /// </summary>
        /// <param name="value">
        ///   A <see cref="CommandLineArgs"/> value to be implicitly converted into its <see cref="string"/> representation.
        /// </param>
        /// <returns>
        ///   The <see cref="string"/> representation of <paramref name="value"/>.
        /// </returns>
        public static implicit operator string(CommandLineArgs value) => value?.StringValue;

        /// <inheritdoc />
        public override string ToString() => StringValue;

        #region .  Equality  .

        /// <summary>
        ///   Determines whether the specified value is equal to the current value.
        /// </summary>
        /// <param name="other">
        ///   A <see cref="CommandLineArgs"/> value to compare to this value.
        /// </param>
        /// <returns>
        ///   <c>true</c> if <paramref name="other"/> is equal to the current value; otherwise <c>false</c>.
        /// </returns>
        public bool Equals(CommandLineArgs other)
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
            return !(obj is null) && (obj is CommandLineArgs other && Equals(other));
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
        public static bool operator ==(CommandLineArgs left, CommandLineArgs right)
        {
            return left?.Equals(right) ?? right is null;
        }

        /// <summary>
        ///   Comparison operator overload.
        /// </summary>
        public static bool operator !=(CommandLineArgs left, CommandLineArgs right)
        {
            return !left?.Equals(right) ?? !(right is null);
        }

        #endregion
    }

}