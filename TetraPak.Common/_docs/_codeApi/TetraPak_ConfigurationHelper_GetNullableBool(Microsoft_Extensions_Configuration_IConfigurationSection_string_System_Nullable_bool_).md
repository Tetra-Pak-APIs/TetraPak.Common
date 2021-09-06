#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[ConfigurationHelper](TetraPak_ConfigurationHelper.md 'TetraPak.ConfigurationHelper')
## ConfigurationHelper.GetNullableBool(IConfigurationSection, string, Nullable&lt;bool&gt;) Method
Gets a nullable [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') value from the section, or (optionally) a specified default value.  
```csharp
public static System.Nullable<bool> GetNullableBool(this Microsoft.Extensions.Configuration.IConfigurationSection section, string key, System.Nullable<bool> useDefault=null);
```
#### Parameters
<a name='TetraPak_ConfigurationHelper_GetNullableBool(Microsoft_Extensions_Configuration_IConfigurationSection_string_System_Nullable_bool_)_section'></a>
`section` [Microsoft.Extensions.Configuration.IConfigurationSection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfigurationSection 'Microsoft.Extensions.Configuration.IConfigurationSection')  
The configuration section.  
  
<a name='TetraPak_ConfigurationHelper_GetNullableBool(Microsoft_Extensions_Configuration_IConfigurationSection_string_System_Nullable_bool_)_key'></a>
`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the value.  
  
<a name='TetraPak_ConfigurationHelper_GetNullableBool(Microsoft_Extensions_Configuration_IConfigurationSection_string_System_Nullable_bool_)_useDefault'></a>
`useDefault` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
(optional)<br/>  
A default value to be used if the requested [key](TetraPak_ConfigurationHelper_GetNullableBool(Microsoft_Extensions_Configuration_IConfigurationSection_string_System_Nullable_bool_).md#TetraPak_ConfigurationHelper_GetNullableBool(Microsoft_Extensions_Configuration_IConfigurationSection_string_System_Nullable_bool_)_key 'TetraPak.ConfigurationHelper.GetNullableBool(Microsoft.Extensions.Configuration.IConfigurationSection, string, System.Nullable&lt;bool&gt;).key') is not found.  
  
#### Returns
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
A [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') value, or null if [key](TetraPak_ConfigurationHelper_GetNullableBool(Microsoft_Extensions_Configuration_IConfigurationSection_string_System_Nullable_bool_).md#TetraPak_ConfigurationHelper_GetNullableBool(Microsoft_Extensions_Configuration_IConfigurationSection_string_System_Nullable_bool_)_key 'TetraPak.ConfigurationHelper.GetNullableBool(Microsoft.Extensions.Configuration.IConfigurationSection, string, System.Nullable&lt;bool&gt;).key') was not found  
and no [useDefault](TetraPak_ConfigurationHelper_GetNullableBool(Microsoft_Extensions_Configuration_IConfigurationSection_string_System_Nullable_bool_).md#TetraPak_ConfigurationHelper_GetNullableBool(Microsoft_Extensions_Configuration_IConfigurationSection_string_System_Nullable_bool_)_useDefault 'TetraPak.ConfigurationHelper.GetNullableBool(Microsoft.Extensions.Configuration.IConfigurationSection, string, System.Nullable&lt;bool&gt;).useDefault') value was passed.  
