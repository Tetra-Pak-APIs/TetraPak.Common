#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging')
## ILog Interface
Provides a basic logging mechanism to the package.  
```csharp
public interface ILog :
System.IDisposable
```

Derived  
&#8627; [BasicLog](TetraPak_Logging_BasicLog.md 'TetraPak.Logging.BasicLog')  

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')  

| Properties | |
| :--- | :--- |
| [QueryAsync](TetraPak_Logging_ILog_QueryAsync.md 'TetraPak.Logging.ILog.QueryAsync') | Gets or sets a delegate used for querying the log.<br/> |

| Methods | |
| :--- | :--- |
| [Any(string)](TetraPak_Logging_ILog_Any(string).md 'TetraPak.Logging.ILog.Any(string)') | Adds a log message for any log rank (such as a log section entry/exit.<br/> |
| [Debug(string)](TetraPak_Logging_ILog_Debug(string).md 'TetraPak.Logging.ILog.Debug(string)') | Adds a message of rank [Debug](TetraPak_Logging_LogRank.md#TetraPak_Logging_LogRank_Debug 'TetraPak.Logging.LogRank.Debug').<br/> |
| [Error(Exception, string)](TetraPak_Logging_ILog_Error(System_Exception_string).md 'TetraPak.Logging.ILog.Error(System.Exception, string)') | Adds an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') and message of rank [Error](TetraPak_Logging_LogRank.md#TetraPak_Logging_LogRank_Error 'TetraPak.Logging.LogRank.Error').<br/> |
| [Info(string)](TetraPak_Logging_ILog_Info(string).md 'TetraPak.Logging.ILog.Info(string)') | Adds a message of rank [Info](TetraPak_Logging_LogRank.md#TetraPak_Logging_LogRank_Info 'TetraPak.Logging.LogRank.Info').<br/> |
| [Warning(string)](TetraPak_Logging_ILog_Warning(string).md 'TetraPak.Logging.ILog.Warning(string)') | Adds a message of rank [Warning](TetraPak_Logging_LogRank.md#TetraPak_Logging_LogRank_Warning 'TetraPak.Logging.LogRank.Warning').<br/> |
| [Write(LogRank, string, Exception)](TetraPak_Logging_ILog_Write(TetraPak_Logging_LogRank_string_System_Exception).md 'TetraPak.Logging.ILog.Write(TetraPak.Logging.LogRank, string, System.Exception)') | Another, more arbitrary, alternative to writing a log entry.<br/> |

| Events | |
| :--- | :--- |
| [Logged](TetraPak_Logging_ILog_Logged.md 'TetraPak.Logging.ILog.Logged') | Triggered whenever a log entry gets added.<br/> |
