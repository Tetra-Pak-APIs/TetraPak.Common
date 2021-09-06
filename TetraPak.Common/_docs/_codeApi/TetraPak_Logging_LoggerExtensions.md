#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging')
## LoggerExtensions Class
Adds convenient logging extension methods to an [Microsoft.Extensions.Logging.ILogger](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger 'Microsoft.Extensions.Logging.ILogger') instance.  
```csharp
public static class LoggerExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; LoggerExtensions  

| Properties | |
| :--- | :--- |
| [Prefix](TetraPak_Logging_LoggerExtensions_Prefix.md 'TetraPak.Logging.LoggerExtensions.Prefix') | Gets (or sets) a default [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') value to be inserted as a prefix to all<br/>log entries. This can be used to distinguish entries sourced by your code from other log entries..  <br/> |

| Methods | |
| :--- | :--- |
| [Debug(ILogger, string, string)](TetraPak_Logging_LoggerExtensions_Debug(Microsoft_Extensions_Logging_ILogger_string_string).md 'TetraPak.Logging.LoggerExtensions.Debug(Microsoft.Extensions.Logging.ILogger, string, string)') | Writes a debug log entry in a standardized format.  <br/> |
| [Error(ILogger, Exception, string, string)](TetraPak_Logging_LoggerExtensions_Error(Microsoft_Extensions_Logging_ILogger_System_Exception_string_string).md 'TetraPak.Logging.LoggerExtensions.Error(Microsoft.Extensions.Logging.ILogger, System.Exception, string, string)') | Writes an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') (error) log entry in a standardized format.  <br/> |
| [Format(string, string)](TetraPak_Logging_LoggerExtensions_Format(string_string).md 'TetraPak.Logging.LoggerExtensions.Format(string, string)') | Create a standardized logging format and returns the result.<br/> |
| [Format(Exception, string, string)](TetraPak_Logging_LoggerExtensions_Format(System_Exception_string_string).md 'TetraPak.Logging.LoggerExtensions.Format(System.Exception, string, string)') | Creates a standardized logging error format and returns the result.<br/> |
| [Information(ILogger, string, string)](TetraPak_Logging_LoggerExtensions_Information(Microsoft_Extensions_Logging_ILogger_string_string).md 'TetraPak.Logging.LoggerExtensions.Information(Microsoft.Extensions.Logging.ILogger, string, string)') | Writes an information log entry in a standardized format.  <br/> |
| [LogDictionary&lt;TKey,TValue&gt;(ILogger, IDictionary&lt;TKey,TValue&gt;, LogLevel)](TetraPak_Logging_LoggerExtensions_LogDictionary_TKey_TValue_(Microsoft_Extensions_Logging_ILogger_System_Collections_Generic_IDictionary_TKey_TValue__Microsoft_Extensions_Logging_LogLevel).md 'TetraPak.Logging.LoggerExtensions.LogDictionary&lt;TKey,TValue&gt;(Microsoft.Extensions.Logging.ILogger, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, Microsoft.Extensions.Logging.LogLevel)') | Writes the contents of a [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') to a [Microsoft.Extensions.Logging.ILogger](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger 'Microsoft.Extensions.Logging.ILogger')<br/>for a specified [Microsoft.Extensions.Logging.LogLevel](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.LogLevel 'Microsoft.Extensions.Logging.LogLevel').<br/> |
| [Trace(ILogger, string, string)](TetraPak_Logging_LoggerExtensions_Trace(Microsoft_Extensions_Logging_ILogger_string_string).md 'TetraPak.Logging.LoggerExtensions.Trace(Microsoft.Extensions.Logging.ILogger, string, string)') | Writes a trace log entry in a standardized format.  <br/> |
| [Warning(ILogger, string, string)](TetraPak_Logging_LoggerExtensions_Warning(Microsoft_Extensions_Logging_ILogger_string_string).md 'TetraPak.Logging.LoggerExtensions.Warning(Microsoft.Extensions.Logging.ILogger, string, string)') | Writes a warning log entry in a standardized format.  <br/> |
