#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging').[LoggerExtensions](TetraPak_Logging_LoggerExtensions.md 'TetraPak.Logging.LoggerExtensions')
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
`dictionary` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](TetraPak_Logging_LoggerExtensions_LogDictionary_TKey_TValue_(Microsoft_Extensions_Logging_ILogger_System_Collections_Generic_IDictionary_TKey_TValue__Microsoft_Extensions_Logging_LogLevel).md#TetraPak_Logging_LoggerExtensions_LogDictionary_TKey_TValue_(Microsoft_Extensions_Logging_ILogger_System_Collections_Generic_IDictionary_TKey_TValue__Microsoft_Extensions_Logging_LogLevel)_TKey 'TetraPak.Logging.LoggerExtensions.LogDictionary&lt;TKey,TValue&gt;(Microsoft.Extensions.Logging.ILogger, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, Microsoft.Extensions.Logging.LogLevel).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](TetraPak_Logging_LoggerExtensions_LogDictionary_TKey_TValue_(Microsoft_Extensions_Logging_ILogger_System_Collections_Generic_IDictionary_TKey_TValue__Microsoft_Extensions_Logging_LogLevel).md#TetraPak_Logging_LoggerExtensions_LogDictionary_TKey_TValue_(Microsoft_Extensions_Logging_ILogger_System_Collections_Generic_IDictionary_TKey_TValue__Microsoft_Extensions_Logging_LogLevel)_TValue 'TetraPak.Logging.LoggerExtensions.LogDictionary&lt;TKey,TValue&gt;(Microsoft.Extensions.Logging.ILogger, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, Microsoft.Extensions.Logging.LogLevel).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
The dictionary to be written.  
  
<a name='TetraPak_Logging_LoggerExtensions_LogDictionary_TKey_TValue_(Microsoft_Extensions_Logging_ILogger_System_Collections_Generic_IDictionary_TKey_TValue__Microsoft_Extensions_Logging_LogLevel)_level'></a>
`level` [Microsoft.Extensions.Logging.LogLevel](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.LogLevel 'Microsoft.Extensions.Logging.LogLevel')  
The [Microsoft.Extensions.Logging.LogLevel](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.LogLevel 'Microsoft.Extensions.Logging.LogLevel') to be used for teh log entry.  
  
