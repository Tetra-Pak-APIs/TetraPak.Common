#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
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

        internal ILogger? Logger { get; private set; }

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
        public StateDumpOptions WithOverride(string option, string? value, bool soft = true)
        {
            if (string.IsNullOrWhiteSpace(option)) throw new ArgumentNullException(nameof(option));
            if (soft && value is null || !IsSet(option))
                return this;
            
            _overridden[option] = value!;
            return this;
        }
        
        /// <summary>
        ///   Specifies that restricted values (that will normally be dumped as redacted values) can be
        ///   disclosed for specified logger if that logger is declaring a <see cref="LogLevel"/> that
        ///   matches the restricted value's decorated <see cref="RestrictedValueAttribute.DisclosureLogLevels"/>. 
        /// </summary>
        /// <param name="logger">
        ///   A targeted logger provider.
        /// </param>
        /// <returns>
        ///   This object (fluent API).
        /// </returns>
        public StateDumpOptions WithTargetLogger(ILogger logger)
        {
            Logger = logger;
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
        public bool TryGetOverridden(string option, out string? value)
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
        
        internal bool IsSet(string option, bool useDefault = false)
        {
            return _options.TryGetValue(option, out var value) 
                ? value
                : useDefault;
        }

        void setOption(bool value, [CallerMemberName] string? option = null)
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

        void populateDefault(object o, Func<PropertyInfo, bool>? includeHandler)
        {
            populateOptions(o);
            
            void populateOptions(object data)
            {
                foreach (var i in data.GetType().GetProperties())
                {
                    if (!i.CanRead || i.IsIndexer())
                        continue;
                            
                    var attribute = i.GetCustomAttribute<StateDumpAttribute>();
                    if (attribute is null)
                        continue;

                    if (includeHandler?.Invoke(i) ?? true)
                        setOption(true, i.Name);
                }
            }
        }

        /// <summary>
        ///   Initializes the <see cref="StateDumpOptions"/> with default options.
        /// </summary>
        /// <param name="obj">
        ///   The object to be state dumped.
        /// </param>
        /// <param name="logger">
        ///   (optional)<br/>
        ///   A target logger provider. Adding this to the options is necessary if you need to disclose
        ///   restricted values, based on the declared <see cref="LogLevel"/>. 
        /// </param>
        /// <param name="includeHandler">
        ///   (optional)<br/>
        ///   When assigned this handler will be invoked for all decorated (<see cref="StateDumpAttribute"/>)
        ///   properties of <paramref name="obj"/> to return a value specifying whether to include the
        ///   property or not (the handler mist return <c>true</c> for the property to be included in state dump).
        /// </param>
        /// <seealso cref="RestrictedValueAttribute"/>
        public StateDumpOptions(object obj, ILogger? logger = null, Func<PropertyInfo,bool>? includeHandler = null)
        {
            Logger = logger;
            populateDefault(obj, includeHandler);
        }
    }
}