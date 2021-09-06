#### [TetraPak.Common](index.md 'index')
### [TetraPak.DynamicEntities](TetraPak_DynamicEntities.md 'TetraPak.DynamicEntities')
## DynamicPath Class
```csharp
public class DynamicPath :
TetraPak.IStringValue
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DynamicPath  

Implements [IStringValue](TetraPak_IStringValue.md 'TetraPak.IStringValue')  

| Constructors | |
| :--- | :--- |
| [DynamicPath(string, string)](TetraPak_DynamicEntities_DynamicPath_DynamicPath(string_string).md 'TetraPak.DynamicEntities.DynamicPath.DynamicPath(string, string)') | Initializes the value.<br/> |
| [DynamicPath(string[])](TetraPak_DynamicEntities_DynamicPath_DynamicPath(string__).md 'TetraPak.DynamicEntities.DynamicPath.DynamicPath(string[])') | Initializes the value from one or more items.<br/> |

| Properties | |
| :--- | :--- |
| [StringValue](TetraPak_DynamicEntities_DynamicPath_StringValue.md 'TetraPak.DynamicEntities.DynamicPath.StringValue') | The value's string representation.<br/> |

| Methods | |
| :--- | :--- |
| [Equals(object)](TetraPak_DynamicEntities_DynamicPath_Equals(object).md 'TetraPak.DynamicEntities.DynamicPath.Equals(object)') | Determines whether the specified object is equal to the current version.<br/> |
| [Equals(IEnumerable&lt;string&gt;, StringComparison)](TetraPak_DynamicEntities_DynamicPath_Equals(System_Collections_Generic_IEnumerable_string__System_StringComparison).md 'TetraPak.DynamicEntities.DynamicPath.Equals(System.Collections.Generic.IEnumerable&lt;string&gt;, System.StringComparison)') | Determines whether the specified string collection matches the current value.<br/> |
| [Equals(DynamicPath, StringComparison)](TetraPak_DynamicEntities_DynamicPath_Equals(TetraPak_DynamicEntities_DynamicPath_System_StringComparison).md 'TetraPak.DynamicEntities.DynamicPath.Equals(TetraPak.DynamicEntities.DynamicPath, System.StringComparison)') | Determines whether the specified value is equal to the current value.<br/> |
| [GetHashCode()](TetraPak_DynamicEntities_DynamicPath_GetHashCode().md 'TetraPak.DynamicEntities.DynamicPath.GetHashCode()') | Serves as the default hash function.<br/> |
| [Pop(uint)](TetraPak_DynamicEntities_DynamicPath_Pop(uint).md 'TetraPak.DynamicEntities.DynamicPath.Pop(uint)') | Pops item(s) from the end of the path and returns the result.<br/><br/>(fluent API)<br/> |
| [Push(string[])](TetraPak_DynamicEntities_DynamicPath_Push(string__).md 'TetraPak.DynamicEntities.DynamicPath.Push(string[])') | Pushes item(s) to the end of the path.<br/><br/>(fluent API)<br/> |
| [ToString()](TetraPak_DynamicEntities_DynamicPath_ToString().md 'TetraPak.DynamicEntities.DynamicPath.ToString()') | Returns a string that represents the current object. |
| [WithSeparator(string)](TetraPak_DynamicEntities_DynamicPath_WithSeparator(string).md 'TetraPak.DynamicEntities.DynamicPath.WithSeparator(string)') | Sets the [TetraPak.DynamicEntities.DynamicPath.Separator](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.DynamicEntities.DynamicPath.Separator 'TetraPak.DynamicEntities.DynamicPath.Separator') (fluent API).<br/> |

| Operators | |
| :--- | :--- |
| [operator ==(DynamicPath, DynamicPath)](TetraPak_DynamicEntities_DynamicPath_op_Equality(TetraPak_DynamicEntities_DynamicPath_TetraPak_DynamicEntities_DynamicPath).md 'TetraPak.DynamicEntities.DynamicPath.op_Equality(TetraPak.DynamicEntities.DynamicPath, TetraPak.DynamicEntities.DynamicPath)') | Comparison operator overload.<br/> |
| [implicit operator string(DynamicPath)](TetraPak_DynamicEntities_DynamicPath_op_Implicitstring(TetraPak_DynamicEntities_DynamicPath).md 'TetraPak.DynamicEntities.DynamicPath.op_Implicit string(TetraPak.DynamicEntities.DynamicPath)') | Implicitly converts a [DynamicPath](TetraPak_DynamicEntities_DynamicPath.md 'TetraPak.DynamicEntities.DynamicPath') value into its [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation.<br/> |
| [implicit operator DynamicPath(string)](TetraPak_DynamicEntities_DynamicPath_op_ImplicitTetraPak_DynamicEntities_DynamicPath(string).md 'TetraPak.DynamicEntities.DynamicPath.op_Implicit TetraPak.DynamicEntities.DynamicPath(string)') | Implicitly converts a string literal into a [DynamicPath](TetraPak_DynamicEntities_DynamicPath.md 'TetraPak.DynamicEntities.DynamicPath').<br/> |
| [operator !=(DynamicPath, DynamicPath)](TetraPak_DynamicEntities_DynamicPath_op_Inequality(TetraPak_DynamicEntities_DynamicPath_TetraPak_DynamicEntities_DynamicPath).md 'TetraPak.DynamicEntities.DynamicPath.op_Inequality(TetraPak.DynamicEntities.DynamicPath, TetraPak.DynamicEntities.DynamicPath)') | Comparison operator overload.<br/> |
