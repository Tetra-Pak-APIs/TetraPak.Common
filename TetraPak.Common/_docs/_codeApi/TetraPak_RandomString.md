#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak')
## RandomString Class
```csharp
public class RandomString :
TetraPak.IStringValue
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; RandomString  

Implements [IStringValue](TetraPak_IStringValue.md 'TetraPak.IStringValue')  
### Constructors
<a name='TetraPak_RandomString_RandomString(uint_bool)'></a>
## RandomString.RandomString(uint, bool) Constructor
Initializes the value.  
```csharp
public RandomString(uint length=0u, bool allowSpecialCharacters=false);
```
#### Parameters
<a name='TetraPak_RandomString_RandomString(uint_bool)_length'></a>
`length` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')  
The length of the random string.  
  
<a name='TetraPak_RandomString_RandomString(uint_bool)_allowSpecialCharacters'></a>
`allowSpecialCharacters` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
When set, special characters can be included in the random string.   
  
  
### Properties
<a name='TetraPak_RandomString_StringValue'></a>
## RandomString.StringValue Property
The value's string representation.  
```csharp
public string StringValue { get; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Implements [StringValue](TetraPak_IStringValue.md#TetraPak_IStringValue_StringValue 'TetraPak.IStringValue.StringValue')  
  
### Methods
<a name='TetraPak_RandomString_Equals(object)'></a>
## RandomString.Equals(object) Method
Determines whether the specified object is equal to the current version.  
```csharp
public override bool Equals(object obj);
```
#### Parameters
<a name='TetraPak_RandomString_Equals(object)_obj'></a>
`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
An object to compare to this value.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the specified object is equal to the current version; otherwise `false`.  
            
  
<a name='TetraPak_RandomString_Equals(TetraPak_RandomString)'></a>
## RandomString.Equals(RandomString) Method
Determines whether the specified value is equal to the current value.  
```csharp
public bool Equals(TetraPak.RandomString other);
```
#### Parameters
<a name='TetraPak_RandomString_Equals(TetraPak_RandomString)_other'></a>
`other` [RandomString](TetraPak_RandomString.md 'TetraPak.RandomString')  
A [RandomString](TetraPak_RandomString.md 'TetraPak.RandomString') value to compare to this value.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if [other](TetraPak_RandomString.md#TetraPak_RandomString_Equals(TetraPak_RandomString)_other 'TetraPak.RandomString.Equals(TetraPak.RandomString).other') is equal to the current value; otherwise `false`.  
            
  
<a name='TetraPak_RandomString_GetHashCode()'></a>
## RandomString.GetHashCode() Method
Serves as the default hash function.  
```csharp
public override int GetHashCode();
```
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
A hash code for the current value.  
  
<a name='TetraPak_RandomString_ToString()'></a>
## RandomString.ToString() Method
Returns a string that represents the current object.
```csharp
public override string ToString();
```
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string that represents the current object.
  
### Operators
<a name='TetraPak_RandomString_op_Equality(TetraPak_RandomString_TetraPak_RandomString)'></a>
## RandomString.operator ==(RandomString, RandomString) Operator
Comparison operator overload.  
```csharp
public static bool operator ==(TetraPak.RandomString left, TetraPak.RandomString right);
```
#### Parameters
<a name='TetraPak_RandomString_op_Equality(TetraPak_RandomString_TetraPak_RandomString)_left'></a>
`left` [RandomString](TetraPak_RandomString.md 'TetraPak.RandomString')  
  
<a name='TetraPak_RandomString_op_Equality(TetraPak_RandomString_TetraPak_RandomString)_right'></a>
`right` [RandomString](TetraPak_RandomString.md 'TetraPak.RandomString')  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
  
<a name='TetraPak_RandomString_op_Implicitstring(TetraPak_RandomString)'></a>
## RandomString.implicit operator string(RandomString) Operator
Implicitly converts a [RandomString](TetraPak_RandomString.md 'TetraPak.RandomString') value into its [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation.  
```csharp
public static string implicit operator string(TetraPak.RandomString value);
```
#### Parameters
<a name='TetraPak_RandomString_op_Implicitstring(TetraPak_RandomString)_value'></a>
`value` [RandomString](TetraPak_RandomString.md 'TetraPak.RandomString')  
A [RandomString](TetraPak_RandomString.md 'TetraPak.RandomString') value to be implicitly converted into its [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation.  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation of [value](TetraPak_RandomString.md#TetraPak_RandomString_op_Implicitstring(TetraPak_RandomString)_value 'TetraPak.RandomString.op_Implicit string(TetraPak.RandomString).value').  
  
<a name='TetraPak_RandomString_op_Inequality(TetraPak_RandomString_TetraPak_RandomString)'></a>
## RandomString.operator !=(RandomString, RandomString) Operator
Comparison operator overload.  
```csharp
public static bool operator !=(TetraPak.RandomString left, TetraPak.RandomString right);
```
#### Parameters
<a name='TetraPak_RandomString_op_Inequality(TetraPak_RandomString_TetraPak_RandomString)_left'></a>
`left` [RandomString](TetraPak_RandomString.md 'TetraPak.RandomString')  
  
<a name='TetraPak_RandomString_op_Inequality(TetraPak_RandomString_TetraPak_RandomString)_right'></a>
`right` [RandomString](TetraPak_RandomString.md 'TetraPak.RandomString')  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
  
