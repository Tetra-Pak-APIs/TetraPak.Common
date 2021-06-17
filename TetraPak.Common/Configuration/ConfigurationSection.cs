﻿using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace TetraPak.Configuration
{
    /// <summary>
    ///   Provides access to the configuration framework through a POCO class. 
    /// </summary>
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
        ///   Must be overridden. Returns the expected configuration section identifier like in this example:<br/>
        ///   <code>
        ///   "MySection": {
        ///     :
        ///   }
        ///   </code>
        /// </summary>
        protected abstract string SectionIdentifier { get; }
        
        /// <summary>
        ///   Gets the encapsulated <see cref="IConfigurationSection"/>.  
        /// </summary>
        public IConfigurationSection Section { get; }

        /// <summary>
        ///   Gets a logger.
        /// </summary>
        public ILogger Logger { get; } 

        string getSectionIdentifier() => SectionIdentifier;

        protected virtual FieldInfo OnGetField(string fieldName)
        {
            return GetType().GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
        }
        
        /// <summary>
        ///   Reads a value from field-behind (name convention based on property). If the field is null
        ///   the value is read from the configuration section and. If the configuration section also
        ///   doesn't supported the value the method returns the <paramref name="useDefault"/> value. 
        /// </summary>
        protected T GetFromFieldThenSection<T>(T useDefault = default, ValueParser<T> parser = null, [CallerMemberName] string propertyName = null)
        {
            if (tryGetFieldValue(out var fieldValue))
                return fieldValue;

            if (parser is null)
            {
                // automatically support boolean values 
                if (typeof(T) == typeof(bool))
                    return Section[propertyName].TryParseConfiguredBool(out var boolValue)
                        ? (T) Convert.ChangeType(boolValue, typeof(T))
                        : useDefault;

                if (typeof(T) == typeof(TimeSpan))
                    return Section[propertyName].TryParseConfiguredTimeSpan(out var timeSpanValue)
                        ? (T) Convert.ChangeType(timeSpanValue, typeof(T))
                        : useDefault;
                    
                return Section.GetValue(propertyName, useDefault);
            }
            
            var stringValue = Section[propertyName];
            if (stringValue is { })
                return parser(stringValue, out var sectionValue) ? sectionValue : useDefault;

            return Section.GetValue(propertyName, useDefault);

            bool tryGetFieldValue(out T value)
            {
                value = default;
                var fieldName = $"_{propertyName.ToLowerInitial()}";
                var field = OnGetField(fieldName);
                var o = field?.GetValue(this);
                if (o is not T tValue)
                    return false;

                value = tValue;
                return true;
            }
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
            IConfiguration configuration, 
            ILogger logger,
            string sectionIdentifier = null)
        {
            Section = configuration?.GetSection(sectionIdentifier ?? getSectionIdentifier());
            IsEmpty = !Section?.GetChildren().Any() ?? true; 
            Logger = logger;
        }
    }
    
    public delegate bool ValueParser<T>(string stringValue, out T value);
}