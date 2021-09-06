#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[MultiStringValueHelper](TetraPak_MultiStringValueHelper.md 'TetraPak.MultiStringValueHelper')
## MultiStringValueHelper.EndsWith(MultiStringValue, MultiStringValue, StringComparison) Method
Determines whether the trailing [Items](TetraPak_MultiStringValue_Items.md 'TetraPak.MultiStringValue.Items') matches  
another [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue').   
```csharp
public static bool EndsWith(this TetraPak.MultiStringValue self, TetraPak.MultiStringValue pattern, System.StringComparison stringComparison=System.StringComparison.Ordinal);
```
#### Parameters
<a name='TetraPak_MultiStringValueHelper_EndsWith(TetraPak_MultiStringValue_TetraPak_MultiStringValue_System_StringComparison)_self'></a>
`self` [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
The extended [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue').  
  
<a name='TetraPak_MultiStringValueHelper_EndsWith(TetraPak_MultiStringValue_TetraPak_MultiStringValue_System_StringComparison)_pattern'></a>
`pattern` [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
A [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') to compare with.  
  
<a name='TetraPak_MultiStringValueHelper_EndsWith(TetraPak_MultiStringValue_TetraPak_MultiStringValue_System_StringComparison)_stringComparison'></a>
`stringComparison` [System.StringComparison](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparison 'System.StringComparison')  
(optional; default=[System.StringComparison.Ordinal](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparison.Ordinal 'System.StringComparison.Ordinal'))<br/>  
One of the enumeration values that specifies how the strings will be compared.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the trailing [Items](TetraPak_MultiStringValue_Items.md 'TetraPak.MultiStringValue.Items') of this value matches all  
              items of the [pattern](TetraPak_MultiStringValueHelper_EndsWith(TetraPak_MultiStringValue_TetraPak_MultiStringValue_System_StringComparison).md#TetraPak_MultiStringValueHelper_EndsWith(TetraPak_MultiStringValue_TetraPak_MultiStringValue_System_StringComparison)_pattern 'TetraPak.MultiStringValueHelper.EndsWith(TetraPak.MultiStringValue, TetraPak.MultiStringValue, System.StringComparison).pattern').  
            
#### See Also
- [StartsWith(MultiStringValue, MultiStringValue, StringComparison)](TetraPak_MultiStringValueHelper_StartsWith(TetraPak_MultiStringValue_TetraPak_MultiStringValue_System_StringComparison).md 'TetraPak.MultiStringValueHelper.StartsWith(TetraPak.MultiStringValue, TetraPak.MultiStringValue, System.StringComparison)')
