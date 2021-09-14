#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak')
## StringValueBase Class
```csharp
public class StringValueBase :
TetraPak.IStringValue
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; StringValueBase  

Derived  
&#8627; [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  

Implements [IStringValue](TetraPak_IStringValue.md 'TetraPak.IStringValue')  
### Methods
<a name='TetraPak_StringValueBase_Equals(object)'></a>
## StringValueBase.Equals(object) Method
Determines whether the specified object is equal to the current version.  
```csharp
public override bool Equals(object obj);
```
#### Parameters
<a name='TetraPak_StringValueBase_Equals(object)_obj'></a>
`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
An object to compare to this value.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the specified object is equal to the current version; otherwise `false`.  
            
  
<a name='TetraPak_StringValueBase_Equals(TetraPak_StringValueBase)'></a>
## StringValueBase.Equals(StringValueBase) Method
Determines whether the specified value is equal to the current value.  
```csharp
public bool Equals(TetraPak.StringValueBase other);
```
#### Parameters
<a name='TetraPak_StringValueBase_Equals(TetraPak_StringValueBase)_other'></a>
`other` [StringValueBase](TetraPak_StringValueBase.md 'TetraPak.StringValueBase')  
A [StringValueBase](TetraPak_StringValueBase.md 'TetraPak.StringValueBase') value to compare to this value.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if [other](TetraPak_StringValueBase.md#TetraPak_StringValueBase_Equals(TetraPak_StringValueBase)_other 'TetraPak.StringValueBase.Equals(TetraPak.StringValueBase).other') is equal to the current value; otherwise `false`.  
            
  
<a name='TetraPak_StringValueBase_GetHashCode()'></a>
## StringValueBase.GetHashCode() Method
Serves as the default hash function.  
```csharp
public override int GetHashCode();
```
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
A hash code for the current value.  
  
### Operators
<a name='TetraPak_StringValueBase_op_Equality(TetraPak_StringValueBase_TetraPak_StringValueBase)'></a>
## StringValueBase.operator ==(StringValueBase, StringValueBase) Operator
Comparison operator overload.  
```csharp
public static bool operator ==(TetraPak.StringValueBase left, TetraPak.StringValueBase right);
```
#### Parameters
<a name='TetraPak_StringValueBase_op_Equality(TetraPak_StringValueBase_TetraPak_StringValueBase)_left'></a>
`left` [StringValueBase](TetraPak_StringValueBase.md 'TetraPak.StringValueBase')  
  
<a name='TetraPak_StringValueBase_op_Equality(TetraPak_StringValueBase_TetraPak_StringValueBase)_right'></a>
`right` [StringValueBase](TetraPak_StringValueBase.md 'TetraPak.StringValueBase')  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
  
<a name='TetraPak_StringValueBase_op_Inequality(TetraPak_StringValueBase_TetraPak_StringValueBase)'></a>
## StringValueBase.operator !=(StringValueBase, StringValueBase) Operator
Comparison operator overload.  
```csharp
public static bool operator !=(TetraPak.StringValueBase left, TetraPak.StringValueBase right);
```
#### Parameters
<a name='TetraPak_StringValueBase_op_Inequality(TetraPak_StringValueBase_TetraPak_StringValueBase)_left'></a>
`left` [StringValueBase](TetraPak_StringValueBase.md 'TetraPak.StringValueBase')  
  
<a name='TetraPak_StringValueBase_op_Inequality(TetraPak_StringValueBase_TetraPak_StringValueBase)_right'></a>
`right` [StringValueBase](TetraPak_StringValueBase.md 'TetraPak.StringValueBase')  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
  
