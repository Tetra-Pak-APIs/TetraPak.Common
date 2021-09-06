#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging').[StateDumpOptions](TetraPak_Logging_StateDumpOptions.md 'TetraPak.Logging.StateDumpOptions')
## StateDumpOptions.WithTargetLogger(ILogger) Method
Specifies that restricted values (that will normally be dumped as redacted values) can be  
disclosed for specified logger if that logger is declaring a [Microsoft.Extensions.Logging.LogLevel](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.LogLevel 'Microsoft.Extensions.Logging.LogLevel') that  
matches the restricted value's decorated [DisclosureLogLevels](TetraPak_RestrictedValueAttribute_DisclosureLogLevels.md 'TetraPak.RestrictedValueAttribute.DisclosureLogLevels').   
```csharp
public TetraPak.Logging.StateDumpOptions WithTargetLogger(Microsoft.Extensions.Logging.ILogger logger);
```
#### Parameters
<a name='TetraPak_Logging_StateDumpOptions_WithTargetLogger(Microsoft_Extensions_Logging_ILogger)_logger'></a>
`logger` [Microsoft.Extensions.Logging.ILogger](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger 'Microsoft.Extensions.Logging.ILogger')  
A targeted logger provider.  
  
#### Returns
[StateDumpOptions](TetraPak_Logging_StateDumpOptions.md 'TetraPak.Logging.StateDumpOptions')  
This object (fluent API).  
