#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')
## MultiStringValue.OnValidateItem(string, StringComparison) Method
Called during the parsing process to allow validation of a string item.  
Intended for derived [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') classes. This implementation always returns  
a successful result.   
```csharp
protected virtual TetraPak.Outcome<string> OnValidateItem(string item, System.StringComparison comparison=System.StringComparison.Ordinal);
```
#### Parameters
<a name='TetraPak_MultiStringValue_OnValidateItem(string_System_StringComparison)_item'></a>
`item` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') item to be validated.  
  
<a name='TetraPak_MultiStringValue_OnValidateItem(string_System_StringComparison)_comparison'></a>
`comparison` [System.StringComparison](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparison 'System.StringComparison')  
(optional; default=[System.StringComparison.Ordinal](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparison.Ordinal 'System.StringComparison.Ordinal'))<br/>  
A string comparison value to be honored by the validation.   
  
#### Returns
[TetraPak.Outcome&lt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Outcome-1 'TetraPak.Outcome`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Outcome-1 'TetraPak.Outcome`1')  
An [TetraPak.Outcome&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Outcome-1 'TetraPak.Outcome`1') to indicate success/failure and, on success, also carry  
a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') or, on failure, an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').  
