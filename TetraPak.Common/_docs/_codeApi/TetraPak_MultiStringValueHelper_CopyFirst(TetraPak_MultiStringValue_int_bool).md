#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[MultiStringValueHelper](TetraPak_MultiStringValueHelper.md 'TetraPak.MultiStringValueHelper')
## MultiStringValueHelper.CopyFirst(MultiStringValue, int, bool) Method
Copies the leading [Items](TetraPak_MultiStringValue_Items.md 'TetraPak.MultiStringValue.Items') of this value to create a new [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue').  
```csharp
public static TetraPak.MultiStringValue CopyFirst(this TetraPak.MultiStringValue self, int count=1, bool safe=false);
```
#### Parameters
<a name='TetraPak_MultiStringValueHelper_CopyFirst(TetraPak_MultiStringValue_int_bool)_self'></a>
`self` [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
The extended [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue').  
  
<a name='TetraPak_MultiStringValueHelper_CopyFirst(TetraPak_MultiStringValue_int_bool)_count'></a>
`count` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
(optional; default=1)<br/>  
The number of elements to be copied.  
  
<a name='TetraPak_MultiStringValueHelper_CopyFirst(TetraPak_MultiStringValue_int_bool)_safe'></a>
`safe` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
(optional; default=`false`)<bt/>  
When set an invalid [count](TetraPak_MultiStringValueHelper_CopyFirst(TetraPak_MultiStringValue_int_bool).md#TetraPak_MultiStringValueHelper_CopyFirst(TetraPak_MultiStringValue_int_bool)_count 'TetraPak.MultiStringValueHelper.CopyFirst(TetraPak.MultiStringValue, int, bool).count') value will return an [Empty](TetraPak_MultiStringValue_Empty.md 'TetraPak.MultiStringValue.Empty') value;  
otherwise an [System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') will be thrown.  
  
#### Returns
[MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
A [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') from the first leading items of this one.  
#### Exceptions
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
The [count](TetraPak_MultiStringValueHelper_CopyFirst(TetraPak_MultiStringValue_int_bool).md#TetraPak_MultiStringValueHelper_CopyFirst(TetraPak_MultiStringValue_int_bool)_count 'TetraPak.MultiStringValueHelper.CopyFirst(TetraPak.MultiStringValue, int, bool).count') value implied more [Items](TetraPak_MultiStringValue_Items.md 'TetraPak.MultiStringValue.Items') than was supported by this value,  
and [safe](TetraPak_MultiStringValueHelper_CopyFirst(TetraPak_MultiStringValue_int_bool).md#TetraPak_MultiStringValueHelper_CopyFirst(TetraPak_MultiStringValue_int_bool)_safe 'TetraPak.MultiStringValueHelper.CopyFirst(TetraPak.MultiStringValue, int, bool).safe') was not set.    
