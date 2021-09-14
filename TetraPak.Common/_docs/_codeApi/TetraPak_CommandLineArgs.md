#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak')
## CommandLineArgs Class
```csharp
public class CommandLineArgs :
TetraPak.IStringValue
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; CommandLineArgs  

Implements [IStringValue](TetraPak_IStringValue.md 'TetraPak.IStringValue')  
### Constructors
<a name='TetraPak_CommandLineArgs_CommandLineArgs(string___bool)'></a>
## CommandLineArgs.CommandLineArgs(string[], bool) Constructor
Initializes the value.  
```csharp
public CommandLineArgs(string[] args, bool ignoreCase=false);
```
#### Parameters
<a name='TetraPak_CommandLineArgs_CommandLineArgs(string___bool)_args'></a>
`args` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The command line arguments to be represented as a value.  
  
<a name='TetraPak_CommandLineArgs_CommandLineArgs(string___bool)_ignoreCase'></a>
`ignoreCase` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
(optional; default=`false`)<br/>  
Specifies whether command line keys are case sensitive when looking up values (see [Get(string[])](TetraPak_CommandLineArgs.md#TetraPak_CommandLineArgs_Get(string__) 'TetraPak.CommandLineArgs.Get(string[])')).  
  
#### Exceptions
[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')  
The [args](TetraPak_CommandLineArgs.md#TetraPak_CommandLineArgs_CommandLineArgs(string___bool)_args 'TetraPak.CommandLineArgs.CommandLineArgs(string[], bool).args') string representation was incorrectly formed.  
  
### Properties
<a name='TetraPak_CommandLineArgs_StringValue'></a>
## CommandLineArgs.StringValue Property
The value's string representation.  
```csharp
public string StringValue { get; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Implements [StringValue](TetraPak_IStringValue.md#TetraPak_IStringValue_StringValue 'TetraPak.IStringValue.StringValue')  
  
### Methods
<a name='TetraPak_CommandLineArgs_Equals(object)'></a>
## CommandLineArgs.Equals(object) Method
Determines whether the specified object is equal to the current version.  
```csharp
public override bool Equals(object obj);
```
#### Parameters
<a name='TetraPak_CommandLineArgs_Equals(object)_obj'></a>
`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
An object to compare to this value.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the specified object is equal to the current version; otherwise `false`.  
            
  
<a name='TetraPak_CommandLineArgs_Equals(TetraPak_CommandLineArgs)'></a>
## CommandLineArgs.Equals(CommandLineArgs) Method
Determines whether the specified value is equal to the current value.  
```csharp
public bool Equals(TetraPak.CommandLineArgs other);
```
#### Parameters
<a name='TetraPak_CommandLineArgs_Equals(TetraPak_CommandLineArgs)_other'></a>
`other` [CommandLineArgs](TetraPak_CommandLineArgs.md 'TetraPak.CommandLineArgs')  
A [CommandLineArgs](TetraPak_CommandLineArgs.md 'TetraPak.CommandLineArgs') value to compare to this value.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if [other](TetraPak_CommandLineArgs.md#TetraPak_CommandLineArgs_Equals(TetraPak_CommandLineArgs)_other 'TetraPak.CommandLineArgs.Equals(TetraPak.CommandLineArgs).other') is equal to the current value; otherwise `false`.  
            
  
<a name='TetraPak_CommandLineArgs_Get(string__)'></a>
## CommandLineArgs.Get(string[]) Method
Looks for and returns a value identified by one or more keys.  
```csharp
public TetraPak.Outcome<string> Get(params string[] keys);
```
#### Parameters
<a name='TetraPak_CommandLineArgs_Get(string__)_keys'></a>
`keys` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
One or more keys to look for.  
  
#### Returns
[TetraPak.Outcome&lt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')  
  
<a name='TetraPak_CommandLineArgs_GetHashCode()'></a>
## CommandLineArgs.GetHashCode() Method
Serves as the default hash function.  
```csharp
public override int GetHashCode();
```
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
A hash code for the current value.  
  
<a name='TetraPak_CommandLineArgs_ToString()'></a>
## CommandLineArgs.ToString() Method
Returns a string that represents the current object.
```csharp
public override string ToString();
```
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string that represents the current object.
  
### Operators
<a name='TetraPak_CommandLineArgs_op_Equality(TetraPak_CommandLineArgs_TetraPak_CommandLineArgs)'></a>
## CommandLineArgs.operator ==(CommandLineArgs, CommandLineArgs) Operator
Comparison operator overload.  
```csharp
public static bool operator ==(TetraPak.CommandLineArgs left, TetraPak.CommandLineArgs right);
```
#### Parameters
<a name='TetraPak_CommandLineArgs_op_Equality(TetraPak_CommandLineArgs_TetraPak_CommandLineArgs)_left'></a>
`left` [CommandLineArgs](TetraPak_CommandLineArgs.md 'TetraPak.CommandLineArgs')  
  
<a name='TetraPak_CommandLineArgs_op_Equality(TetraPak_CommandLineArgs_TetraPak_CommandLineArgs)_right'></a>
`right` [CommandLineArgs](TetraPak_CommandLineArgs.md 'TetraPak.CommandLineArgs')  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
  
<a name='TetraPak_CommandLineArgs_op_Implicitstring(TetraPak_CommandLineArgs)'></a>
## CommandLineArgs.implicit operator string(CommandLineArgs) Operator
Implicitly converts a [CommandLineArgs](TetraPak_CommandLineArgs.md 'TetraPak.CommandLineArgs') value into its [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation.  
```csharp
public static string implicit operator string(TetraPak.CommandLineArgs value);
```
#### Parameters
<a name='TetraPak_CommandLineArgs_op_Implicitstring(TetraPak_CommandLineArgs)_value'></a>
`value` [CommandLineArgs](TetraPak_CommandLineArgs.md 'TetraPak.CommandLineArgs')  
A [CommandLineArgs](TetraPak_CommandLineArgs.md 'TetraPak.CommandLineArgs') value to be implicitly converted into its [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation.  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation of [value](TetraPak_CommandLineArgs.md#TetraPak_CommandLineArgs_op_Implicitstring(TetraPak_CommandLineArgs)_value 'TetraPak.CommandLineArgs.op_Implicit string(TetraPak.CommandLineArgs).value').  
  
<a name='TetraPak_CommandLineArgs_op_ImplicitTetraPak_CommandLineArgs(string)'></a>
## CommandLineArgs.implicit operator CommandLineArgs(string) Operator
Implicitly converts a string literal into a [CommandLineArgs](TetraPak_CommandLineArgs.md 'TetraPak.CommandLineArgs').  
```csharp
public static TetraPak.CommandLineArgs implicit operator CommandLineArgs(string stringValue);
```
#### Parameters
<a name='TetraPak_CommandLineArgs_op_ImplicitTetraPak_CommandLineArgs(string)_stringValue'></a>
`stringValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string representation of the [CommandLineArgs](TetraPak_CommandLineArgs.md 'TetraPak.CommandLineArgs') value.  
  
#### Returns
[CommandLineArgs](TetraPak_CommandLineArgs.md 'TetraPak.CommandLineArgs')  
A [CommandLineArgs](TetraPak_CommandLineArgs.md 'TetraPak.CommandLineArgs') value.  
#### Exceptions
[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')  
The [stringValue](TetraPak_CommandLineArgs.md#TetraPak_CommandLineArgs_op_ImplicitTetraPak_CommandLineArgs(string)_stringValue 'TetraPak.CommandLineArgs.op_Implicit TetraPak.CommandLineArgs(string).stringValue') string representation was incorrectly formed.  
  
<a name='TetraPak_CommandLineArgs_op_Inequality(TetraPak_CommandLineArgs_TetraPak_CommandLineArgs)'></a>
## CommandLineArgs.operator !=(CommandLineArgs, CommandLineArgs) Operator
Comparison operator overload.  
```csharp
public static bool operator !=(TetraPak.CommandLineArgs left, TetraPak.CommandLineArgs right);
```
#### Parameters
<a name='TetraPak_CommandLineArgs_op_Inequality(TetraPak_CommandLineArgs_TetraPak_CommandLineArgs)_left'></a>
`left` [CommandLineArgs](TetraPak_CommandLineArgs.md 'TetraPak.CommandLineArgs')  
  
<a name='TetraPak_CommandLineArgs_op_Inequality(TetraPak_CommandLineArgs_TetraPak_CommandLineArgs)_right'></a>
`right` [CommandLineArgs](TetraPak_CommandLineArgs.md 'TetraPak.CommandLineArgs')  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
  
