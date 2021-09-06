#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging')
## LogRank Enum
Used by the ([ILog](TetraPak_Logging_ILog.md 'TetraPak.Logging.ILog') based) logging mechanism  
to classify log entries.  
```csharp
public enum LogRank

```
#### Fields
<a name='TetraPak_Logging_LogRank_Any'></a>
`Any` 4  
Denotes any log rank.  
  
<a name='TetraPak_Logging_LogRank_Debug'></a>
`Debug` 0  
The lowest (most detailed) log rank.  
  
<a name='TetraPak_Logging_LogRank_Error'></a>
`Error` 3  
Denotes a logged exception.  
  
<a name='TetraPak_Logging_LogRank_Info'></a>
`Info` 1  
Logs "normal" operations.  
  
<a name='TetraPak_Logging_LogRank_Warning'></a>
`Warning` 2  
Logs potentially erroneous/invalid operations.  
  
