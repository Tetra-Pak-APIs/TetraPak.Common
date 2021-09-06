#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')
## MultiStringValue.TryParse&lt;T&gt;(string, T, StringComparison) Method
Converts a string to its [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')-compatible equivalent.  
A return value indicates whether the conversion succeeded.  
```csharp
public static bool TryParse<T>(string stringValue, out T multiStringValue, System.StringComparison comparison=System.StringComparison.Ordinal)
    where T : TetraPak.MultiStringValue;
```
#### Type parameters
<a name='TetraPak_MultiStringValue_TryParse_T_(string_T_System_StringComparison)_T'></a>
`T`  
A [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type'), deriving from [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue'),  
for [stringValue](TetraPak_MultiStringValue_TryParse_T_(string_T_System_StringComparison).md#TetraPak_MultiStringValue_TryParse_T_(string_T_System_StringComparison)_stringValue 'TetraPak.MultiStringValue.TryParse&lt;T&gt;(string, T, System.StringComparison).stringValue') to be converted to.   
  
#### Parameters
<a name='TetraPak_MultiStringValue_TryParse_T_(string_T_System_StringComparison)_stringValue'></a>
`stringValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
<a name='TetraPak_MultiStringValue_TryParse_T_(string_T_System_StringComparison)_multiStringValue'></a>
`multiStringValue` [T](TetraPak_MultiStringValue_TryParse_T_(string_T_System_StringComparison).md#TetraPak_MultiStringValue_TryParse_T_(string_T_System_StringComparison)_T 'TetraPak.MultiStringValue.TryParse&lt;T&gt;(string, T, System.StringComparison).T')  
  
<a name='TetraPak_MultiStringValue_TryParse_T_(string_T_System_StringComparison)_comparison'></a>
`comparison` [System.StringComparison](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparison 'System.StringComparison')  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if [stringValue](TetraPak_MultiStringValue_TryParse_T_(string_T_System_StringComparison).md#TetraPak_MultiStringValue_TryParse_T_(string_T_System_StringComparison)_stringValue 'TetraPak.MultiStringValue.TryParse&lt;T&gt;(string, T, System.StringComparison).stringValue') was converted successfully; otherwise, `false`.  
            
#### See Also
- [TryParse(string, MultiStringValue, StringComparison)](TetraPak_MultiStringValue_TryParse(string_TetraPak_MultiStringValue_System_StringComparison).md 'TetraPak.MultiStringValue.TryParse(string, TetraPak.MultiStringValue, System.StringComparison)')
