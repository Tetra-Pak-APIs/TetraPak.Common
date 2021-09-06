#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging').[LoggerExtensions](TetraPak_Logging_LoggerExtensions.md 'TetraPak.Logging.LoggerExtensions')
## LoggerExtensions.Format(Exception, string, string) Method
Creates a standardized logging error format and returns the result.  
```csharp
public static string Format(System.Exception exception, string message, string messageId=null);
```
#### Parameters
<a name='TetraPak_Logging_LoggerExtensions_Format(System_Exception_string_string)_exception'></a>
`exception` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
An [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') to be logged.  
  
<a name='TetraPak_Logging_LoggerExtensions_Format(System_Exception_string_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A message to be logged.  
  
<a name='TetraPak_Logging_LoggerExtensions_Format(System_Exception_string_string)_messageId'></a>
`messageId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
(optional)<bt/>  
A unique string value to be used for referencing/diagnostics purposes.  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A standardized logging message ([System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') value).  
