#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging')
## LoggerExtensions Class
Adds convenient logging extension methods to an [Microsoft.Extensions.Logging.ILogger](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger 'Microsoft.Extensions.Logging.ILogger') instance.  
```csharp
public static class LoggerExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; LoggerExtensions  
### Properties
<a name='TetraPak_Logging_LoggerExtensions_Prefix'></a>
## LoggerExtensions.Prefix Property
Gets (or sets) a default [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') value to be inserted as a prefix to all  
log entries. This can be used to distinguish entries sourced by your code from other log entries..    
```csharp
public static string Prefix { get; set; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
  
### Methods
<a name='TetraPak_Logging_LoggerExtensions_Debug(Microsoft_Extensions_Logging_ILogger_string_string)'></a>
## LoggerExtensions.Debug(ILogger, string, string) Method
Writes a debug log entry in a standardized format.    
```csharp
public static void Debug(this Microsoft.Extensions.Logging.ILogger logger, string message, string messageId=null);
```
#### Parameters
<a name='TetraPak_Logging_LoggerExtensions_Debug(Microsoft_Extensions_Logging_ILogger_string_string)_logger'></a>
`logger` [Microsoft.Extensions.Logging.ILogger](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger 'Microsoft.Extensions.Logging.ILogger')  
The logging provider.  
  
<a name='TetraPak_Logging_LoggerExtensions_Debug(Microsoft_Extensions_Logging_ILogger_string_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A message to be written to [logger](TetraPak_Logging_LoggerExtensions.md#TetraPak_Logging_LoggerExtensions_Debug(Microsoft_Extensions_Logging_ILogger_string_string)_logger 'TetraPak.Logging.LoggerExtensions.Debug(Microsoft.Extensions.Logging.ILogger, string, string).logger').  
  
<a name='TetraPak_Logging_LoggerExtensions_Debug(Microsoft_Extensions_Logging_ILogger_string_string)_messageId'></a>
`messageId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
(optional)<br/>  
A unique string value for tracking a request/response (mainly for diagnostics purposes).  
  
  
<a name='TetraPak_Logging_LoggerExtensions_Error(Microsoft_Extensions_Logging_ILogger_System_Exception_string_string)'></a>
## LoggerExtensions.Error(ILogger, Exception, string, string) Method
Writes an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') (error) log entry in a standardized format.    
```csharp
public static void Error(this Microsoft.Extensions.Logging.ILogger logger, System.Exception exception, string message=null, string messageId=null);
```
#### Parameters
<a name='TetraPak_Logging_LoggerExtensions_Error(Microsoft_Extensions_Logging_ILogger_System_Exception_string_string)_logger'></a>
`logger` [Microsoft.Extensions.Logging.ILogger](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger 'Microsoft.Extensions.Logging.ILogger')  
The logging provider.  
  
<a name='TetraPak_Logging_LoggerExtensions_Error(Microsoft_Extensions_Logging_ILogger_System_Exception_string_string)_exception'></a>
`exception` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
An [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') to be logged.  
  
<a name='TetraPak_Logging_LoggerExtensions_Error(Microsoft_Extensions_Logging_ILogger_System_Exception_string_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A message to be written to [logger](TetraPak_Logging_LoggerExtensions.md#TetraPak_Logging_LoggerExtensions_Error(Microsoft_Extensions_Logging_ILogger_System_Exception_string_string)_logger 'TetraPak.Logging.LoggerExtensions.Error(Microsoft.Extensions.Logging.ILogger, System.Exception, string, string).logger').  
  
<a name='TetraPak_Logging_LoggerExtensions_Error(Microsoft_Extensions_Logging_ILogger_System_Exception_string_string)_messageId'></a>
`messageId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
(optional)<br/>  
A unique string value for tracking a request/response (mainly for diagnostics purposes).  
  
  
<a name='TetraPak_Logging_LoggerExtensions_Format(string_string)'></a>
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
(optional)<br/>  
A unique string value for tracking a request/response (mainly for diagnostics purposes).  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A standardized logging message ([System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') value).  
  
<a name='TetraPak_Logging_LoggerExtensions_Format(System_Exception_string_string)'></a>
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
(optional)<br/>  
A unique string value for tracking a request/response (mainly for diagnostics purposes).  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A standardized logging message ([System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') value).  
  
<a name='TetraPak_Logging_LoggerExtensions_Information(Microsoft_Extensions_Logging_ILogger_string_string)'></a>
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
A message to be written to [logger](TetraPak_Logging_LoggerExtensions.md#TetraPak_Logging_LoggerExtensions_Information(Microsoft_Extensions_Logging_ILogger_string_string)_logger 'TetraPak.Logging.LoggerExtensions.Information(Microsoft.Extensions.Logging.ILogger, string, string).logger').  
  
<a name='TetraPak_Logging_LoggerExtensions_Information(Microsoft_Extensions_Logging_ILogger_string_string)_messageId'></a>
`messageId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
(optional)<br/>  
A unique string value for tracking a request/response (mainly for diagnostics purposes).  
  
  
<a name='TetraPak_Logging_LoggerExtensions_LogDictionary_TKey_TValue_(Microsoft_Extensions_Logging_ILogger_System_Collections_Generic_IDictionary_TKey_TValue__Microsoft_Extensions_Logging_LogLevel)'></a>
## LoggerExtensions.LogDictionary&lt;TKey,TValue&gt;(ILogger, IDictionary&lt;TKey,TValue&gt;, LogLevel) Method
Writes the contents of a [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') to a [Microsoft.Extensions.Logging.ILogger](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger 'Microsoft.Extensions.Logging.ILogger')  
for a specified [Microsoft.Extensions.Logging.LogLevel](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.LogLevel 'Microsoft.Extensions.Logging.LogLevel').  
```csharp
public static void LogDictionary<TKey,TValue>(this Microsoft.Extensions.Logging.ILogger logger, System.Collections.Generic.IDictionary<TKey,TValue> dictionary, Microsoft.Extensions.Logging.LogLevel level);
```
#### Type parameters
<a name='TetraPak_Logging_LoggerExtensions_LogDictionary_TKey_TValue_(Microsoft_Extensions_Logging_ILogger_System_Collections_Generic_IDictionary_TKey_TValue__Microsoft_Extensions_Logging_LogLevel)_TKey'></a>
`TKey`  
The dictionary key [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type').  
  
<a name='TetraPak_Logging_LoggerExtensions_LogDictionary_TKey_TValue_(Microsoft_Extensions_Logging_ILogger_System_Collections_Generic_IDictionary_TKey_TValue__Microsoft_Extensions_Logging_LogLevel)_TValue'></a>
`TValue`  
The dictionary value [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type').  
  
#### Parameters
<a name='TetraPak_Logging_LoggerExtensions_LogDictionary_TKey_TValue_(Microsoft_Extensions_Logging_ILogger_System_Collections_Generic_IDictionary_TKey_TValue__Microsoft_Extensions_Logging_LogLevel)_logger'></a>
`logger` [Microsoft.Extensions.Logging.ILogger](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger 'Microsoft.Extensions.Logging.ILogger')  
The logging provider.  
  
<a name='TetraPak_Logging_LoggerExtensions_LogDictionary_TKey_TValue_(Microsoft_Extensions_Logging_ILogger_System_Collections_Generic_IDictionary_TKey_TValue__Microsoft_Extensions_Logging_LogLevel)_dictionary'></a>
`dictionary` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](TetraPak_Logging_LoggerExtensions.md#TetraPak_Logging_LoggerExtensions_LogDictionary_TKey_TValue_(Microsoft_Extensions_Logging_ILogger_System_Collections_Generic_IDictionary_TKey_TValue__Microsoft_Extensions_Logging_LogLevel)_TKey 'TetraPak.Logging.LoggerExtensions.LogDictionary&lt;TKey,TValue&gt;(Microsoft.Extensions.Logging.ILogger, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, Microsoft.Extensions.Logging.LogLevel).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](TetraPak_Logging_LoggerExtensions.md#TetraPak_Logging_LoggerExtensions_LogDictionary_TKey_TValue_(Microsoft_Extensions_Logging_ILogger_System_Collections_Generic_IDictionary_TKey_TValue__Microsoft_Extensions_Logging_LogLevel)_TValue 'TetraPak.Logging.LoggerExtensions.LogDictionary&lt;TKey,TValue&gt;(Microsoft.Extensions.Logging.ILogger, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, Microsoft.Extensions.Logging.LogLevel).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
The dictionary to be written.  
  
<a name='TetraPak_Logging_LoggerExtensions_LogDictionary_TKey_TValue_(Microsoft_Extensions_Logging_ILogger_System_Collections_Generic_IDictionary_TKey_TValue__Microsoft_Extensions_Logging_LogLevel)_level'></a>
`level` [Microsoft.Extensions.Logging.LogLevel](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.LogLevel 'Microsoft.Extensions.Logging.LogLevel')  
The [Microsoft.Extensions.Logging.LogLevel](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.LogLevel 'Microsoft.Extensions.Logging.LogLevel') to be used for teh log entry.  
  
  
<a name='TetraPak_Logging_LoggerExtensions_Trace(Microsoft_Extensions_Logging_ILogger_string_string)'></a>
## LoggerExtensions.Trace(ILogger, string, string) Method
Writes a trace log entry in a standardized format.    
```csharp
public static void Trace(this Microsoft.Extensions.Logging.ILogger logger, string message, string messageId=null);
```
#### Parameters
<a name='TetraPak_Logging_LoggerExtensions_Trace(Microsoft_Extensions_Logging_ILogger_string_string)_logger'></a>
`logger` [Microsoft.Extensions.Logging.ILogger](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger 'Microsoft.Extensions.Logging.ILogger')  
The logging provider.  
  
<a name='TetraPak_Logging_LoggerExtensions_Trace(Microsoft_Extensions_Logging_ILogger_string_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A message to be written to [logger](TetraPak_Logging_LoggerExtensions.md#TetraPak_Logging_LoggerExtensions_Trace(Microsoft_Extensions_Logging_ILogger_string_string)_logger 'TetraPak.Logging.LoggerExtensions.Trace(Microsoft.Extensions.Logging.ILogger, string, string).logger').  
  
<a name='TetraPak_Logging_LoggerExtensions_Trace(Microsoft_Extensions_Logging_ILogger_string_string)_messageId'></a>
`messageId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
(optional)<br/>  
A unique string value for tracking a request/response (mainly for diagnostics purposes).  
  
  
<a name='TetraPak_Logging_LoggerExtensions_Warning(Microsoft_Extensions_Logging_ILogger_string_string)'></a>
## LoggerExtensions.Warning(ILogger, string, string) Method
Writes a warning log entry in a standardized format.    
```csharp
public static void Warning(this Microsoft.Extensions.Logging.ILogger logger, string message, string messageId=null);
```
#### Parameters
<a name='TetraPak_Logging_LoggerExtensions_Warning(Microsoft_Extensions_Logging_ILogger_string_string)_logger'></a>
`logger` [Microsoft.Extensions.Logging.ILogger](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger 'Microsoft.Extensions.Logging.ILogger')  
The logging provider.  
  
<a name='TetraPak_Logging_LoggerExtensions_Warning(Microsoft_Extensions_Logging_ILogger_string_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A message to be written to [logger](TetraPak_Logging_LoggerExtensions.md#TetraPak_Logging_LoggerExtensions_Warning(Microsoft_Extensions_Logging_ILogger_string_string)_logger 'TetraPak.Logging.LoggerExtensions.Warning(Microsoft.Extensions.Logging.ILogger, string, string).logger').  
  
<a name='TetraPak_Logging_LoggerExtensions_Warning(Microsoft_Extensions_Logging_ILogger_string_string)_messageId'></a>
`messageId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
(optional)<br/>  
A unique string value for tracking a request/response (mainly for diagnostics purposes).  
  
  
