#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging').[StateDumpOptions](TetraPak_Logging_StateDumpOptions.md 'TetraPak.Logging.StateDumpOptions')
## StateDumpOptions.WithIgnored(string[]) Method
Ensures one or more values do not get dumped.  
This might be for security reasons or to reduce the amount of state, improving clarity.   
```csharp
public TetraPak.Logging.StateDumpOptions WithIgnored(params string[] ignoredOptions);
```
#### Parameters
<a name='TetraPak_Logging_StateDumpOptions_WithIgnored(string__)_ignoredOptions'></a>
`ignoredOptions` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Identifies one or more options to be ignored.   
  
#### Returns
[StateDumpOptions](TetraPak_Logging_StateDumpOptions.md 'TetraPak.Logging.StateDumpOptions')  
This [StateDumpOptions](TetraPak_Logging_StateDumpOptions.md 'TetraPak.Logging.StateDumpOptions') object.  
