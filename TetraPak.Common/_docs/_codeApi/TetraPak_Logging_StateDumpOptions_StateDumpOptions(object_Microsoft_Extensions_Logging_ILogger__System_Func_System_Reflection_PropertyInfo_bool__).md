#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging').[StateDumpOptions](TetraPak_Logging_StateDumpOptions.md 'TetraPak.Logging.StateDumpOptions')
## StateDumpOptions.StateDumpOptions(object, ILogger?, Func&lt;PropertyInfo,bool&gt;?) Constructor
Initializes the [StateDumpOptions](TetraPak_Logging_StateDumpOptions.md 'TetraPak.Logging.StateDumpOptions') with default options.  
```csharp
public StateDumpOptions(object obj, Microsoft.Extensions.Logging.ILogger? logger=null, System.Func<System.Reflection.PropertyInfo,bool>? includeHandler=null);
```
#### Parameters
<a name='TetraPak_Logging_StateDumpOptions_StateDumpOptions(object_Microsoft_Extensions_Logging_ILogger__System_Func_System_Reflection_PropertyInfo_bool__)_obj'></a>
`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The object to be state dumped.  
  
<a name='TetraPak_Logging_StateDumpOptions_StateDumpOptions(object_Microsoft_Extensions_Logging_ILogger__System_Func_System_Reflection_PropertyInfo_bool__)_logger'></a>
`logger` [Microsoft.Extensions.Logging.ILogger](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger 'Microsoft.Extensions.Logging.ILogger')  
(optional)<br/>  
A target logger provider. Adding this to the options is necessary if you need to disclose  
restricted values, based on the declared [Microsoft.Extensions.Logging.LogLevel](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.LogLevel 'Microsoft.Extensions.Logging.LogLevel').   
  
<a name='TetraPak_Logging_StateDumpOptions_StateDumpOptions(object_Microsoft_Extensions_Logging_ILogger__System_Func_System_Reflection_PropertyInfo_bool__)_includeHandler'></a>
`includeHandler` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Reflection.PropertyInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
(optional)<br/>  
When assigned this handler will be invoked for all decorated ([StateDumpAttribute](TetraPak_Logging_StateDumpAttribute.md 'TetraPak.Logging.StateDumpAttribute'))  
properties of [obj](TetraPak_Logging_StateDumpOptions_StateDumpOptions(object_Microsoft_Extensions_Logging_ILogger__System_Func_System_Reflection_PropertyInfo_bool__).md#TetraPak_Logging_StateDumpOptions_StateDumpOptions(object_Microsoft_Extensions_Logging_ILogger__System_Func_System_Reflection_PropertyInfo_bool__)_obj 'TetraPak.Logging.StateDumpOptions.StateDumpOptions(object, Microsoft.Extensions.Logging.ILogger?, System.Func&lt;System.Reflection.PropertyInfo,bool&gt;?).obj') to return a value specifying whether to include the  
property or not (the handler mist return `true` for the property to be included in state dump).  
  
#### See Also
- [RestrictedValueAttribute](TetraPak_RestrictedValueAttribute.md 'TetraPak.RestrictedValueAttribute')
