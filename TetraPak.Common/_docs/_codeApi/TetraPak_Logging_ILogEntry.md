#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging')
## ILogEntry Interface
Implementors of this interface represents an individual entry in a log.  
```csharp
public interface ILogEntry
```
### Properties
<a name='TetraPak_Logging_ILogEntry_Id'></a>
## ILogEntry.Id Property
Gets a unique if. Can be used to reference a specific entry in support scenarios.  
```csharp
string Id { get; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
  
<a name='TetraPak_Logging_ILogEntry_Message'></a>
## ILogEntry.Message Property
Get the log message.  
```csharp
string Message { get; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
  
<a name='TetraPak_Logging_ILogEntry_Rank'></a>
## ILogEntry.Rank Property
Gets the log rank (see [LogRank](TetraPak_Logging_LogRank.md 'TetraPak.Logging.LogRank')).  
```csharp
TetraPak.Logging.LogRank Rank { get; }
```
#### Property Value
[LogRank](TetraPak_Logging_LogRank.md 'TetraPak.Logging.LogRank')
  
<a name='TetraPak_Logging_ILogEntry_Time'></a>
## ILogEntry.Time Property
Gets the log entry timestamp (should be UTC).  
```csharp
System.DateTime Time { get; }
```
#### Property Value
[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')
  
