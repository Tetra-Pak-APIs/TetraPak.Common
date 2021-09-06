#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging')
## ILogEntry Interface
Implementors of this interface represents an individual entry in a log.  
```csharp
public interface ILogEntry
```

| Properties | |
| :--- | :--- |
| [Id](TetraPak_Logging_ILogEntry_Id.md 'TetraPak.Logging.ILogEntry.Id') | Gets a unique if. Can be used to reference a specific entry in support scenarios.<br/> |
| [Message](TetraPak_Logging_ILogEntry_Message.md 'TetraPak.Logging.ILogEntry.Message') | Get the log message.<br/> |
| [Rank](TetraPak_Logging_ILogEntry_Rank.md 'TetraPak.Logging.ILogEntry.Rank') | Gets the log rank (see [LogRank](TetraPak_Logging_LogRank.md 'TetraPak.Logging.LogRank')).<br/> |
| [Time](TetraPak_Logging_ILogEntry_Time.md 'TetraPak.Logging.ILogEntry.Time') | Gets the log entry timestamp (should be UTC).<br/> |
