#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging').[StateDump](TetraPak_Logging_StateDump.md 'TetraPak.Logging.StateDump')
## StateDump.ToString(string) Method
Returns the [StateDump](TetraPak_Logging_StateDump.md 'TetraPak.Logging.StateDump')'s textual representation.  
```csharp
public string ToString(string caption);
```
#### Parameters
<a name='TetraPak_Logging_StateDump_ToString(string)_caption'></a>
`caption` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
(optional; default="STATE DUMP)<br/>  
A caption to be included in the state dump prefix and suffix elements.  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') presenting the state dump, with a prefix/suffix pair for easy recognition.   
