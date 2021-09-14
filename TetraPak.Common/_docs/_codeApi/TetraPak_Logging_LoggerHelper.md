#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging')
## LoggerHelper Class
Provides convenient helper methods to assist with consistent logging.  
```csharp
public static class LoggerHelper
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; LoggerHelper  
### Methods
<a name='TetraPak_Logging_LoggerHelper_GetStateDump(object_TetraPak_Logging_StateDumpOptions)'></a>
## LoggerHelper.GetStateDump(object, StateDumpOptions) Method
Generates and returns a string to reflect the state of an object.  
```csharp
public static string GetStateDump(this object obj, TetraPak.Logging.StateDumpOptions options);
```
#### Parameters
<a name='TetraPak_Logging_LoggerHelper_GetStateDump(object_TetraPak_Logging_StateDumpOptions)_obj'></a>
`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The object.  
  
<a name='TetraPak_Logging_LoggerHelper_GetStateDump(object_TetraPak_Logging_StateDumpOptions)_options'></a>
`options` [StateDumpOptions](TetraPak_Logging_StateDumpOptions.md 'TetraPak.Logging.StateDumpOptions')  
Specifies how to render state from the specified object.   
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A JSON formatted string, reflecting the object's current state.  
#### See Also
- [RestrictedValueAttribute](TetraPak_RestrictedValueAttribute.md 'TetraPak.RestrictedValueAttribute')
  
<a name='TetraPak_Logging_LoggerHelper_IsDisclosedForLogger(TetraPak_RestrictedValueAttribute_Microsoft_Extensions_Logging_ILogger)'></a>
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
`true` if the decorated value can be disclosed for [logger](TetraPak_Logging_LoggerHelper.md#TetraPak_Logging_LoggerHelper_IsDisclosedForLogger(TetraPak_RestrictedValueAttribute_Microsoft_Extensions_Logging_ILogger)_logger 'TetraPak.Logging.LoggerHelper.IsDisclosedForLogger(TetraPak.RestrictedValueAttribute, Microsoft.Extensions.Logging.ILogger).logger');  
              otherwise `false`.   
            
  
