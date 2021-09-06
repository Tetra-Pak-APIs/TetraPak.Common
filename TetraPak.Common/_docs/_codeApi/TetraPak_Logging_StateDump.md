#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging')
## StateDump Class
Assists in creating a well formatted state dump of one or more objects.  
```csharp
public class StateDump
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; StateDump  

| Methods | |
| :--- | :--- |
| [Add(object, string?, StateDumpOptions?)](TetraPak_Logging_StateDump_Add(object_string__TetraPak_Logging_StateDumpOptions_).md 'TetraPak.Logging.StateDump.Add(object, string?, TetraPak.Logging.StateDumpOptions?)') | Adds an object (a "[source](TetraPak_Logging_StateDump_Add(object_string__TetraPak_Logging_StateDumpOptions_).md#TetraPak_Logging_StateDump_Add(object_string__TetraPak_Logging_StateDumpOptions_)_source 'TetraPak.Logging.StateDump.Add(object, string?, TetraPak.Logging.StateDumpOptions?).source')) to the state dump.<br/> |
| [ToString()](TetraPak_Logging_StateDump_ToString().md 'TetraPak.Logging.StateDump.ToString()') | Overrides the base method to also add a prefix and suffix to the state dump.<br/> |
| [ToString(string)](TetraPak_Logging_StateDump_ToString(string).md 'TetraPak.Logging.StateDump.ToString(string)') | Returns the [StateDump](TetraPak_Logging_StateDump.md 'TetraPak.Logging.StateDump')'s textual representation.<br/> |
| [WithStackTrace(int)](TetraPak_Logging_StateDump_WithStackTrace(int).md 'TetraPak.Logging.StateDump.WithStackTrace(int)') | Invoking this method will have a [StateDump](TetraPak_Logging_StateDump.md 'TetraPak.Logging.StateDump') include a stacktrace.   <br/> |
#### See Also
- [RestrictedValueAttribute](TetraPak_RestrictedValueAttribute.md 'TetraPak.RestrictedValueAttribute')
