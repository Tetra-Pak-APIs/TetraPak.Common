#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging').[StateDumpOptions](TetraPak_Logging_StateDumpOptions.md 'TetraPak.Logging.StateDumpOptions')
## StateDumpOptions.TryGetOverridden(string, string?) Method
Returns a value indicating whether a specified option is overridden.  
Also passes the overridden value when assigned.   
```csharp
public bool TryGetOverridden(string option, out string? value);
```
#### Parameters
<a name='TetraPak_Logging_StateDumpOptions_TryGetOverridden(string_string_)_option'></a>
`option` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the option.  
  
<a name='TetraPak_Logging_StateDumpOptions_TryGetOverridden(string_string_)_value'></a>
`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The overridden value, when assigned; otherwise `null`.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if [option](TetraPak_Logging_StateDumpOptions_TryGetOverridden(string_string_).md#TetraPak_Logging_StateDumpOptions_TryGetOverridden(string_string_)_option 'TetraPak.Logging.StateDumpOptions.TryGetOverridden(string, string?).option') was overridden; otherwise `false`.  
            
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
The [option](TetraPak_Logging_StateDumpOptions_TryGetOverridden(string_string_).md#TetraPak_Logging_StateDumpOptions_TryGetOverridden(string_string_)_option 'TetraPak.Logging.StateDumpOptions.TryGetOverridden(string, string?).option') was unassigned or blank.  
#### See Also
- [WithOverride(string, string?, bool)](TetraPak_Logging_StateDumpOptions_WithOverride(string_string__bool).md 'TetraPak.Logging.StateDumpOptions.WithOverride(string, string?, bool)')
