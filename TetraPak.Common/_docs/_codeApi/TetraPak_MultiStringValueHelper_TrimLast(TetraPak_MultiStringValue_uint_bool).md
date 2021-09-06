#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[MultiStringValueHelper](TetraPak_MultiStringValueHelper.md 'TetraPak.MultiStringValueHelper')
## MultiStringValueHelper.TrimLast(MultiStringValue, uint, bool) Method
Creates a new [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') from this one, but without one or more trailing element(s).  
```csharp
public static TetraPak.MultiStringValue TrimLast(this TetraPak.MultiStringValue self, uint count=1u, bool safe=false);
```
#### Parameters
<a name='TetraPak_MultiStringValueHelper_TrimLast(TetraPak_MultiStringValue_uint_bool)_self'></a>
`self` [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
The extended [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue').  
  
<a name='TetraPak_MultiStringValueHelper_TrimLast(TetraPak_MultiStringValue_uint_bool)_count'></a>
`count` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')  
(optional; default=1)<br/>  
Specifies how many items to pop from the [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue').  
  
<a name='TetraPak_MultiStringValueHelper_TrimLast(TetraPak_MultiStringValue_uint_bool)_safe'></a>
`safe` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
(optional; default=`false`)<br/>  
When set an invalid [count](TetraPak_MultiStringValueHelper_TrimLast(TetraPak_MultiStringValue_uint_bool).md#TetraPak_MultiStringValueHelper_TrimLast(TetraPak_MultiStringValue_uint_bool)_count 'TetraPak.MultiStringValueHelper.TrimLast(TetraPak.MultiStringValue, uint, bool).count') (too high) an [Empty](TetraPak_MultiStringValue_Empty.md 'TetraPak.MultiStringValue.Empty') value is returned;  
otherwise a [System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') exception is thrown.  
  
#### Returns
[MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
A [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') with [count](TetraPak_MultiStringValueHelper_TrimLast(TetraPak_MultiStringValue_uint_bool).md#TetraPak_MultiStringValueHelper_TrimLast(TetraPak_MultiStringValue_uint_bool)_count 'TetraPak.MultiStringValueHelper.TrimLast(TetraPak.MultiStringValue, uint, bool).count') items removed from the end.  
