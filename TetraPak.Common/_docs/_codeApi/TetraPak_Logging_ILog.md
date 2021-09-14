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
### Properties
<a name='TetraPak_Logging_ILog_QueryAsync'></a>
## ILog.QueryAsync Property
Gets or sets a delegate used for querying the log.  
```csharp
TetraPak.Logging.QueryAsyncDelegate QueryAsync { get; set; }
```
#### Property Value
[TetraPak.Logging.QueryAsyncDelegate](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Logging.QueryAsyncDelegate 'TetraPak.Logging.QueryAsyncDelegate')
  
### Methods
<a name='TetraPak_Logging_ILog_Any(string)'></a>
## ILog.Any(string) Method
Adds a log message for any log rank (such as a log section entry/exit.  
```csharp
void Any(string message);
```
#### Parameters
<a name='TetraPak_Logging_ILog_Any(string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The message to be logged.  
  
  
<a name='TetraPak_Logging_ILog_Debug(string)'></a>
## ILog.Debug(string) Method
Adds a message of rank [Debug](TetraPak_Logging_LogRank.md#TetraPak_Logging_LogRank_Debug 'TetraPak.Logging.LogRank.Debug').  
```csharp
void Debug(string message);
```
#### Parameters
<a name='TetraPak_Logging_ILog_Debug(string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A textual message to be logged.  
  
  
<a name='TetraPak_Logging_ILog_Error(System_Exception_string)'></a>
## ILog.Error(Exception, string) Method
Adds an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') and message of rank [Error](TetraPak_Logging_LogRank.md#TetraPak_Logging_LogRank_Error 'TetraPak.Logging.LogRank.Error').  
```csharp
void Error(System.Exception exception, string message=null);
```
#### Parameters
<a name='TetraPak_Logging_ILog_Error(System_Exception_string)_exception'></a>
`exception` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
An [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') to be logged.  
  
<a name='TetraPak_Logging_ILog_Error(System_Exception_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A textual message to be logged.  
  
  
<a name='TetraPak_Logging_ILog_Info(string)'></a>
## ILog.Info(string) Method
Adds a message of rank [Info](TetraPak_Logging_LogRank.md#TetraPak_Logging_LogRank_Info 'TetraPak.Logging.LogRank.Info').  
```csharp
void Info(string message);
```
#### Parameters
<a name='TetraPak_Logging_ILog_Info(string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A textual message to be logged.  
  
  
<a name='TetraPak_Logging_ILog_Warning(string)'></a>
## ILog.Warning(string) Method
Adds a message of rank [Warning](TetraPak_Logging_LogRank.md#TetraPak_Logging_LogRank_Warning 'TetraPak.Logging.LogRank.Warning').  
```csharp
void Warning(string message);
```
#### Parameters
<a name='TetraPak_Logging_ILog_Warning(string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A textual message to be logged.  
  
  
<a name='TetraPak_Logging_ILog_Write(TetraPak_Logging_LogRank_string_System_Exception)'></a>
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
  
  
### Events
<a name='TetraPak_Logging_ILog_Logged'></a>
## ILog.Logged Event
Triggered whenever a log entry gets added.  
```csharp
event Logged;
```
#### Event Type
[System.EventHandler&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.EventHandler-1 'System.EventHandler`1')[TextLogEventArgs](TetraPak_Logging_TextLogEventArgs.md 'TetraPak.Logging.TextLogEventArgs')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.EventHandler-1 'System.EventHandler`1')
  
