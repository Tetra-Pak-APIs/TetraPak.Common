#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging').[LoggerExtensions](TetraPak_Logging_LoggerExtensions.md 'TetraPak.Logging.LoggerExtensions')
## LoggerExtensions.Information(ILogger, string, string) Method
Writes an information log entry in a standardized format.    
```csharp
public static void Information(this Microsoft.Extensions.Logging.ILogger logger, string message, string messageId=null);
```
#### Parameters
<a name='TetraPak_Logging_LoggerExtensions_Information(Microsoft_Extensions_Logging_ILogger_string_string)_logger'></a>
`logger` [Microsoft.Extensions.Logging.ILogger](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger 'Microsoft.Extensions.Logging.ILogger')  
The logging provider.  
  
<a name='TetraPak_Logging_LoggerExtensions_Information(Microsoft_Extensions_Logging_ILogger_string_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A message to be written to [logger](TetraPak_Logging_LoggerExtensions_Information(Microsoft_Extensions_Logging_ILogger_string_string).md#TetraPak_Logging_LoggerExtensions_Information(Microsoft_Extensions_Logging_ILogger_string_string)_logger 'TetraPak.Logging.LoggerExtensions.Information(Microsoft.Extensions.Logging.ILogger, string, string).logger').  
  
<a name='TetraPak_Logging_LoggerExtensions_Information(Microsoft_Extensions_Logging_ILogger_string_string)_messageId'></a>
`messageId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
(optional)<bt/>  
A unique string value to be used for referencing/diagnostics purposes.  
  
