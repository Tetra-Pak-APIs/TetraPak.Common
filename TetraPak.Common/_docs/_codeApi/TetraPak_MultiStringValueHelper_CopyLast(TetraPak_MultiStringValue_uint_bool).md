#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[MultiStringValueHelper](TetraPak_MultiStringValueHelper.md 'TetraPak.MultiStringValueHelper')
## MultiStringValueHelper.CopyLast(MultiStringValue, uint, bool) Method
Copies the trailing [Items](TetraPak_MultiStringValue_Items.md 'TetraPak.MultiStringValue.Items') of this value to create a new [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue').  
```csharp
public static TetraPak.MultiStringValue CopyLast(this TetraPak.MultiStringValue self, uint count=1u, bool safe=false);
```
#### Parameters
<a name='TetraPak_MultiStringValueHelper_CopyLast(TetraPak_MultiStringValue_uint_bool)_self'></a>
`self` [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
The extended [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue').  
  
<a name='TetraPak_MultiStringValueHelper_CopyLast(TetraPak_MultiStringValue_uint_bool)_count'></a>
`count` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')  
(optional; default=1)<br/>  
The number of elements to be copied.  
  
<a name='TetraPak_MultiStringValueHelper_CopyLast(TetraPak_MultiStringValue_uint_bool)_safe'></a>
`safe` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
(optional; default=`false`)<bt/>  
When set an invalid [count](TetraPak_MultiStringValueHelper_CopyLast(TetraPak_MultiStringValue_uint_bool).md#TetraPak_MultiStringValueHelper_CopyLast(TetraPak_MultiStringValue_uint_bool)_count 'TetraPak.MultiStringValueHelper.CopyLast(TetraPak.MultiStringValue, uint, bool).count') value will return an [Empty](TetraPak_MultiStringValue_Empty.md 'TetraPak.MultiStringValue.Empty') value;  
otherwise an [System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') will be thrown.  
  
#### Returns
[MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
A [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') from the trailing items of this one.  
#### Exceptions
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
The [count](TetraPak_MultiStringValueHelper_CopyLast(TetraPak_MultiStringValue_uint_bool).md#TetraPak_MultiStringValueHelper_CopyLast(TetraPak_MultiStringValue_uint_bool)_count 'TetraPak.MultiStringValueHelper.CopyLast(TetraPak.MultiStringValue, uint, bool).count') value implied more [Items](TetraPak_MultiStringValue_Items.md 'TetraPak.MultiStringValue.Items') than was supported by this value,  
and [safe](TetraPak_MultiStringValueHelper_CopyLast(TetraPak_MultiStringValue_uint_bool).md#TetraPak_MultiStringValueHelper_CopyLast(TetraPak_MultiStringValue_uint_bool)_safe 'TetraPak.MultiStringValueHelper.CopyLast(TetraPak.MultiStringValue, uint, bool).safe') was not set.    
