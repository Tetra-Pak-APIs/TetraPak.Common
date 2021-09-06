#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak')
## ConfigurationHelper Class
Provides convenience extension methods for managing configuration.   
```csharp
public static class ConfigurationHelper
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ConfigurationHelper  

| Methods | |
| :--- | :--- |
| [GetBool(IConfigurationSection, string, bool)](TetraPak_ConfigurationHelper_GetBool(Microsoft_Extensions_Configuration_IConfigurationSection_string_bool).md 'TetraPak.ConfigurationHelper.GetBool(Microsoft.Extensions.Configuration.IConfigurationSection, string, bool)') | Gets a [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') value from the section, or a specified default value.<br/> |
| [GetNullableBool(IConfigurationSection, string, Nullable&lt;bool&gt;)](TetraPak_ConfigurationHelper_GetNullableBool(Microsoft_Extensions_Configuration_IConfigurationSection_string_System_Nullable_bool_).md 'TetraPak.ConfigurationHelper.GetNullableBool(Microsoft.Extensions.Configuration.IConfigurationSection, string, System.Nullable&lt;bool&gt;)') | Gets a nullable [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') value from the section, or (optionally) a specified default value.<br/> |
| [GetWebEnvironment(IConfiguration)](TetraPak_ConfigurationHelper_GetWebEnvironment(Microsoft_Extensions_Configuration_IConfiguration).md 'TetraPak.ConfigurationHelper.GetWebEnvironment(Microsoft.Extensions.Configuration.IConfiguration)') | Gets the name of the running ASP.NET Core environment<br/>("`ASPNETCORE_ENVIRONMENT`" environment variable). <br/> |
| [IsWebDevelopment(IConfiguration)](TetraPak_ConfigurationHelper_IsWebDevelopment(Microsoft_Extensions_Configuration_IConfiguration).md 'TetraPak.ConfigurationHelper.IsWebDevelopment(Microsoft.Extensions.Configuration.IConfiguration)') | Gets a [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') value indicating whether the process is running in development mode.<br/> |
| [TryParseConfiguredBool(string, bool)](TetraPak_ConfigurationHelper_TryParseConfiguredBool(string_bool).md 'TetraPak.ConfigurationHelper.TryParseConfiguredBool(string, bool)') | Parses a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as a configured [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') value. <br/> |
| [TryParseConfiguredTimeSpan(string, TimeSpan)](TetraPak_ConfigurationHelper_TryParseConfiguredTimeSpan(string_System_TimeSpan).md 'TetraPak.ConfigurationHelper.TryParseConfiguredTimeSpan(string, System.TimeSpan)') | Parses a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as a configured [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') value. <br/> |
