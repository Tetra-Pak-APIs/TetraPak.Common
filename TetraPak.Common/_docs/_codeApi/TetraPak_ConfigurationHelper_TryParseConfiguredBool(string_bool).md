#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[ConfigurationHelper](TetraPak_ConfigurationHelper.md 'TetraPak.ConfigurationHelper')
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
`true` if [stringValue](TetraPak_ConfigurationHelper_TryParseConfiguredBool(string_bool).md#TetraPak_ConfigurationHelper_TryParseConfiguredBool(string_bool)_stringValue 'TetraPak.ConfigurationHelper.TryParseConfiguredBool(string, bool).stringValue') was successfully parsed; otherwise `false`.  
            
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
  
