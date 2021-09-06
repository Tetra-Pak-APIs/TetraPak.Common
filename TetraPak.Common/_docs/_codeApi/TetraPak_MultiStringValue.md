#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak')
## MultiStringValue Class
Represents one or more supported user roles.  
```csharp
public class MultiStringValue : TetraPak.StringValueBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [StringValueBase](TetraPak_StringValueBase.md 'TetraPak.StringValueBase') &#129106; MultiStringValue  

| Constructors | |
| :--- | :--- |
| [MultiStringValue(string)](TetraPak_MultiStringValue_MultiStringValue(string).md 'TetraPak.MultiStringValue.MultiStringValue(string)') | Initializes the value.<br/> |

| Fields | |
| :--- | :--- |
| [DefaultSeparator](TetraPak_MultiStringValue_DefaultSeparator.md 'TetraPak.MultiStringValue.DefaultSeparator') | The default separator used for parsing a [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue'). <br/> |

| Properties | |
| :--- | :--- |
| [Count](TetraPak_MultiStringValue_Count.md 'TetraPak.MultiStringValue.Count') | Gets the number of [Items](TetraPak_MultiStringValue_Items.md 'TetraPak.MultiStringValue.Items') in the value.<br/> |
| [Empty](TetraPak_MultiStringValue_Empty.md 'TetraPak.MultiStringValue.Empty') | Creates and returns an empty [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue').<br/> |
| [IsEmpty](TetraPak_MultiStringValue_IsEmpty.md 'TetraPak.MultiStringValue.IsEmpty') | Gets a value indicating whether the [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') is empty.<br/> |
| [Items](TetraPak_MultiStringValue_Items.md 'TetraPak.MultiStringValue.Items') | Gets the string elements of the value as an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') of [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').<br/> |

| Methods | |
| :--- | :--- |
| [Equals(object)](TetraPak_MultiStringValue_Equals(object).md 'TetraPak.MultiStringValue.Equals(object)') | Determines whether the specified object is equal to the current version.<br/> |
| [Equals(MultiStringValue)](TetraPak_MultiStringValue_Equals(TetraPak_MultiStringValue).md 'TetraPak.MultiStringValue.Equals(TetraPak.MultiStringValue)') | Determines whether the specified value is equal to the current value.<br/> |
| [EqualsSemantically(MultiStringValue, StringComparison)](TetraPak_MultiStringValue_EqualsSemantically(TetraPak_MultiStringValue_System_StringComparison).md 'TetraPak.MultiStringValue.EqualsSemantically(TetraPak.MultiStringValue, System.StringComparison)') | Compares with another [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') and returns a value to indicate<br/>whether all items in this value are present in the other, regardless of item's order.<br/> |
| [GetEnumerator()](TetraPak_MultiStringValue_GetEnumerator().md 'TetraPak.MultiStringValue.GetEnumerator()') | Returns an enumerator that iterates through the collection. |
| [GetHashCode()](TetraPak_MultiStringValue_GetHashCode().md 'TetraPak.MultiStringValue.GetHashCode()') | Serves as the default hash function.<br/> |
| [OnValidateItem(string, StringComparison)](TetraPak_MultiStringValue_OnValidateItem(string_System_StringComparison).md 'TetraPak.MultiStringValue.OnValidateItem(string, System.StringComparison)') | Called during the parsing process to allow validation of a string item.<br/>Intended for derived [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') classes. This implementation always returns<br/>a successful result. <br/> |
| [ToString()](TetraPak_MultiStringValue_ToString().md 'TetraPak.MultiStringValue.ToString()') | Returns a string that represents the current object. |
| [TryParse(string, MultiStringValue, StringComparison)](TetraPak_MultiStringValue_TryParse(string_TetraPak_MultiStringValue_System_StringComparison).md 'TetraPak.MultiStringValue.TryParse(string, TetraPak.MultiStringValue, System.StringComparison)') | Converts a string to its [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') equivalent.<br/>A return value indicates whether the conversion succeeded.<br/> |
| [TryParse&lt;T&gt;(string, T, StringComparison)](TetraPak_MultiStringValue_TryParse_T_(string_T_System_StringComparison).md 'TetraPak.MultiStringValue.TryParse&lt;T&gt;(string, T, System.StringComparison)') | Converts a string to its [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue')-compatible equivalent.<br/>A return value indicates whether the conversion succeeded.<br/> |
| [WithoutDuplicates(string[])](TetraPak_MultiStringValue_WithoutDuplicates(string__).md 'TetraPak.MultiStringValue.WithoutDuplicates(string[])') | Creates a [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') from one or more [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') items,<br/>automatically removing any duplicates.<br/> |

| Operators | |
| :--- | :--- |
| [operator ==(MultiStringValue, MultiStringValue)](TetraPak_MultiStringValue_op_Equality(TetraPak_MultiStringValue_TetraPak_MultiStringValue).md 'TetraPak.MultiStringValue.op_Equality(TetraPak.MultiStringValue, TetraPak.MultiStringValue)') | Comparison operator overload.<br/> |
| [implicit operator string(MultiStringValue)](TetraPak_MultiStringValue_op_Implicitstring(TetraPak_MultiStringValue).md 'TetraPak.MultiStringValue.op_Implicit string(TetraPak.MultiStringValue)') | Implicitly converts a [MultiStringValue](TetraPak_MultiStringValue.md 'TetraPak.MultiStringValue') value into its [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation.<br/> |
| [operator !=(MultiStringValue, MultiStringValue)](TetraPak_MultiStringValue_op_Inequality(TetraPak_MultiStringValue_TetraPak_MultiStringValue).md 'TetraPak.MultiStringValue.op_Inequality(TetraPak.MultiStringValue, TetraPak.MultiStringValue)') | Comparison operator overload.<br/> |
