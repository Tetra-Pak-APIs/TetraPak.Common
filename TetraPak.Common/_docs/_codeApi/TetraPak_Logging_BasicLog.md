#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging')
## BasicLog Class
Provides a very basic [ILog](TetraPak_Logging_ILog.md 'TetraPak.Logging.ILog') implementation.  
```csharp
public class BasicLog :
TetraPak.Logging.ILog,
System.IDisposable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; BasicLog  

Implements [ILog](TetraPak_Logging_ILog.md 'TetraPak.Logging.ILog'), [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')  
### Remarks
Invoking the different log methods of this implementation simply  
triggers the [Logged](TetraPak_Logging_BasicLog_Logged.md 'TetraPak.Logging.BasicLog.Logged') event. This can be utilized to  
dispatch the actual log entries to various logging solutions.  

| Properties | |
| :--- | :--- |
| [QueryAsync](TetraPak_Logging_BasicLog_QueryAsync.md 'TetraPak.Logging.BasicLog.QueryAsync') | Gets or sets a delegate used for querying the log.<br/> |

| Methods | |
| :--- | :--- |
| [Debug(string)](TetraPak_Logging_BasicLog_Debug(string).md 'TetraPak.Logging.BasicLog.Debug(string)') | Adds a message of rank [Debug](TetraPak_Logging_LogRank.md#TetraPak_Logging_LogRank_Debug 'TetraPak.Logging.LogRank.Debug').<br/> |
| [Error(Exception, string)](TetraPak_Logging_BasicLog_Error(System_Exception_string).md 'TetraPak.Logging.BasicLog.Error(System.Exception, string)') | Adds an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') and message of rank [Error](TetraPak_Logging_LogRank.md#TetraPak_Logging_LogRank_Error 'TetraPak.Logging.LogRank.Error').<br/> |
| [Info(string)](TetraPak_Logging_BasicLog_Info(string).md 'TetraPak.Logging.BasicLog.Info(string)') | Adds a message of rank [Info](TetraPak_Logging_LogRank.md#TetraPak_Logging_LogRank_Info 'TetraPak.Logging.LogRank.Info').<br/> |
| [Warning(string)](TetraPak_Logging_BasicLog_Warning(string).md 'TetraPak.Logging.BasicLog.Warning(string)') | Adds a message of rank [Warning](TetraPak_Logging_LogRank.md#TetraPak_Logging_LogRank_Warning 'TetraPak.Logging.LogRank.Warning').<br/> |

| Events | |
| :--- | :--- |
| [Logged](TetraPak_Logging_BasicLog_Logged.md 'TetraPak.Logging.BasicLog.Logged') | Triggered whenever a log entry gets added.<br/> |
