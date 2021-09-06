#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging').[StateDump](TetraPak_Logging_StateDump.md 'TetraPak.Logging.StateDump')
## StateDump.WithStackTrace(int) Method
Invoking this method will have a [StateDump](TetraPak_Logging_StateDump.md 'TetraPak.Logging.StateDump') include a stacktrace.     
```csharp
public TetraPak.Logging.StateDump WithStackTrace(int skipFrames=1);
```
#### Parameters
<a name='TetraPak_Logging_StateDump_WithStackTrace(int)_skipFrames'></a>
`skipFrames` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
(optional; default = 1)<br/>  
Specifies how many stacktrace frames to be removed from the end of the stacktrace.  
This is to avoid including frames representing calls to the state dump logic itself.  
  
#### Returns
[StateDump](TetraPak_Logging_StateDump.md 'TetraPak.Logging.StateDump')  
This object (fluent API).  
