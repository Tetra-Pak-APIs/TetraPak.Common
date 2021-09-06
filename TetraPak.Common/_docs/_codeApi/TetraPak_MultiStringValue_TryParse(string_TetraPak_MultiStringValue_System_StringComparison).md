#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')
## MultiStringValue.TryParse(string, MultiStringValue, StringComparison) Method
Converts a string to its [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') equivalent.  
A return value indicates whether the conversion succeeded.  
```csharp
public static bool TryParse(string stringValue, out TetraPak.MultiStringValue multiStringValue, System.StringComparison comparison=System.StringComparison.Ordinal);
```
#### Parameters
<a name='TetraPak_MultiStringValue_TryParse(string_TetraPak_MultiStringValue_System_StringComparison)_stringValue'></a>
`stringValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string containing a [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') to convert.  
  
<a name='TetraPak_MultiStringValue_TryParse(string_TetraPak_MultiStringValue_System_StringComparison)_multiStringValue'></a>
`multiStringValue` [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
The successfully parsed [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue').  
  
<a name='TetraPak_MultiStringValue_TryParse(string_TetraPak_MultiStringValue_System_StringComparison)_comparison'></a>
`comparison` [System.StringComparison](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparison 'System.StringComparison')  
(optional)<br/>  
A [System.StringComparer](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparer 'System.StringComparer') used for parsing the [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue').  
This is mainly intended for the need in derived classes that needs to override the  
[OnValidateItem(string, StringComparison)](TetraPak_MultiStringValue_OnValidateItem(string_System_StringComparison).md 'TetraPak.MultiStringValue.OnValidateItem(string, System.StringComparison)') method. The comparer have no effect in this class.   
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if [stringValue](TetraPak_MultiStringValue_TryParse(string_TetraPak_MultiStringValue_System_StringComparison).md#TetraPak_MultiStringValue_TryParse(string_TetraPak_MultiStringValue_System_StringComparison)_stringValue 'TetraPak.MultiStringValue.TryParse(string, TetraPak.MultiStringValue, System.StringComparison).stringValue') was converted successfully; otherwise, `false`.  
            
#### See Also
- [TryParse&lt;T&gt;(string, T, StringComparison)](TetraPak_MultiStringValue_TryParse_T_(string_T_System_StringComparison).md 'TetraPak.MultiStringValue.TryParse&lt;T&gt;(string, T, System.StringComparison)')
