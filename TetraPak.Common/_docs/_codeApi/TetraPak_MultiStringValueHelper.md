#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak')
## MultiStringValueHelper Class
```csharp
public static class MultiStringValueHelper
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; MultiStringValueHelper  
### Methods
<a name='TetraPak_MultiStringValueHelper_CopyFirst(TetraPak_MultiStringValue_int_bool)'></a>
## MultiStringValueHelper.CopyFirst(MultiStringValue, int, bool) Method
Copies the leading [Items](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_Items 'TetraPak.MultiStringValue.Items') of this value to create a new [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue').  
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
When set an invalid [count](TetraPak_MultiStringValueHelper.md#TetraPak_MultiStringValueHelper_CopyFirst(TetraPak_MultiStringValue_int_bool)_count 'TetraPak.MultiStringValueHelper.CopyFirst(TetraPak.MultiStringValue, int, bool).count') value will return an [Empty](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_Empty 'TetraPak.MultiStringValue.Empty') value;  
otherwise an [System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') will be thrown.  
  
#### Returns
[MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
A [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') from the first leading items of this one.  
#### Exceptions
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
The [count](TetraPak_MultiStringValueHelper.md#TetraPak_MultiStringValueHelper_CopyFirst(TetraPak_MultiStringValue_int_bool)_count 'TetraPak.MultiStringValueHelper.CopyFirst(TetraPak.MultiStringValue, int, bool).count') value implied more [Items](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_Items 'TetraPak.MultiStringValue.Items') than was supported by this value,  
and [safe](TetraPak_MultiStringValueHelper.md#TetraPak_MultiStringValueHelper_CopyFirst(TetraPak_MultiStringValue_int_bool)_safe 'TetraPak.MultiStringValueHelper.CopyFirst(TetraPak.MultiStringValue, int, bool).safe') was not set.    
  
<a name='TetraPak_MultiStringValueHelper_CopyLast(TetraPak_MultiStringValue_uint_bool)'></a>
## MultiStringValueHelper.CopyLast(MultiStringValue, uint, bool) Method
Copies the trailing [Items](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_Items 'TetraPak.MultiStringValue.Items') of this value to create a new [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue').  
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
When set an invalid [count](TetraPak_MultiStringValueHelper.md#TetraPak_MultiStringValueHelper_CopyLast(TetraPak_MultiStringValue_uint_bool)_count 'TetraPak.MultiStringValueHelper.CopyLast(TetraPak.MultiStringValue, uint, bool).count') value will return an [Empty](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_Empty 'TetraPak.MultiStringValue.Empty') value;  
otherwise an [System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') will be thrown.  
  
#### Returns
[MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
A [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') from the trailing items of this one.  
#### Exceptions
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
The [count](TetraPak_MultiStringValueHelper.md#TetraPak_MultiStringValueHelper_CopyLast(TetraPak_MultiStringValue_uint_bool)_count 'TetraPak.MultiStringValueHelper.CopyLast(TetraPak.MultiStringValue, uint, bool).count') value implied more [Items](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_Items 'TetraPak.MultiStringValue.Items') than was supported by this value,  
and [safe](TetraPak_MultiStringValueHelper.md#TetraPak_MultiStringValueHelper_CopyLast(TetraPak_MultiStringValue_uint_bool)_safe 'TetraPak.MultiStringValueHelper.CopyLast(TetraPak.MultiStringValue, uint, bool).safe') was not set.    
  
<a name='TetraPak_MultiStringValueHelper_EndsWith(TetraPak_MultiStringValue_TetraPak_MultiStringValue_System_StringComparison)'></a>
## MultiStringValueHelper.EndsWith(MultiStringValue, MultiStringValue, StringComparison) Method
Determines whether the trailing [Items](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_Items 'TetraPak.MultiStringValue.Items') matches  
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
`true` if the trailing [Items](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_Items 'TetraPak.MultiStringValue.Items') of this value matches all  
              items of the [pattern](TetraPak_MultiStringValueHelper.md#TetraPak_MultiStringValueHelper_EndsWith(TetraPak_MultiStringValue_TetraPak_MultiStringValue_System_StringComparison)_pattern 'TetraPak.MultiStringValueHelper.EndsWith(TetraPak.MultiStringValue, TetraPak.MultiStringValue, System.StringComparison).pattern').  
            
#### See Also
- [StartsWith(MultiStringValue, MultiStringValue, StringComparison)](TetraPak_MultiStringValueHelper.md#TetraPak_MultiStringValueHelper_StartsWith(TetraPak_MultiStringValue_TetraPak_MultiStringValue_System_StringComparison) 'TetraPak.MultiStringValueHelper.StartsWith(TetraPak.MultiStringValue, TetraPak.MultiStringValue, System.StringComparison)')
  
<a name='TetraPak_MultiStringValueHelper_StartsWith(TetraPak_MultiStringValue_TetraPak_MultiStringValue_System_StringComparison)'></a>
## MultiStringValueHelper.StartsWith(MultiStringValue, MultiStringValue, StringComparison) Method
Determines whether the leading [Items](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_Items 'TetraPak.MultiStringValue.Items')  
matches another [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue').   
```csharp
public static bool StartsWith(this TetraPak.MultiStringValue self, TetraPak.MultiStringValue pattern, System.StringComparison stringComparison=System.StringComparison.Ordinal);
```
#### Parameters
<a name='TetraPak_MultiStringValueHelper_StartsWith(TetraPak_MultiStringValue_TetraPak_MultiStringValue_System_StringComparison)_self'></a>
`self` [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
The extended [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue').  
  
<a name='TetraPak_MultiStringValueHelper_StartsWith(TetraPak_MultiStringValue_TetraPak_MultiStringValue_System_StringComparison)_pattern'></a>
`pattern` [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
A [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') to compare with.  
  
<a name='TetraPak_MultiStringValueHelper_StartsWith(TetraPak_MultiStringValue_TetraPak_MultiStringValue_System_StringComparison)_stringComparison'></a>
`stringComparison` [System.StringComparison](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparison 'System.StringComparison')  
(optional; default=[System.StringComparison.Ordinal](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparison.Ordinal 'System.StringComparison.Ordinal'))<br/>  
One of the enumeration values that specifies how the strings will be compared.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the leading [Items](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_Items 'TetraPak.MultiStringValue.Items') of this value matches all  
              items of the [pattern](TetraPak_MultiStringValueHelper.md#TetraPak_MultiStringValueHelper_StartsWith(TetraPak_MultiStringValue_TetraPak_MultiStringValue_System_StringComparison)_pattern 'TetraPak.MultiStringValueHelper.StartsWith(TetraPak.MultiStringValue, TetraPak.MultiStringValue, System.StringComparison).pattern').  
            
#### See Also
- [EndsWith(MultiStringValue, MultiStringValue, StringComparison)](TetraPak_MultiStringValueHelper.md#TetraPak_MultiStringValueHelper_EndsWith(TetraPak_MultiStringValue_TetraPak_MultiStringValue_System_StringComparison) 'TetraPak.MultiStringValueHelper.EndsWith(TetraPak.MultiStringValue, TetraPak.MultiStringValue, System.StringComparison)')
  
<a name='TetraPak_MultiStringValueHelper_TrimFirst(TetraPak_MultiStringValue_int_bool)'></a>
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
When set an invalid [count](TetraPak_MultiStringValueHelper.md#TetraPak_MultiStringValueHelper_TrimFirst(TetraPak_MultiStringValue_int_bool)_count 'TetraPak.MultiStringValueHelper.TrimFirst(TetraPak.MultiStringValue, int, bool).count') (too high) an [Empty](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_Empty 'TetraPak.MultiStringValue.Empty') value is returned;  
otherwise a [System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') exception is thrown.  
  
#### Returns
[MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
A [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') with [count](TetraPak_MultiStringValueHelper.md#TetraPak_MultiStringValueHelper_TrimFirst(TetraPak_MultiStringValue_int_bool)_count 'TetraPak.MultiStringValueHelper.TrimFirst(TetraPak.MultiStringValue, int, bool).count') items removed from the start.  
  
<a name='TetraPak_MultiStringValueHelper_TrimLast(TetraPak_MultiStringValue_uint_bool)'></a>
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
When set an invalid [count](TetraPak_MultiStringValueHelper.md#TetraPak_MultiStringValueHelper_TrimLast(TetraPak_MultiStringValue_uint_bool)_count 'TetraPak.MultiStringValueHelper.TrimLast(TetraPak.MultiStringValue, uint, bool).count') (too high) an [Empty](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_Empty 'TetraPak.MultiStringValue.Empty') value is returned;  
otherwise a [System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') exception is thrown.  
  
#### Returns
[MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
A [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') with [count](TetraPak_MultiStringValueHelper.md#TetraPak_MultiStringValueHelper_TrimLast(TetraPak_MultiStringValue_uint_bool)_count 'TetraPak.MultiStringValueHelper.TrimLast(TetraPak.MultiStringValue, uint, bool).count') items removed from the end.  
  
