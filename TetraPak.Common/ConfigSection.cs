using System;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace tetrapak
{
    public abstract class ConfigSection
    {
        void assignProperties(IConfigurationSection configuration)
        {
            var properties = GetType().GetProperties();
            foreach (var property in properties.Where(i => i.CanWrite))
            {
                try
                {
                    var value = configuration[property.Name];
                    if (value is { })
                    {
                        if (property.PropertyType != typeof(string))
                        {
                            var obj = Convert.ChangeType(value, property.PropertyType);
                            property.SetValue(this, obj);
                            continue;
                        }
                        property.SetValue(this, value);
                    }
                }
                catch (Exception e) // nisse
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        protected ConfigSection(IConfiguration configuration, string sectionId)
        {
            var section = configuration.GetSection(sectionId ?? throw new ArgumentNullException(nameof(sectionId)));
            if (!section.GetChildren().Any())
                throw new InvalidOperationException($"Missing configuration section '{sectionId}'");

            assignProperties(section);
        }
    }

    public static class ConfigurationHelper
    {
        public static bool IsDevelopment(this IConfiguration self)
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", EnvironmentVariableTarget.Process);
            return environment == "Development";
        }

        public static bool? GetNullableBool(this IConfigurationSection section, string key, bool? useDefault = null)
        {
            var s = section[key];
            if (string.IsNullOrEmpty(s))
                return useDefault;

            if (bool.TryParse(s, out var boolValue))
                return boolValue;

            switch (s)
            {
                case "1":
                    return true;
                case "0":
                    return false;
            }

            if (s.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
                return true;
            if (s.Equals("no", StringComparison.InvariantCultureIgnoreCase))
                return false;

            return useDefault;
        }
    }
}