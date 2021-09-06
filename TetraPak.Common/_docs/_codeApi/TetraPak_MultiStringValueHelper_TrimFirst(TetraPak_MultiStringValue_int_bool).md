#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[MultiStringValueHelper](TetraPak_MultiStringValueHelper.md 'TetraPak.MultiStringValueHelper')
## MultiStringValueHelper.TrimFirst(MultiStringValue, int, bool) Method
Creates a new [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') from this one, but without one or more leading element(s).  
```csharp
public static TetraPak.MultiStringValue TrimFirst(this TetraPak.MultiStringValue self, int count=1, bool safe=false);
```
#### Parameters
<a name='TetraPak_MultiStringValueHelper_TrimFirst(TetraPak_MultiStringValue_int_bool)_self'></a>
`self` [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
The extended [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue').  
  
<a name='TetraPak_MultiStringValueHelper_TrimFirst(TetraPak_MultiStringValue_int_bool)_count'></a>
`count` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
(optional; default=1)<br/>  
Specifies how many items to pop from the [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue').  
  
<a name='TetraPak_MultiStringValueHelper_TrimFirst(TetraPak_MultiStringValue_int_bool)_safe'></a>
`safe` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
(optional; default=`false`)<br/>  
When set an invalid [count](TetraPak_MultiStringValueHelper_TrimFirst(TetraPak_MultiStringValue_int_bool).md#TetraPak_MultiStringValueHelper_TrimFirst(TetraPak_MultiStringValue_int_bool)_count 'TetraPak.MultiStringValueHelper.TrimFirst(TetraPak.MultiStringValue, int, bool).count') (too high) an [Empty](TetraPak_MultiStringValue_Empty.md 'TetraPak.MultiStringValue.Empty') value is returned;  
otherwise a [System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') exception is thrown.  
  
#### Returns
[MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
A [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') with [count](TetraPak_MultiStringValueHelper_TrimFirst(TetraPak_MultiStringValue_int_bool).md#TetraPak_MultiStringValueHelper_TrimFirst(TetraPak_MultiStringValue_int_bool)_count 'TetraPak.MultiStringValueHelper.TrimFirst(TetraPak.MultiStringValue, int, bool).count') items removed from the start.  
