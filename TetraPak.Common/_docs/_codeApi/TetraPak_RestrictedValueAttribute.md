#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak')
## RestrictedValueAttribute Class
Decorating a property with this attribute indicates the property should not be disclosed  
in log, traces or similar output when the declaring object's state is presented.   
```csharp
public class RestrictedValueAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; RestrictedValueAttribute  
### Properties
<a name='TetraPak_RestrictedValueAttribute_DisclosureLogLevels'></a>
## RestrictedValueAttribute.DisclosureLogLevels Property
Specifies a [Microsoft.Extensions.Logging.LogLevel](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.LogLevel 'Microsoft.Extensions.Logging.LogLevel') at which the restricted value can be disclosed.  
```csharp
public Microsoft.Extensions.Logging.LogLevel[] DisclosureLogLevels { get; set; }
```
#### Property Value
[Microsoft.Extensions.Logging.LogLevel](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.LogLevel 'Microsoft.Extensions.Logging.LogLevel')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
  
#### See Also
- [StateDump](TetraPak_Logging_StateDump.md 'TetraPak.Logging.StateDump')
- [WebLoggerHelper.GetStateDump](https://docs.microsoft.com/en-us/dotnet/api/WebLoggerHelper.GetStateDump 'WebLoggerHelper.GetStateDump')
