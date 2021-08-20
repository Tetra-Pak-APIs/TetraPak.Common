using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;

namespace TetraPak.Logging
{
     /// <summary>
    ///   Used to specify data for getting the current state.
    /// </summary>
    public class StateDumpOptions : IDictionary<string,bool>
    {
        readonly IDictionary<string, bool> _options = new Dictionary<string, bool>();
        readonly IDictionary<string, string> _overridden = new Dictionary<string, string>();

        /// <summary>
        ///   Specifies whether to also include potentially secret information, such as secrets
        ///   (default = <c>false</c>).
        /// </summary>
        public bool DiscloseSensitiveData
        {
            get => getOption();
            set => setOption(value);
        }

        internal bool IsSet(string option, bool useDefault = false)
        {
            return _options.TryGetValue(option, out var value) 
                ? value
                : useDefault;
        }

        bool getOption(bool useDefault = true, [CallerMemberName] string option = null)
        {
            if (option is null)
                throw new ArgumentNullException();
            
            return _options.TryGetValue(option, out var value) ? value : useDefault;
        }

        void setOption(bool value, [CallerMemberName] string option = null)
        {
            if (option is null)
                throw new ArgumentNullException();
            
            _options[option] = value;
        }

        #region .  IDictionary  .

        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, bool>> GetEnumerator() => _options.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_options).GetEnumerator();

        /// <inheritdoc />
        public void Add(KeyValuePair<string, bool> item)
        {
            _options.Add(item);
        }

        /// <inheritdoc />
        public void Clear()
        {
            _options.Clear();
        }

        /// <inheritdoc />
        public bool Contains(KeyValuePair<string, bool> item)
        {
            return _options.Contains(item);
        }

        /// <inheritdoc />
        public void CopyTo(KeyValuePair<string, bool>[] array, int arrayIndex)
        {
            _options.CopyTo(array, arrayIndex);
        }

        /// <inheritdoc />
        public bool Remove(KeyValuePair<string, bool> item)
        {
            return _options.Remove(item);
        }

        /// <inheritdoc />
        public int Count => _options.Count;

        /// <inheritdoc />
        public bool IsReadOnly => _options.IsReadOnly;

        /// <inheritdoc />
        public void Add(string key, bool value)
        {
            _options.Add(key, value);
        }

        /// <inheritdoc />
        public bool ContainsKey(string key)
        {
            return _options.ContainsKey(key);
        }

        /// <inheritdoc />
        public bool Remove(string key)
        {
            return _options.Remove(key);
        }

        /// <inheritdoc />
        public bool TryGetValue(string key, out bool value)
        {
            return _options.TryGetValue(key, out value);
        }

        /// <inheritdoc />
        public bool this[string key]
        {
            get => _options[key];
            set => _options[key] = value;
        }

        /// <inheritdoc />
        public ICollection<string> Keys => _options.Keys;

        /// <inheritdoc />
        public ICollection<bool> Values => _options.Values;

        #endregion

        void populateDefault(object o, LogLevel minimumLogLevel)
        {
            setOption(false, nameof(DiscloseSensitiveData));
            // populateSubOptions(ambientData);
            populateOptions(o);
            
            void populateOptions(object data)
            {
                var properties = new Dictionary<PropertyInfo, LogLevel>();
                var propertyInfos = data.GetType().GetProperties()
                    .Where(i =>
                    {
                        if (!i.CanRead || i.IsIndexer())
                            return false;
                            
                        var attribute = i.GetCustomAttribute<StateDumpAttribute>();
                        if (attribute is null)
                            return false;

                        properties[i] = attribute.LogLevel;
                        return true;
                        
                    })
                    .ToArray();
                
                if (!propertyInfos.Any())
                    return;

                // var subOptions = new StateDumpOptions(); obsolete
                foreach (var (propertyInfo, logLevel) in properties)
                {
                    var include = logLevel >= minimumLogLevel;
                    setOption(include, propertyInfo.Name);
                }

                // _subOptions.Add(data.GetType().Name); obsolete
            }
        }

        /// <summary>
        ///   Ensures one or more values do not get dumped.
        ///   This might be for security reasons or to reduce the amount of state, improving clarity. 
        /// </summary>
        /// <param name="ignoredOptions">
        ///   Identifies one or more options to be ignored. 
        /// </param>
        /// <returns>
        ///   This <see cref="StateDumpOptions"/> object.
        /// </returns>
        public StateDumpOptions WithIgnored(params string[] ignoredOptions)
        {
            foreach (var option in ignoredOptions)
            {
                if (_options.ContainsKey(option))
                {
                    setOption(false, option);
                }

                if (_overridden.ContainsKey(option))
                {
                    _overridden.Remove(option);
                }
            }

            return this;
        }

        /// <summary>
        ///   Overrides the value of a specified dumped option's state.
        /// </summary>
        /// <param name="option">
        ///   Identifies the option to override.
        /// </param>
        /// <param name="value">
        ///   A value to be dumped.
        /// </param>
        /// <param name="soft">
        ///   (optional; default=<c>true</c>)<br/>
        ///   Specifies whether to only override the value if it is set (scheduled to be dumped) and
        ///   the overridden value is itself an assigned string (not <c>null</c>).
        ///   If <c>false</c>, a "hard override" will take place and the value will be dumped
        ///   (with the overriden value) either way.
        /// </param>
        /// <returns>
        ///   This <see cref="StateDumpOptions"/> object.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        ///   The <paramref name="option"/> was unassigned or blank.
        /// </exception>
        /// <seealso cref="TryGetOverridden"/>
        public StateDumpOptions WithOverride(string option, string value, bool soft = true)
        {
            if (string.IsNullOrWhiteSpace(option)) throw new ArgumentNullException(nameof(option));
            if (soft && value is null || !IsSet(option))
                return this;
            
            _overridden[option] = value;
            return this;
        }

        /// <summary>
        ///   Returns a value indicating whether a specified option is overridden.
        ///   Also passes the overridden value when assigned. 
        /// </summary>
        /// <param name="option">
        ///   Identifies the option.
        /// </param>
        /// <param name="value">
        ///   The overridden value, when assigned; otherwise <c>null</c>.
        /// </param>
        /// <returns>
        ///   <c>true</c> if <paramref name="option"/> was overridden; otherwise <c>false</c>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        ///   The <paramref name="option"/> was unassigned or blank.
        /// </exception>
        /// <seealso cref="WithOverride"/>
        public bool TryGetOverridden(string option, out string value)
        {
            if (string.IsNullOrWhiteSpace(option)) throw new ArgumentNullException(nameof(option));
            return _overridden.TryGetValue(option, out value);
        }

        /// <summary>
        ///   Returns a value indicating whether a specified option is overridden.
        /// </summary>
        /// <param name="option">
        ///   Identifies the option.
        /// </param>
        /// <returns>
        ///   <c>true</c> if <paramref name="option"/> was overridden; otherwise <c>false</c>.
        /// </returns>
        public bool IsOverridden(string option) => _overridden.ContainsKey(option);

        /// <summary>
        ///   Initializes the <see cref="StateDumpOptions"/> with default options.
        /// </summary>
        public StateDumpOptions(object obj, LogLevel minimumLogLevel)
        {
            populateDefault(obj, minimumLogLevel);
        }
    }
}