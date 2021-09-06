#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging').[ILog](TetraPak_Logging_ILog.md 'TetraPak.Logging.ILog')
## ILog.Write(LogRank, string, Exception) Method
Another, more arbitrary, alternative to writing a log entry.  
```csharp
void Write(TetraPak.Logging.LogRank rank, string message, System.Exception exception=null);
```
#### Parameters
<a name='TetraPak_Logging_ILog_Write(TetraPak_Logging_LogRank_string_System_Exception)_rank'></a>
`rank` [LogRank](TetraPak_Logging_LogRank.md 'TetraPak.Logging.LogRank')  
Specifies the [LogRank](TetraPak_Logging_LogRank.md 'TetraPak.Logging.LogRank')
  
<a name='TetraPak_Logging_ILog_Write(TetraPak_Logging_LogRank_string_System_Exception)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The message to log.  
  
<a name='TetraPak_Logging_ILog_Write(TetraPak_Logging_LogRank_string_System_Exception)_exception'></a>
`exception` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
(optional)<br/>  
An exception to be logged with the log entry.   
  
