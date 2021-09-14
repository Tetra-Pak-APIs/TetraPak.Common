#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging')
## TextLogEventArgs Class
Describes a log entry.  
```csharp
public class TextLogEventArgs : System.EventArgs
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.EventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.EventArgs 'System.EventArgs') &#129106; TextLogEventArgs  
### Constructors
<a name='TetraPak_Logging_TextLogEventArgs_TextLogEventArgs(TetraPak_Logging_LogRank_string_System_Exception)'></a>
## TextLogEventArgs.TextLogEventArgs(LogRank, string, Exception) Constructor
Initializes the event arguments.  
```csharp
public TextLogEventArgs(TetraPak.Logging.LogRank rank, string message, System.Exception exception=null);
```
#### Parameters
<a name='TetraPak_Logging_TextLogEventArgs_TextLogEventArgs(TetraPak_Logging_LogRank_string_System_Exception)_rank'></a>
`rank` [LogRank](TetraPak_Logging_LogRank.md 'TetraPak.Logging.LogRank')  
  
<a name='TetraPak_Logging_TextLogEventArgs_TextLogEventArgs(TetraPak_Logging_LogRank_string_System_Exception)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
<a name='TetraPak_Logging_TextLogEventArgs_TextLogEventArgs(TetraPak_Logging_LogRank_string_System_Exception)_exception'></a>
`exception` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
  
  
### Properties
<a name='TetraPak_Logging_TextLogEventArgs_Exception'></a>
## TextLogEventArgs.Exception Property
Gets a log entry error (if any).  
```csharp
public System.Exception Exception { get; set; }
```
#### Property Value
[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')
  
<a name='TetraPak_Logging_TextLogEventArgs_Message'></a>
## TextLogEventArgs.Message Property
Gets the log entry message (if any).  
```csharp
public string Message { get; set; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
  
<a name='TetraPak_Logging_TextLogEventArgs_Rank'></a>
## TextLogEventArgs.Rank Property
Gets the log entry rank.  
```csharp
public TetraPak.Logging.LogRank Rank { get; }
```
#### Property Value
[LogRank](TetraPak_Logging_LogRank.md 'TetraPak.Logging.LogRank')
  
