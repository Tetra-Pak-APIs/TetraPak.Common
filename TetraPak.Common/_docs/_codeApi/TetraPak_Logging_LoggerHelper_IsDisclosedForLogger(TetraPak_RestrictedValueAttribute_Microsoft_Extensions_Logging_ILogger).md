#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging').[LoggerHelper](TetraPak_Logging_LoggerHelper.md 'TetraPak.Logging.LoggerHelper')
## LoggerHelper.IsDisclosedForLogger(RestrictedValueAttribute, ILogger) Method
Examines the [RestrictedValueAttribute](TetraPak_RestrictedValueAttribute.md 'TetraPak.RestrictedValueAttribute') and returns a value indicating whether  
the decorated value can be disclosed for a specified [Microsoft.Extensions.Logging.ILogger](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger 'Microsoft.Extensions.Logging.ILogger').  
```csharp
public static bool IsDisclosedForLogger(this TetraPak.RestrictedValueAttribute self, Microsoft.Extensions.Logging.ILogger logger);
```
#### Parameters
<a name='TetraPak_Logging_LoggerHelper_IsDisclosedForLogger(TetraPak_RestrictedValueAttribute_Microsoft_Extensions_Logging_ILogger)_self'></a>
`self` [RestrictedValueAttribute](TetraPak_RestrictedValueAttribute.md 'TetraPak.RestrictedValueAttribute')  
The attribute.  
  
<a name='TetraPak_Logging_LoggerHelper_IsDisclosedForLogger(TetraPak_RestrictedValueAttribute_Microsoft_Extensions_Logging_ILogger)_logger'></a>
`logger` [Microsoft.Extensions.Logging.ILogger](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger 'Microsoft.Extensions.Logging.ILogger')  
The intended logger provider.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the decorated value can be disclosed for [logger](TetraPak_Logging_LoggerHelper_IsDisclosedForLogger(TetraPak_RestrictedValueAttribute_Microsoft_Extensions_Logging_ILogger).md#TetraPak_Logging_LoggerHelper_IsDisclosedForLogger(TetraPak_RestrictedValueAttribute_Microsoft_Extensions_Logging_ILogger)_logger 'TetraPak.Logging.LoggerHelper.IsDisclosedForLogger(TetraPak.RestrictedValueAttribute, Microsoft.Extensions.Logging.ILogger).logger');  
              otherwise `false`.   
            
