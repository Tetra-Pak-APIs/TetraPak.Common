#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')
## MultiStringValue.EqualsSemantically(MultiStringValue, StringComparison) Method
Compares with another [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') and returns a value to indicate  
whether all items in this value are present in the other, regardless of item's order.  
```csharp
public virtual bool EqualsSemantically(TetraPak.MultiStringValue other, System.StringComparison comparison=System.StringComparison.InvariantCulture);
```
#### Parameters
<a name='TetraPak_MultiStringValue_EqualsSemantically(TetraPak_MultiStringValue_System_StringComparison)_other'></a>
`other` [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
The other [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') to compare with.  
  
<a name='TetraPak_MultiStringValue_EqualsSemantically(TetraPak_MultiStringValue_System_StringComparison)_comparison'></a>
`comparison` [System.StringComparison](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparison 'System.StringComparison')  
(optional; default=[System.StringComparison.Ordinal](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparison.Ordinal 'System.StringComparison.Ordinal'))<br/>  
Specifies how to compare string values.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` both values contains same number of [Items](TetraPak_MultiStringValue_Items.md 'TetraPak.MultiStringValue.Items')  
              and all [Items](TetraPak_MultiStringValue_Items.md 'TetraPak.MultiStringValue.Items') in this value are present in [other](TetraPak_MultiStringValue_EqualsSemantically(TetraPak_MultiStringValue_System_StringComparison).md#TetraPak_MultiStringValue_EqualsSemantically(TetraPak_MultiStringValue_System_StringComparison)_other 'TetraPak.MultiStringValue.EqualsSemantically(TetraPak.MultiStringValue, System.StringComparison).other').  
            
