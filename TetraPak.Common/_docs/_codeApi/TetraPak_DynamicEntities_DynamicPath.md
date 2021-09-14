#### [TetraPak.Common](index.md 'index')
### [TetraPak.DynamicEntities](TetraPak_DynamicEntities.md 'TetraPak.DynamicEntities')
## DynamicPath Class
```csharp
public class DynamicPath :
TetraPak.IStringValue
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DynamicPath  

Implements [IStringValue](TetraPak_IStringValue.md 'TetraPak.IStringValue')  
### Constructors
<a name='TetraPak_DynamicEntities_DynamicPath_DynamicPath(string_string)'></a>
## DynamicPath.DynamicPath(string, string) Constructor
Initializes the value.  
```csharp
public DynamicPath(string stringValue, string separator=null);
```
#### Parameters
<a name='TetraPak_DynamicEntities_DynamicPath_DynamicPath(string_string)_stringValue'></a>
`stringValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The new value's string representation (will automatically be parsed).  
  
<a name='TetraPak_DynamicEntities_DynamicPath_DynamicPath(string_string)_separator'></a>
`separator` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
(optional)<br/>  
Specifies a (custom) separator.   
  
#### Exceptions
[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')  
The [stringValue](TetraPak_DynamicEntities_DynamicPath.md#TetraPak_DynamicEntities_DynamicPath_DynamicPath(string_string)_stringValue 'TetraPak.DynamicEntities.DynamicPath.DynamicPath(string, string).stringValue') string representation was incorrectly formed.  
  
<a name='TetraPak_DynamicEntities_DynamicPath_DynamicPath(string__)'></a>
## DynamicPath.DynamicPath(string[]) Constructor
Initializes the value from one or more items.  
```csharp
public DynamicPath(params string[] items);
```
#### Parameters
<a name='TetraPak_DynamicEntities_DynamicPath_DynamicPath(string__)_items'></a>
`items` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
  
  
### Properties
<a name='TetraPak_DynamicEntities_DynamicPath_StringValue'></a>
## DynamicPath.StringValue Property
The value's string representation.  
```csharp
public string StringValue { get; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Implements [StringValue](TetraPak_IStringValue.md#TetraPak_IStringValue_StringValue 'TetraPak.IStringValue.StringValue')  
  
### Methods
<a name='TetraPak_DynamicEntities_DynamicPath_Equals(object)'></a>
## DynamicPath.Equals(object) Method
Determines whether the specified object is equal to the current version.  
```csharp
public override bool Equals(object obj);
```
#### Parameters
<a name='TetraPak_DynamicEntities_DynamicPath_Equals(object)_obj'></a>
`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
An object to compare to this value.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the specified object is equal to the current version; otherwise `false`.  
            
  
<a name='TetraPak_DynamicEntities_DynamicPath_Equals(System_Collections_Generic_IEnumerable_string__System_StringComparison)'></a>
## DynamicPath.Equals(IEnumerable&lt;string&gt;, StringComparison) Method
Determines whether the specified string collection matches the current value.  
```csharp
public bool Equals(System.Collections.Generic.IEnumerable<string> items, System.StringComparison stringComparison=System.StringComparison.InvariantCulture);
```
#### Parameters
<a name='TetraPak_DynamicEntities_DynamicPath_Equals(System_Collections_Generic_IEnumerable_string__System_StringComparison)_items'></a>
`items` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The string items to compare this value to.  
  
<a name='TetraPak_DynamicEntities_DynamicPath_Equals(System_Collections_Generic_IEnumerable_string__System_StringComparison)_stringComparison'></a>
`stringComparison` [System.StringComparison](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparison 'System.StringComparison')  
Specifies the string comparison strategy.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the [items](TetraPak_DynamicEntities_DynamicPath.md#TetraPak_DynamicEntities_DynamicPath_Equals(System_Collections_Generic_IEnumerable_string__System_StringComparison)_items 'TetraPak.DynamicEntities.DynamicPath.Equals(System.Collections.Generic.IEnumerable&lt;string&gt;, System.StringComparison).items') matches the internal items of the current value; otherwise `false`.  
            
  
<a name='TetraPak_DynamicEntities_DynamicPath_Equals(TetraPak_DynamicEntities_DynamicPath_System_StringComparison)'></a>
## DynamicPath.Equals(DynamicPath, StringComparison) Method
Determines whether the specified value is equal to the current value.  
```csharp
public bool Equals(TetraPak.DynamicEntities.DynamicPath other, System.StringComparison stringComparison=System.StringComparison.InvariantCulture);
```
#### Parameters
<a name='TetraPak_DynamicEntities_DynamicPath_Equals(TetraPak_DynamicEntities_DynamicPath_System_StringComparison)_other'></a>
`other` [DynamicPath](TetraPak_DynamicEntities_DynamicPath.md 'TetraPak.DynamicEntities.DynamicPath')  
A [DynamicPath](TetraPak_DynamicEntities_DynamicPath.md 'TetraPak.DynamicEntities.DynamicPath') value to compare to this value.  
  
<a name='TetraPak_DynamicEntities_DynamicPath_Equals(TetraPak_DynamicEntities_DynamicPath_System_StringComparison)_stringComparison'></a>
`stringComparison` [System.StringComparison](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparison 'System.StringComparison')  
Specifies the string comparison strategy.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if [other](TetraPak_DynamicEntities_DynamicPath.md#TetraPak_DynamicEntities_DynamicPath_Equals(TetraPak_DynamicEntities_DynamicPath_System_StringComparison)_other 'TetraPak.DynamicEntities.DynamicPath.Equals(TetraPak.DynamicEntities.DynamicPath, System.StringComparison).other') is equal to the current value; otherwise `false`.  
            
  
<a name='TetraPak_DynamicEntities_DynamicPath_GetHashCode()'></a>
## DynamicPath.GetHashCode() Method
Serves as the default hash function.  
```csharp
public override int GetHashCode();
```
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
A hash code for the current value.  
  
<a name='TetraPak_DynamicEntities_DynamicPath_Pop(uint)'></a>
## DynamicPath.Pop(uint) Method
Pops item(s) from the end of the path and returns the result.<br/>  
(fluent API)  
```csharp
public TetraPak.DynamicEntities.DynamicPath Pop(uint count=1u);
```
#### Parameters
<a name='TetraPak_DynamicEntities_DynamicPath_Pop(uint)_count'></a>
`count` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')  
(optional; default=1)<br/>  
Specifies the number of items to remove from end of path.  
  
#### Returns
[DynamicPath](TetraPak_DynamicEntities_DynamicPath.md 'TetraPak.DynamicEntities.DynamicPath')  
The resulting value.  
  
<a name='TetraPak_DynamicEntities_DynamicPath_Push(string__)'></a>
## DynamicPath.Push(string[]) Method
Pushes item(s) to the end of the path.<br/>  
(fluent API)  
```csharp
public TetraPak.DynamicEntities.DynamicPath Push(params string[] items);
```
#### Parameters
<a name='TetraPak_DynamicEntities_DynamicPath_Push(string__)_items'></a>
`items` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
  
#### Returns
[DynamicPath](TetraPak_DynamicEntities_DynamicPath.md 'TetraPak.DynamicEntities.DynamicPath')  
The resulting value.  
  
<a name='TetraPak_DynamicEntities_DynamicPath_ToString()'></a>
## DynamicPath.ToString() Method
Returns a string that represents the current object.
```csharp
public override string ToString();
```
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string that represents the current object.
  
<a name='TetraPak_DynamicEntities_DynamicPath_WithSeparator(string)'></a>
## DynamicPath.WithSeparator(string) Method
Sets the [TetraPak.DynamicEntities.DynamicPath.Separator](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.DynamicEntities.DynamicPath.Separator 'TetraPak.DynamicEntities.DynamicPath.Separator') (fluent API).  
```csharp
public TetraPak.DynamicEntities.DynamicPath WithSeparator(string separator);
```
#### Parameters
<a name='TetraPak_DynamicEntities_DynamicPath_WithSeparator(string)_separator'></a>
`separator` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
#### Returns
[DynamicPath](TetraPak_DynamicEntities_DynamicPath.md 'TetraPak.DynamicEntities.DynamicPath')  
This value.  
  
### Operators
<a name='TetraPak_DynamicEntities_DynamicPath_op_Equality(TetraPak_DynamicEntities_DynamicPath_TetraPak_DynamicEntities_DynamicPath)'></a>
## DynamicPath.operator ==(DynamicPath, DynamicPath) Operator
Comparison operator overload.  
```csharp
public static bool operator ==(TetraPak.DynamicEntities.DynamicPath left, TetraPak.DynamicEntities.DynamicPath right);
```
#### Parameters
<a name='TetraPak_DynamicEntities_DynamicPath_op_Equality(TetraPak_DynamicEntities_DynamicPath_TetraPak_DynamicEntities_DynamicPath)_left'></a>
`left` [DynamicPath](TetraPak_DynamicEntities_DynamicPath.md 'TetraPak.DynamicEntities.DynamicPath')  
  
<a name='TetraPak_DynamicEntities_DynamicPath_op_Equality(TetraPak_DynamicEntities_DynamicPath_TetraPak_DynamicEntities_DynamicPath)_right'></a>
`right` [DynamicPath](TetraPak_DynamicEntities_DynamicPath.md 'TetraPak.DynamicEntities.DynamicPath')  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
  
<a name='TetraPak_DynamicEntities_DynamicPath_op_Implicitstring(TetraPak_DynamicEntities_DynamicPath)'></a>
## DynamicPath.implicit operator string(DynamicPath) Operator
Implicitly converts a [DynamicPath](TetraPak_DynamicEntities_DynamicPath.md 'TetraPak.DynamicEntities.DynamicPath') value into its [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation.  
```csharp
public static string implicit operator string(TetraPak.DynamicEntities.DynamicPath value);
```
#### Parameters
<a name='TetraPak_DynamicEntities_DynamicPath_op_Implicitstring(TetraPak_DynamicEntities_DynamicPath)_value'></a>
`value` [DynamicPath](TetraPak_DynamicEntities_DynamicPath.md 'TetraPak.DynamicEntities.DynamicPath')  
A [DynamicPath](TetraPak_DynamicEntities_DynamicPath.md 'TetraPak.DynamicEntities.DynamicPath') value to be implicitly converted into its [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation.  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation of [value](TetraPak_DynamicEntities_DynamicPath.md#TetraPak_DynamicEntities_DynamicPath_op_Implicitstring(TetraPak_DynamicEntities_DynamicPath)_value 'TetraPak.DynamicEntities.DynamicPath.op_Implicit string(TetraPak.DynamicEntities.DynamicPath).value').  
  
<a name='TetraPak_DynamicEntities_DynamicPath_op_ImplicitTetraPak_DynamicEntities_DynamicPath(string)'></a>
## DynamicPath.implicit operator DynamicPath(string) Operator
Implicitly converts a string literal into a [DynamicPath](TetraPak_DynamicEntities_DynamicPath.md 'TetraPak.DynamicEntities.DynamicPath').  
```csharp
public static TetraPak.DynamicEntities.DynamicPath implicit operator DynamicPath(string stringValue);
```
#### Parameters
<a name='TetraPak_DynamicEntities_DynamicPath_op_ImplicitTetraPak_DynamicEntities_DynamicPath(string)_stringValue'></a>
`stringValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string representation of the [DynamicPath](TetraPak_DynamicEntities_DynamicPath.md 'TetraPak.DynamicEntities.DynamicPath') value.  
  
#### Returns
[DynamicPath](TetraPak_DynamicEntities_DynamicPath.md 'TetraPak.DynamicEntities.DynamicPath')  
A [DynamicPath](TetraPak_DynamicEntities_DynamicPath.md 'TetraPak.DynamicEntities.DynamicPath') value.  
#### Exceptions
[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')  
The [stringValue](TetraPak_DynamicEntities_DynamicPath.md#TetraPak_DynamicEntities_DynamicPath_op_ImplicitTetraPak_DynamicEntities_DynamicPath(string)_stringValue 'TetraPak.DynamicEntities.DynamicPath.op_Implicit TetraPak.DynamicEntities.DynamicPath(string).stringValue') string representation was incorrectly formed.  
  
<a name='TetraPak_DynamicEntities_DynamicPath_op_Inequality(TetraPak_DynamicEntities_DynamicPath_TetraPak_DynamicEntities_DynamicPath)'></a>
## DynamicPath.operator !=(DynamicPath, DynamicPath) Operator
Comparison operator overload.  
```csharp
public static bool operator !=(TetraPak.DynamicEntities.DynamicPath left, TetraPak.DynamicEntities.DynamicPath right);
```
#### Parameters
<a name='TetraPak_DynamicEntities_DynamicPath_op_Inequality(TetraPak_DynamicEntities_DynamicPath_TetraPak_DynamicEntities_DynamicPath)_left'></a>
`left` [DynamicPath](TetraPak_DynamicEntities_DynamicPath.md 'TetraPak.DynamicEntities.DynamicPath')  
  
<a name='TetraPak_DynamicEntities_DynamicPath_op_Inequality(TetraPak_DynamicEntities_DynamicPath_TetraPak_DynamicEntities_DynamicPath)_right'></a>
`right` [DynamicPath](TetraPak_DynamicEntities_DynamicPath.md 'TetraPak.DynamicEntities.DynamicPath')  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
  
