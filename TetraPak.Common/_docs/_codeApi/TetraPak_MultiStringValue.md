#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak')
## MultiStringValue Class
Represents one or more supported user roles.  
```csharp
public class MultiStringValue : TetraPak.StringValueBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [StringValueBase](TetraPak_StringValueBase.md 'TetraPak.StringValueBase') &#129106; MultiStringValue  
### Constructors
<a name='TetraPak_MultiStringValue_MultiStringValue(string)'></a>
## MultiStringValue.MultiStringValue(string) Constructor
Initializes the value.  
```csharp
public MultiStringValue(string stringValue);
```
#### Parameters
<a name='TetraPak_MultiStringValue_MultiStringValue(string)_stringValue'></a>
`stringValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The new value's string representation (will automatically be parsed).  
  
#### Exceptions
[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')  
The [stringValue](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_MultiStringValue(string)_stringValue 'TetraPak.MultiStringValue.MultiStringValue(string).stringValue') string representation was incorrectly formed.  
  
### Fields
<a name='TetraPak_MultiStringValue_DefaultSeparator'></a>
## MultiStringValue.DefaultSeparator Field
The default separator used for parsing a [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue').   
```csharp
public const char DefaultSeparator = ,;
```
#### Field Value
[System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')
  
### Properties
<a name='TetraPak_MultiStringValue_Count'></a>
## MultiStringValue.Count Property
Gets the number of [Items](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_Items 'TetraPak.MultiStringValue.Items') in the value.  
```csharp
public int Count { get; }
```
#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
  
<a name='TetraPak_MultiStringValue_Empty'></a>
## MultiStringValue.Empty Property
Creates and returns an empty [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue').  
```csharp
public static TetraPak.MultiStringValue Empty { get; }
```
#### Property Value
[MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')
  
<a name='TetraPak_MultiStringValue_IsEmpty'></a>
## MultiStringValue.IsEmpty Property
Gets a value indicating whether the [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') is empty.  
```csharp
public bool IsEmpty { get; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
  
<a name='TetraPak_MultiStringValue_Items'></a>
## MultiStringValue.Items Property
Gets the string elements of the value as an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').  
```csharp
public string[] Items { get; set; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
  
### Methods
<a name='TetraPak_MultiStringValue_Equals(object)'></a>
## MultiStringValue.Equals(object) Method
Determines whether the specified object is equal to the current version.  
```csharp
public override bool Equals(object obj);
```
#### Parameters
<a name='TetraPak_MultiStringValue_Equals(object)_obj'></a>
`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
An object to compare to this value.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the specified object is equal to the current version; otherwise `false`.  
            
  
<a name='TetraPak_MultiStringValue_Equals(TetraPak_MultiStringValue)'></a>
## MultiStringValue.Equals(MultiStringValue) Method
Determines whether the specified value is equal to the current value.  
```csharp
public virtual bool Equals(TetraPak.MultiStringValue other);
```
#### Parameters
<a name='TetraPak_MultiStringValue_Equals(TetraPak_MultiStringValue)_other'></a>
`other` [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
A [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') value to compare to this value.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if [other](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_Equals(TetraPak_MultiStringValue)_other 'TetraPak.MultiStringValue.Equals(TetraPak.MultiStringValue).other') is equal to the current value; otherwise `false`.  
            
  
<a name='TetraPak_MultiStringValue_EqualsSemantically(TetraPak_MultiStringValue_System_StringComparison)'></a>
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
`true` both values contains same number of [Items](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_Items 'TetraPak.MultiStringValue.Items')  
              and all [Items](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_Items 'TetraPak.MultiStringValue.Items') in this value are present in [other](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_EqualsSemantically(TetraPak_MultiStringValue_System_StringComparison)_other 'TetraPak.MultiStringValue.EqualsSemantically(TetraPak.MultiStringValue, System.StringComparison).other').  
            
  
<a name='TetraPak_MultiStringValue_GetEnumerator()'></a>
## MultiStringValue.GetEnumerator() Method
Returns an enumerator that iterates through the collection.
```csharp
public System.Collections.Generic.IEnumerator<string> GetEnumerator();
```
#### Returns
[System.Collections.Generic.IEnumerator&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')  
An enumerator that can be used to iterate through the collection.
  
<a name='TetraPak_MultiStringValue_GetHashCode()'></a>
## MultiStringValue.GetHashCode() Method
Serves as the default hash function.  
```csharp
public override int GetHashCode();
```
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
A hash code for the current value.  
  
<a name='TetraPak_MultiStringValue_OnValidateItem(string_System_StringComparison)'></a>
## MultiStringValue.OnValidateItem(string, StringComparison) Method
Called during the parsing process to allow validation of a string item.  
Intended for derived [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') classes. This implementation always returns  
a successful result.   
```csharp
protected virtual TetraPak.Outcome<string> OnValidateItem(string item, System.StringComparison comparison=System.StringComparison.Ordinal);
```
#### Parameters
<a name='TetraPak_MultiStringValue_OnValidateItem(string_System_StringComparison)_item'></a>
`item` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') item to be validated.  
  
<a name='TetraPak_MultiStringValue_OnValidateItem(string_System_StringComparison)_comparison'></a>
`comparison` [System.StringComparison](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparison 'System.StringComparison')  
(optional; default=[System.StringComparison.Ordinal](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparison.Ordinal 'System.StringComparison.Ordinal'))<br/>  
A string comparison value to be honored by the validation.   
  
#### Returns
[TetraPak.Outcome&lt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')  
An [Outcome&lt;T&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;') to indicate success/failure and, on success, also carry  
a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') or, on failure, an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').  
  
<a name='TetraPak_MultiStringValue_ToString()'></a>
## MultiStringValue.ToString() Method
Returns a string that represents the current object.
```csharp
public override string ToString();
```
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string that represents the current object.
  
<a name='TetraPak_MultiStringValue_TryParse(string_TetraPak_MultiStringValue_System_StringComparison)'></a>
## MultiStringValue.TryParse(string, MultiStringValue, StringComparison) Method
Converts a string to its [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') equivalent.  
A return value indicates whether the conversion succeeded.  
```csharp
public static bool TryParse(string stringValue, out TetraPak.MultiStringValue multiStringValue, System.StringComparison comparison=System.StringComparison.Ordinal);
```
#### Parameters
<a name='TetraPak_MultiStringValue_TryParse(string_TetraPak_MultiStringValue_System_StringComparison)_stringValue'></a>
`stringValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string containing a [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') to convert.  
  
<a name='TetraPak_MultiStringValue_TryParse(string_TetraPak_MultiStringValue_System_StringComparison)_multiStringValue'></a>
`multiStringValue` [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
The successfully parsed [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue').  
  
<a name='TetraPak_MultiStringValue_TryParse(string_TetraPak_MultiStringValue_System_StringComparison)_comparison'></a>
`comparison` [System.StringComparison](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparison 'System.StringComparison')  
(optional)<br/>  
A [System.StringComparer](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparer 'System.StringComparer') used for parsing the [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue').  
This is mainly intended for the need in derived classes that needs to override the  
[OnValidateItem(string, StringComparison)](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_OnValidateItem(string_System_StringComparison) 'TetraPak.MultiStringValue.OnValidateItem(string, System.StringComparison)') method. The comparer have no effect in this class.   
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if [stringValue](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_TryParse(string_TetraPak_MultiStringValue_System_StringComparison)_stringValue 'TetraPak.MultiStringValue.TryParse(string, TetraPak.MultiStringValue, System.StringComparison).stringValue') was converted successfully; otherwise, `false`.  
            
#### See Also
- [TryParse&lt;T&gt;(string, T, StringComparison)](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_TryParse_T_(string_T_System_StringComparison) 'TetraPak.MultiStringValue.TryParse&lt;T&gt;(string, T, System.StringComparison)')
  
<a name='TetraPak_MultiStringValue_TryParse_T_(string_T_System_StringComparison)'></a>
## MultiStringValue.TryParse&lt;T&gt;(string, T, StringComparison) Method
Converts a string to its [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')-compatible equivalent.  
A return value indicates whether the conversion succeeded.  
```csharp
public static bool TryParse<T>(string stringValue, out T multiStringValue, System.StringComparison comparison=System.StringComparison.Ordinal)
    where T : TetraPak.MultiStringValue;
```
#### Type parameters
<a name='TetraPak_MultiStringValue_TryParse_T_(string_T_System_StringComparison)_T'></a>
`T`  
A [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type'), deriving from [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue'),  
for [stringValue](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_TryParse_T_(string_T_System_StringComparison)_stringValue 'TetraPak.MultiStringValue.TryParse&lt;T&gt;(string, T, System.StringComparison).stringValue') to be converted to.   
  
#### Parameters
<a name='TetraPak_MultiStringValue_TryParse_T_(string_T_System_StringComparison)_stringValue'></a>
`stringValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
<a name='TetraPak_MultiStringValue_TryParse_T_(string_T_System_StringComparison)_multiStringValue'></a>
`multiStringValue` [T](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_TryParse_T_(string_T_System_StringComparison)_T 'TetraPak.MultiStringValue.TryParse&lt;T&gt;(string, T, System.StringComparison).T')  
  
<a name='TetraPak_MultiStringValue_TryParse_T_(string_T_System_StringComparison)_comparison'></a>
`comparison` [System.StringComparison](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparison 'System.StringComparison')  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if [stringValue](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_TryParse_T_(string_T_System_StringComparison)_stringValue 'TetraPak.MultiStringValue.TryParse&lt;T&gt;(string, T, System.StringComparison).stringValue') was converted successfully; otherwise, `false`.  
            
#### See Also
- [TryParse(string, MultiStringValue, StringComparison)](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_TryParse(string_TetraPak_MultiStringValue_System_StringComparison) 'TetraPak.MultiStringValue.TryParse(string, TetraPak.MultiStringValue, System.StringComparison)')
  
<a name='TetraPak_MultiStringValue_WithoutDuplicates(string__)'></a>
## MultiStringValue.WithoutDuplicates(string[]) Method
Creates a [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') from one or more [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') items,  
automatically removing any duplicates.  
```csharp
public static TetraPak.MultiStringValue WithoutDuplicates(params string[] items);
```
#### Parameters
<a name='TetraPak_MultiStringValue_WithoutDuplicates(string__)_items'></a>
`items` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') items.   
  
#### Returns
[MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
A [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue').  
  
### Operators
<a name='TetraPak_MultiStringValue_op_Equality(TetraPak_MultiStringValue_TetraPak_MultiStringValue)'></a>
## MultiStringValue.operator ==(MultiStringValue, MultiStringValue) Operator
Comparison operator overload.  
```csharp
public static bool operator ==(TetraPak.MultiStringValue left, TetraPak.MultiStringValue right);
```
#### Parameters
<a name='TetraPak_MultiStringValue_op_Equality(TetraPak_MultiStringValue_TetraPak_MultiStringValue)_left'></a>
`left` [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
  
<a name='TetraPak_MultiStringValue_op_Equality(TetraPak_MultiStringValue_TetraPak_MultiStringValue)_right'></a>
`right` [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
  
<a name='TetraPak_MultiStringValue_op_Implicitstring(TetraPak_MultiStringValue)'></a>
## MultiStringValue.implicit operator string(MultiStringValue) Operator
Implicitly converts a [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') value into its [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation.  
```csharp
public static string implicit operator string(TetraPak.MultiStringValue value);
```
#### Parameters
<a name='TetraPak_MultiStringValue_op_Implicitstring(TetraPak_MultiStringValue)_value'></a>
`value` [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
A [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') value to be implicitly converted into its [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation.  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation of [value](TetraPak_MultiStringValue.md#TetraPak_MultiStringValue_op_Implicitstring(TetraPak_MultiStringValue)_value 'TetraPak.MultiStringValue.op_Implicit string(TetraPak.MultiStringValue).value').  
  
<a name='TetraPak_MultiStringValue_op_Inequality(TetraPak_MultiStringValue_TetraPak_MultiStringValue)'></a>
## MultiStringValue.operator !=(MultiStringValue, MultiStringValue) Operator
Comparison operator overload.  
```csharp
public static bool operator !=(TetraPak.MultiStringValue left, TetraPak.MultiStringValue right);
```
#### Parameters
<a name='TetraPak_MultiStringValue_op_Inequality(TetraPak_MultiStringValue_TetraPak_MultiStringValue)_left'></a>
`left` [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
  
<a name='TetraPak_MultiStringValue_op_Inequality(TetraPak_MultiStringValue_TetraPak_MultiStringValue)_right'></a>
`right` [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
  
