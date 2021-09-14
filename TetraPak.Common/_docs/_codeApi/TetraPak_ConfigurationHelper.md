#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak')
## ConfigurationHelper Class
Provides convenience extension methods for managing configuration.   
```csharp
public static class ConfigurationHelper
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ConfigurationHelper  
### Methods
<a name='TetraPak_ConfigurationHelper_GetBool(Microsoft_Extensions_Configuration_IConfigurationSection_string_bool)'></a>
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
A default value to be used if the requested [key](TetraPak_ConfigurationHelper.md#TetraPak_ConfigurationHelper_GetBool(Microsoft_Extensions_Configuration_IConfigurationSection_string_bool)_key 'TetraPak.ConfigurationHelper.GetBool(Microsoft.Extensions.Configuration.IConfigurationSection, string, bool).key') is not found.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
A [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') value.  
  
<a name='TetraPak_ConfigurationHelper_GetNullableBool(Microsoft_Extensions_Configuration_IConfigurationSection_string_System_Nullable_bool_)'></a>
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
A default value to be used if the requested [key](TetraPak_ConfigurationHelper.md#TetraPak_ConfigurationHelper_GetNullableBool(Microsoft_Extensions_Configuration_IConfigurationSection_string_System_Nullable_bool_)_key 'TetraPak.ConfigurationHelper.GetNullableBool(Microsoft.Extensions.Configuration.IConfigurationSection, string, System.Nullable&lt;bool&gt;).key') is not found.  
  
#### Returns
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
A [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') value, or null if [key](TetraPak_ConfigurationHelper.md#TetraPak_ConfigurationHelper_GetNullableBool(Microsoft_Extensions_Configuration_IConfigurationSection_string_System_Nullable_bool_)_key 'TetraPak.ConfigurationHelper.GetNullableBool(Microsoft.Extensions.Configuration.IConfigurationSection, string, System.Nullable&lt;bool&gt;).key') was not found  
and no [useDefault](TetraPak_ConfigurationHelper.md#TetraPak_ConfigurationHelper_GetNullableBool(Microsoft_Extensions_Configuration_IConfigurationSection_string_System_Nullable_bool_)_useDefault 'TetraPak.ConfigurationHelper.GetNullableBool(Microsoft.Extensions.Configuration.IConfigurationSection, string, System.Nullable&lt;bool&gt;).useDefault') value was passed.  
  
<a name='TetraPak_ConfigurationHelper_GetWebEnvironment(Microsoft_Extensions_Configuration_IConfiguration)'></a>
## ConfigurationHelper.GetWebEnvironment(IConfiguration) Method
Gets the name of the running ASP.NET Core environment  
("`ASPNETCORE_ENVIRONMENT`" environment variable).   
```csharp
public static string GetWebEnvironment(this Microsoft.Extensions.Configuration.IConfiguration _);
```
#### Parameters
<a name='TetraPak_ConfigurationHelper_GetWebEnvironment(Microsoft_Extensions_Configuration_IConfiguration)__'></a>
`_` [Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration')  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the running ASP.NET Core web environment.  
  
<a name='TetraPak_ConfigurationHelper_IsWebDevelopment(Microsoft_Extensions_Configuration_IConfiguration)'></a>
## ConfigurationHelper.IsWebDevelopment(IConfiguration) Method
Gets a [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') value indicating whether the process is running in development mode.  
```csharp
public static bool IsWebDevelopment(this Microsoft.Extensions.Configuration.IConfiguration self);
```
#### Parameters
<a name='TetraPak_ConfigurationHelper_IsWebDevelopment(Microsoft_Extensions_Configuration_IConfiguration)_self'></a>
`self` [Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration')  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the web host is running in development mode; otherwise `false`.   
            
  
<a name='TetraPak_ConfigurationHelper_TryParseConfiguredBool(string_bool)'></a>
## ConfigurationHelper.TryParseConfiguredBool(string, bool) Method
Parses a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as a configured [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') value.   
```csharp
public static bool TryParseConfiguredBool(this string stringValue, out bool value);
```
#### Parameters
<a name='TetraPak_ConfigurationHelper_TryParseConfiguredBool(string_bool)_stringValue'></a>
`stringValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The (configured) [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') string representation.  
  
<a name='TetraPak_ConfigurationHelper_TryParseConfiguredBool(string_bool)_value'></a>
`value` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Passes back the parsed boolean value.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if [stringValue](TetraPak_ConfigurationHelper.md#TetraPak_ConfigurationHelper_TryParseConfiguredBool(string_bool)_stringValue 'TetraPak.ConfigurationHelper.TryParseConfiguredBool(string, bool).stringValue') was successfully parsed; otherwise `false`.  
            
### Remarks
A configured [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') value accepts three forms:  
<list type="bullet">  
  
/false</term>  
on>  
    - Just use standard C# identifiers <c>true</c> or <c>false</c> (not case sensitive).  
    </description>  
  
  
no</term>  
on>  
    - Use plain English words <c>yes</c> or <c>no</c> for true/false (not case sensitive).  
    </description>  
  
  
/term>  
on>  
    - Use numbers <c>1</c> or <c>0</c> for true/false.  
    </description>  
  
  
<a name='TetraPak_ConfigurationHelper_TryParseConfiguredTimeSpan(string_System_TimeSpan)'></a>
## ConfigurationHelper.TryParseConfiguredTimeSpan(string, TimeSpan) Method
Parses a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') as a configured [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') value.   
```csharp
public static bool TryParseConfiguredTimeSpan(this string stringValue, out System.TimeSpan value);
```
#### Parameters
<a name='TetraPak_ConfigurationHelper_TryParseConfiguredTimeSpan(string_System_TimeSpan)_stringValue'></a>
`stringValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The (configured) [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') string representation.  
  
<a name='TetraPak_ConfigurationHelper_TryParseConfiguredTimeSpan(string_System_TimeSpan)_value'></a>
`value` [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')  
Passes back the parsed [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') value.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if [stringValue](TetraPak_ConfigurationHelper.md#TetraPak_ConfigurationHelper_TryParseConfiguredTimeSpan(string_System_TimeSpan)_stringValue 'TetraPak.ConfigurationHelper.TryParseConfiguredTimeSpan(string, System.TimeSpan).stringValue') was successfully parsed; otherwise `false`.  
            
### Remarks
A configured [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') value accepts two forms:  
<list type="bullet">  
  
m:ss</term>  
on>  
    - Use standard C# syntax for <see cref="T:System.TimeSpan"/> string representation.  
    </description>  
  
  
nds</term>  
on>  
    - Use integer value to express <see cref="T:System.TimeSpan"/> in seconds.  
    </description>  
  
  
