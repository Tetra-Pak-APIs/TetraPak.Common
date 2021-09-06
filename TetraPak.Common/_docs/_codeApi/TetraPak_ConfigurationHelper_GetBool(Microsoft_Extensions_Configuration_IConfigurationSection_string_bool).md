#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[ConfigurationHelper](TetraPak_ConfigurationHelper.md 'TetraPak.ConfigurationHelper')
## ConfigurationHelper.GetBool(IConfigurationSection, string, bool) Method
Gets a [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') value from the section, or a specified default value.  
```csharp
public static bool GetBool(this Microsoft.Extensions.Configuration.IConfigurationSection section, string key, bool useDefault);
```
#### Parameters
<a name='TetraPak_ConfigurationHelper_GetBool(Microsoft_Extensions_Configuration_IConfigurationSection_string_bool)_section'></a>
`section` [Microsoft.Extensions.Configuration.IConfigurationSection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfigurationSection 'Microsoft.Extensions.Configuration.IConfigurationSection')  
The configuration section.  
  
<a name='TetraPak_ConfigurationHelper_GetBool(Microsoft_Extensions_Configuration_IConfigurationSection_string_bool)_key'></a>
`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the value.  
  
<a name='TetraPak_ConfigurationHelper_GetBool(Microsoft_Extensions_Configuration_IConfigurationSection_string_bool)_useDefault'></a>
`useDefault` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
A default value to be used if the requested [key](TetraPak_ConfigurationHelper_GetBool(Microsoft_Extensions_Configuration_IConfigurationSection_string_bool).md#TetraPak_ConfigurationHelper_GetBool(Microsoft_Extensions_Configuration_IConfigurationSection_string_bool)_key 'TetraPak.ConfigurationHelper.GetBool(Microsoft.Extensions.Configuration.IConfigurationSection, string, bool).key') is not found.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
A [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') value.  
