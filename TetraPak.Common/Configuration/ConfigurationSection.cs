using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

#nullable enable

namespace TetraPak.Configuration
{
    /// <summary>
    ///   Provides access to the configuration framework through a POCO class. 
    /// </summary>
    [DebuggerDisplay("{" + nameof(ConfigPath) + "}")]
    public abstract class ConfigurationSection 
    {
        /// <summary>
        ///   Gets a value that indicates whether the configuration section contains no information. 
        /// </summary>
        [JsonIgnore] 
        // ReSharper disable once MemberCanBePrivate.Global
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public bool IsEmpty { get; }

        /// <summary>
        ///   Can be overridden. Returns the expected configuration section identifier like in this example:<br/>
        ///   <code>
        ///   "MySection": {
        ///     :
        ///   }
        ///   </code>
        /// </summary>
        protected virtual string SectionIdentifier { get; set; }
        
        /// <summary>
        ///   Gets the encapsulated <see cref="IConfigurationSection"/>.  
        /// </summary>
        public IConfigurationSection? Section { get; private set; }

        /// <summary>
        ///   Gets the parent <see cref="IConfiguration"/> section
        ///   (or <c>null</c> if this section is also the configuration root).
        /// </summary>
        public IConfiguration? ParentConfiguration { get; }
        
        /// <summary>
        ///   Gets a logger.
        /// </summary>
        public ILogger? Logger { get; }

        public ConfigPath? ConfigPath { get; protected set; }
        
        string getSectionKey(ConfigPath? sectionIdentifier, IConfiguration? configuration)
        {
            if (sectionIdentifier?.IsEmpty ?? true)
            {
                sectionIdentifier = SectionIdentifier;
            }
            if (sectionIdentifier.Count == 1)
                return sectionIdentifier;

            if (configuration is not IConfigurationSection section) 
                return sectionIdentifier;
            
            var sectionPath = (ConfigPath) section.Path;
            return sectionIdentifier.StartsWith(sectionPath) 
                ? sectionIdentifier.TrimFirst(sectionPath.Count) 
                : sectionIdentifier;
        }

        /// <summary>
        ///   Obtains a <see cref="FieldInfo"/> object for a specified field.
        /// </summary>
        /// <param name="fieldName">
        ///   Identifies the requested field.
        /// </param>
        /// <returns>
        ///   A <see cref="FieldInfo"/> object.
        /// </returns>
        protected virtual FieldInfo? OnGetField(string fieldName)
        {
            return GetType().GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
        }

        internal bool TryGetFieldValue<T>(string propertyName, out T value)
        {
            value = default!;
            var fieldName = $"_{propertyName.ToLowerInitial()}";
            var field = OnGetField(fieldName);
            var o = field?.GetValue(this);
            if (o is not T tValue)
                return false;

            value = tValue;
            return true;
        }

        internal void SetFieldValue(string propertyName, object value)
        {
            var fieldName = $"_{propertyName.ToLowerInitial()}";
            var field = OnGetField(fieldName);
            field?.SetValue(this, value);
        }
        
        /// <summary>
        ///   Reads a value from field-behind (name convention based on property). If the field is null
        ///   the value is read from the configuration section and. If the configuration section also
        ///   doesn't supported the value the method returns the <paramref name="useDefault"/> value. 
        /// </summary>
        protected T? GetFromFieldThenSection<T>(
            T? useDefault = default, 
            ValueParser<T>? parser = null, 
            [CallerMemberName] string propertyName = null!)
        {
            if (TryGetFieldValue<T>(propertyName, out var fieldValue))
                return fieldValue;

            if (parser is null)
            {
                // automatically support string value 
                var s = Section?[propertyName];
                if (typeof(T) == typeof(string))
                    return string.IsNullOrEmpty(s)
                            ? useDefault!
                            : (T) Convert.ChangeType(s, typeof(T));
                
                if (typeof(IStringValue).IsAssignableFrom(typeof(T)))
                {
                    return string.IsNullOrEmpty(s)
                        ? useDefault
                        : (T?) Convert.ChangeType(StringValueBase.MakeStringValue<T>(s), typeof(T)); 
                }
                
                // automatically support boolean values 
                if (typeof(T) == typeof(bool) && Section is {})
                    return Section[propertyName].TryParseConfiguredBool(out var boolValue)
                        ? (T) Convert.ChangeType(boolValue, typeof(T))
                        : useDefault!;

                // automatically support TimeSpan values 
                if (typeof(T) == typeof(TimeSpan) && Section is {})
                    return Section[propertyName].TryParseConfiguredTimeSpan(out var timeSpanValue)
                        ? (T) Convert.ChangeType(timeSpanValue, typeof(T))
                        : useDefault!;

                return Section.GetValue(propertyName, useDefault!);
            }

            var stringValue = Section[propertyName];
            return parser(stringValue, out var sectionValue) ? sectionValue : useDefault!;
        }

        void setSectionIdentifier(string? value)
        {
            if (value?.Contains(ConfigPath.Separator) ?? false)
            {
                var configPath = (ConfigPath) value;
                SectionIdentifier = configPath.CopyLast();
                ConfigPath = value;
            }
            else
            {
                SectionIdentifier = value!;
                ConfigPath = ParentConfiguration is IConfigurationSection section
                    ? $"{section.Path}:{value}"
                    : value; 
                
            }
        }
        
        protected void SetSection(IConfiguration value)
        {
            if (value is not IConfigurationSection section)
                throw new ArgumentException("Value is not a configuration section", nameof(value));
            
            Section = section;
        }


        /// <summary>
        ///   Instantiates a <see cref="ConfigurationSection"/>.
        /// </summary>
        /// <param name="configuration">
        ///   The <see cref="IConfiguration"/> instance that contains the configuration section to be encapsulated.
        /// </param>
        /// <param name="logger">
        ///   Initializes the <see cref="Logger"/> value.
        /// </param>
        /// <param name="sectionIdentifier">
        ///   (optional; default=value from <see cref="SectionIdentifier"/>)<br/>
        ///   Specifies the configuration section to be encapsulated. 
        /// </param>
        public ConfigurationSection(
            IConfiguration? configuration, 
            ILogger? logger,
            ConfigPath? sectionIdentifier = null)
        {
            ParentConfiguration = configuration;
            setSectionIdentifier(sectionIdentifier);
            var sectionKey = getSectionKey(sectionIdentifier, configuration);
            Section = configuration?.GetSection(sectionKey);
            IsEmpty = Section?.IsEmpty() ?? true; 
            Logger = logger;
            ConfigPath = sectionIdentifier;
        }

        protected ConfigurationSection()
        {
        }
    }
}