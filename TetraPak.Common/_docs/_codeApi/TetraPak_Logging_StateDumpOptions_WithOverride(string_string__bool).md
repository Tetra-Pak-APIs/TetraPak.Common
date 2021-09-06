#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging').[StateDumpOptions](TetraPak_Logging_StateDumpOptions.md 'TetraPak.Logging.StateDumpOptions')
## StateDumpOptions.WithOverride(string, string?, bool) Method
Overrides the value of a specified dumped option's state.  
```csharp
public TetraPak.Logging.StateDumpOptions WithOverride(string option, string? value, bool soft=true);
```
#### Parameters
<a name='TetraPak_Logging_StateDumpOptions_WithOverride(string_string__bool)_option'></a>
`option` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the option to override.  
  
<a name='TetraPak_Logging_StateDumpOptions_WithOverride(string_string__bool)_value'></a>
`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A value to be dumped.  
  
<a name='TetraPak_Logging_StateDumpOptions_WithOverride(string_string__bool)_soft'></a>
`soft` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
(optional; default=`true`)<br/>  
Specifies whether to only override the value if it is set (scheduled to be dumped) and  
the overridden value is itself an assigned string (not `null`).  
If `false`, a "hard override" will take place and the value will be dumped  
(with the overriden value) either way.  
  
#### Returns
[StateDumpOptions](TetraPak_Logging_StateDumpOptions.md 'TetraPak.Logging.StateDumpOptions')  
This [StateDumpOptions](TetraPak_Logging_StateDumpOptions.md 'TetraPak.Logging.StateDumpOptions') object.  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
The [option](TetraPak_Logging_StateDumpOptions_WithOverride(string_string__bool).md#TetraPak_Logging_StateDumpOptions_WithOverride(string_string__bool)_option 'TetraPak.Logging.StateDumpOptions.WithOverride(string, string?, bool).option') was unassigned or blank.  
#### See Also
- [TryGetOverridden(string, string?)](TetraPak_Logging_StateDumpOptions_TryGetOverridden(string_string_).md 'TetraPak.Logging.StateDumpOptions.TryGetOverridden(string, string?)')
