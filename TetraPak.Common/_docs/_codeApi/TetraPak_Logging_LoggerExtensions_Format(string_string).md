#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging').[LoggerExtensions](TetraPak_Logging_LoggerExtensions.md 'TetraPak.Logging.LoggerExtensions')
## LoggerExtensions.Format(string, string) Method
Create a standardized logging format and returns the result.  
```csharp
public static string Format(string message, string messageId=null);
```
#### Parameters
<a name='TetraPak_Logging_LoggerExtensions_Format(string_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The message to be logged.  
  
<a name='TetraPak_Logging_LoggerExtensions_Format(string_string)_messageId'></a>
`messageId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
(optional)<bt/>  
A unique string value to be used for referencing/diagnostics purposes.  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A standardized logging message ([System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') value).  
