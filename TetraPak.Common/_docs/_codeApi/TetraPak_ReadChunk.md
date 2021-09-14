#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak')
## ReadChunk Class
```csharp
public class ReadChunk :
TetraPak.IStringValue
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ReadChunk  

Implements [IStringValue](TetraPak_IStringValue.md 'TetraPak.IStringValue')  
### Constructors
<a name='TetraPak_ReadChunk_ReadChunk(string)'></a>
## ReadChunk.ReadChunk(string) Constructor
Initializes the value.  
```csharp
public ReadChunk(string stringValue);
```
#### Parameters
<a name='TetraPak_ReadChunk_ReadChunk(string)_stringValue'></a>
`stringValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The new value's string representation (will automatically be parsed).  
  
#### Exceptions
[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')  
The [stringValue](TetraPak_ReadChunk.md#TetraPak_ReadChunk_ReadChunk(string)_stringValue 'TetraPak.ReadChunk.ReadChunk(string).stringValue') string representation was incorrectly formed.  
  
### Properties
<a name='TetraPak_ReadChunk_Count'></a>
## ReadChunk.Count Property
Number of entities to be included in read operation.  
```csharp
public int Count { get; set; }
```
#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
  
<a name='TetraPak_ReadChunk_Skip'></a>
## ReadChunk.Skip Property
Number of (leading) entities to be skipped in read operation.  
```csharp
public int Skip { get; set; }
```
#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
  
<a name='TetraPak_ReadChunk_StringValue'></a>
## ReadChunk.StringValue Property
The value's string representation.  
```csharp
public string StringValue { get; set; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Implements [StringValue](TetraPak_IStringValue.md#TetraPak_IStringValue_StringValue 'TetraPak.IStringValue.StringValue')  
  
### Methods
<a name='TetraPak_ReadChunk_Equals(object)'></a>
## ReadChunk.Equals(object) Method
Determines whether the specified object is equal to the current version.  
```csharp
public override bool Equals(object obj);
```
#### Parameters
<a name='TetraPak_ReadChunk_Equals(object)_obj'></a>
`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
An object to compare to this value.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the specified object is equal to the current version; otherwise `false`.  
            
  
<a name='TetraPak_ReadChunk_Equals(TetraPak_ReadChunk)'></a>
## ReadChunk.Equals(ReadChunk) Method
Determines whether the specified value is equal to the current value.  
```csharp
public bool Equals(TetraPak.ReadChunk other);
```
#### Parameters
<a name='TetraPak_ReadChunk_Equals(TetraPak_ReadChunk)_other'></a>
`other` [ReadChunk](TetraPak_ReadChunk.md 'TetraPak.ReadChunk')  
A [ReadChunk](TetraPak_ReadChunk.md 'TetraPak.ReadChunk') value to compare to this value.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if [other](TetraPak_ReadChunk.md#TetraPak_ReadChunk_Equals(TetraPak_ReadChunk)_other 'TetraPak.ReadChunk.Equals(TetraPak.ReadChunk).other') is equal to the current value; otherwise `false`.  
            
  
<a name='TetraPak_ReadChunk_GetHashCode()'></a>
## ReadChunk.GetHashCode() Method
Serves as the default hash function.  
```csharp
public override int GetHashCode();
```
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
A hash code for the current value.  
  
<a name='TetraPak_ReadChunk_ToString()'></a>
## ReadChunk.ToString() Method
Returns a string that represents the current object.
```csharp
public override string ToString();
```
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string that represents the current object.
  
### Operators
<a name='TetraPak_ReadChunk_op_Equality(TetraPak_ReadChunk_TetraPak_ReadChunk)'></a>
## ReadChunk.operator ==(ReadChunk, ReadChunk) Operator
Comparison operator overload.  
```csharp
public static bool operator ==(TetraPak.ReadChunk left, TetraPak.ReadChunk right);
```
#### Parameters
<a name='TetraPak_ReadChunk_op_Equality(TetraPak_ReadChunk_TetraPak_ReadChunk)_left'></a>
`left` [ReadChunk](TetraPak_ReadChunk.md 'TetraPak.ReadChunk')  
  
<a name='TetraPak_ReadChunk_op_Equality(TetraPak_ReadChunk_TetraPak_ReadChunk)_right'></a>
`right` [ReadChunk](TetraPak_ReadChunk.md 'TetraPak.ReadChunk')  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
  
<a name='TetraPak_ReadChunk_op_Implicitstring(TetraPak_ReadChunk)'></a>
## ReadChunk.implicit operator string(ReadChunk) Operator
Implicitly converts a [ReadChunk](TetraPak_ReadChunk.md 'TetraPak.ReadChunk') value into its [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation.  
```csharp
public static string implicit operator string(TetraPak.ReadChunk value);
```
#### Parameters
<a name='TetraPak_ReadChunk_op_Implicitstring(TetraPak_ReadChunk)_value'></a>
`value` [ReadChunk](TetraPak_ReadChunk.md 'TetraPak.ReadChunk')  
A [ReadChunk](TetraPak_ReadChunk.md 'TetraPak.ReadChunk') value to be implicitly converted into its [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation.  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation of [value](TetraPak_ReadChunk.md#TetraPak_ReadChunk_op_Implicitstring(TetraPak_ReadChunk)_value 'TetraPak.ReadChunk.op_Implicit string(TetraPak.ReadChunk).value').  
  
<a name='TetraPak_ReadChunk_op_ImplicitTetraPak_ReadChunk(string)'></a>
## ReadChunk.implicit operator ReadChunk(string) Operator
Implicitly converts a string literal into a [ReadChunk](TetraPak_ReadChunk.md 'TetraPak.ReadChunk').  
```csharp
public static TetraPak.ReadChunk implicit operator ReadChunk(string stringValue);
```
#### Parameters
<a name='TetraPak_ReadChunk_op_ImplicitTetraPak_ReadChunk(string)_stringValue'></a>
`stringValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string representation of the [ReadChunk](TetraPak_ReadChunk.md 'TetraPak.ReadChunk') value.  
  
#### Returns
[ReadChunk](TetraPak_ReadChunk.md 'TetraPak.ReadChunk')  
A [ReadChunk](TetraPak_ReadChunk.md 'TetraPak.ReadChunk') value.  
#### Exceptions
[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')  
The [stringValue](TetraPak_ReadChunk.md#TetraPak_ReadChunk_op_ImplicitTetraPak_ReadChunk(string)_stringValue 'TetraPak.ReadChunk.op_Implicit TetraPak.ReadChunk(string).stringValue') string representation was incorrectly formed.  
  
<a name='TetraPak_ReadChunk_op_Inequality(TetraPak_ReadChunk_TetraPak_ReadChunk)'></a>
## ReadChunk.operator !=(ReadChunk, ReadChunk) Operator
Comparison operator overload.  
```csharp
public static bool operator !=(TetraPak.ReadChunk left, TetraPak.ReadChunk right);
```
#### Parameters
<a name='TetraPak_ReadChunk_op_Inequality(TetraPak_ReadChunk_TetraPak_ReadChunk)_left'></a>
`left` [ReadChunk](TetraPak_ReadChunk.md 'TetraPak.ReadChunk')  
  
<a name='TetraPak_ReadChunk_op_Inequality(TetraPak_ReadChunk_TetraPak_ReadChunk)_right'></a>
`right` [ReadChunk](TetraPak_ReadChunk.md 'TetraPak.ReadChunk')  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
  
