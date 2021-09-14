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
triggers the [Logged](TetraPak_Logging_BasicLog.md#TetraPak_Logging_BasicLog_Logged 'TetraPak.Logging.BasicLog.Logged') event. This can be utilized to  
dispatch the actual log entries to various logging solutions.  
### Properties
<a name='TetraPak_Logging_BasicLog_QueryAsync'></a>
## BasicLog.QueryAsync Property
Gets or sets a delegate used for querying the log.  
```csharp
public TetraPak.Logging.QueryAsyncDelegate QueryAsync { get; set; }
```
#### Property Value
[TetraPak.Logging.QueryAsyncDelegate](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Logging.QueryAsyncDelegate 'TetraPak.Logging.QueryAsyncDelegate')

Implements [QueryAsync](TetraPak_Logging_ILog.md#TetraPak_Logging_ILog_QueryAsync 'TetraPak.Logging.ILog.QueryAsync')  
  
### Methods
<a name='TetraPak_Logging_BasicLog_Debug(string)'></a>
## BasicLog.Debug(string) Method
Adds a message of rank [Debug](TetraPak_Logging_LogRank.md#TetraPak_Logging_LogRank_Debug 'TetraPak.Logging.LogRank.Debug').  
```csharp
public void Debug(string message);
```
#### Parameters
<a name='TetraPak_Logging_BasicLog_Debug(string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A textual message to be logged.  
  

Implements [Debug(string)](TetraPak_Logging_ILog.md#TetraPak_Logging_ILog_Debug(string) 'TetraPak.Logging.ILog.Debug(string)')  
  
<a name='TetraPak_Logging_BasicLog_Error(System_Exception_string)'></a>
## BasicLog.Error(Exception, string) Method
Adds an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') and message of rank [Error](TetraPak_Logging_LogRank.md#TetraPak_Logging_LogRank_Error 'TetraPak.Logging.LogRank.Error').  
```csharp
public void Error(System.Exception exception, string message=null);
```
#### Parameters
<a name='TetraPak_Logging_BasicLog_Error(System_Exception_string)_exception'></a>
`exception` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
An [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') to be logged.  
  
<a name='TetraPak_Logging_BasicLog_Error(System_Exception_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A textual message to be logged.  
  

Implements [Error(Exception, string)](TetraPak_Logging_ILog.md#TetraPak_Logging_ILog_Error(System_Exception_string) 'TetraPak.Logging.ILog.Error(System.Exception, string)')  
  
<a name='TetraPak_Logging_BasicLog_Info(string)'></a>
## BasicLog.Info(string) Method
Adds a message of rank [Info](TetraPak_Logging_LogRank.md#TetraPak_Logging_LogRank_Info 'TetraPak.Logging.LogRank.Info').  
```csharp
public void Info(string message);
```
#### Parameters
<a name='TetraPak_Logging_BasicLog_Info(string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A textual message to be logged.  
  

Implements [Info(string)](TetraPak_Logging_ILog.md#TetraPak_Logging_ILog_Info(string) 'TetraPak.Logging.ILog.Info(string)')  
  
<a name='TetraPak_Logging_BasicLog_Warning(string)'></a>
## BasicLog.Warning(string) Method
Adds a message of rank [Warning](TetraPak_Logging_LogRank.md#TetraPak_Logging_LogRank_Warning 'TetraPak.Logging.LogRank.Warning').  
```csharp
public void Warning(string message);
```
#### Parameters
<a name='TetraPak_Logging_BasicLog_Warning(string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A textual message to be logged.  
  

Implements [Warning(string)](TetraPak_Logging_ILog.md#TetraPak_Logging_ILog_Warning(string) 'TetraPak.Logging.ILog.Warning(string)')  
  
### Events
<a name='TetraPak_Logging_BasicLog_Logged'></a>
## BasicLog.Logged Event
Triggered whenever a log entry gets added.  
```csharp
public event Logged;
```
#### Event Type
[System.EventHandler&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.EventHandler-1 'System.EventHandler`1')[TextLogEventArgs](TetraPak_Logging_TextLogEventArgs.md 'TetraPak.Logging.TextLogEventArgs')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.EventHandler-1 'System.EventHandler`1')
  
