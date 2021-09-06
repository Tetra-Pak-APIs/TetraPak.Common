#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[ConfigurationHelper](TetraPak_ConfigurationHelper.md 'TetraPak.ConfigurationHelper')
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
`true` if [stringValue](TetraPak_ConfigurationHelper_TryParseConfiguredTimeSpan(string_System_TimeSpan).md#TetraPak_ConfigurationHelper_TryParseConfiguredTimeSpan(string_System_TimeSpan)_stringValue 'TetraPak.ConfigurationHelper.TryParseConfiguredTimeSpan(string, System.TimeSpan).stringValue') was successfully parsed; otherwise `false`.  
            
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
  
