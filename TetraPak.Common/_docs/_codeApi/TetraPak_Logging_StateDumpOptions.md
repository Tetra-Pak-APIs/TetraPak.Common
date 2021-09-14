#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging')
## StateDumpOptions Class
Used to specify data for getting the current state.  
```csharp
public class StateDumpOptions :
System.Collections.Generic.IDictionary<string, bool>,
System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, bool>>,
System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, bool>>,
System.Collections.IEnumerable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; StateDumpOptions  

Implements [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2'), [System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  
### Constructors
<a name='TetraPak_Logging_StateDumpOptions_StateDumpOptions(object_Microsoft_Extensions_Logging_ILogger__System_Func_System_Reflection_PropertyInfo_bool__)'></a>
## StateDumpOptions.StateDumpOptions(object, ILogger?, Func&lt;PropertyInfo,bool&gt;?) Constructor
Initializes the [StateDumpOptions](TetraPak_Logging_StateDumpOptions.md 'TetraPak.Logging.StateDumpOptions') with default options.  
```csharp
public StateDumpOptions(object obj, Microsoft.Extensions.Logging.ILogger? logger=null, System.Func<System.Reflection.PropertyInfo,bool>? includeHandler=null);
```
#### Parameters
<a name='TetraPak_Logging_StateDumpOptions_StateDumpOptions(object_Microsoft_Extensions_Logging_ILogger__System_Func_System_Reflection_PropertyInfo_bool__)_obj'></a>
`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The object to be state dumped.  
  
<a name='TetraPak_Logging_StateDumpOptions_StateDumpOptions(object_Microsoft_Extensions_Logging_ILogger__System_Func_System_Reflection_PropertyInfo_bool__)_logger'></a>
`logger` [Microsoft.Extensions.Logging.ILogger](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger 'Microsoft.Extensions.Logging.ILogger')  
(optional)<br/>  
A target logger provider. Adding this to the options is necessary if you need to disclose  
restricted values, based on the declared [Microsoft.Extensions.Logging.LogLevel](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.LogLevel 'Microsoft.Extensions.Logging.LogLevel').   
  
<a name='TetraPak_Logging_StateDumpOptions_StateDumpOptions(object_Microsoft_Extensions_Logging_ILogger__System_Func_System_Reflection_PropertyInfo_bool__)_includeHandler'></a>
`includeHandler` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Reflection.PropertyInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
(optional)<br/>  
When assigned this handler will be invoked for all decorated ([StateDumpAttribute](TetraPak_Logging_StateDumpAttribute.md 'TetraPak.Logging.StateDumpAttribute'))  
properties of [obj](TetraPak_Logging_StateDumpOptions.md#TetraPak_Logging_StateDumpOptions_StateDumpOptions(object_Microsoft_Extensions_Logging_ILogger__System_Func_System_Reflection_PropertyInfo_bool__)_obj 'TetraPak.Logging.StateDumpOptions.StateDumpOptions(object, Microsoft.Extensions.Logging.ILogger?, System.Func&lt;System.Reflection.PropertyInfo,bool&gt;?).obj') to return a value specifying whether to include the  
property or not (the handler mist return `true` for the property to be included in state dump).  
  
#### See Also
- [RestrictedValueAttribute](TetraPak_RestrictedValueAttribute.md 'TetraPak.RestrictedValueAttribute')
  
### Properties
<a name='TetraPak_Logging_StateDumpOptions_Count'></a>
## StateDumpOptions.Count Property
Gets the number of elements contained in the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').
```csharp
public int Count { get; }
```
#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Implements [Count](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.Count 'System.Collections.Generic.ICollection`1.Count')  
  
<a name='TetraPak_Logging_StateDumpOptions_IsReadOnly'></a>
## StateDumpOptions.IsReadOnly Property
Gets a value indicating whether the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') is read-only.
```csharp
public bool IsReadOnly { get; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Implements [IsReadOnly](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.IsReadOnly 'System.Collections.Generic.ICollection`1.IsReadOnly')  
  
<a name='TetraPak_Logging_StateDumpOptions_Keys'></a>
## StateDumpOptions.Keys Property
Gets an [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') containing the keys of the [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2').
```csharp
public System.Collections.Generic.ICollection<string> Keys { get; }
```
#### Property Value
[System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')

Implements [Keys](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.Keys 'System.Collections.Generic.IDictionary`2.Keys')  
  
<a name='TetraPak_Logging_StateDumpOptions_Values'></a>
## StateDumpOptions.Values Property
Gets an [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') containing the values in the [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2').
```csharp
public System.Collections.Generic.ICollection<bool> Values { get; }
```
#### Property Value
[System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')

Implements [Values](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.Values 'System.Collections.Generic.IDictionary`2.Values')  
  
### Methods
<a name='TetraPak_Logging_StateDumpOptions_Clear()'></a>
## StateDumpOptions.Clear() Method
Removes all items from the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').
```csharp
public void Clear();
```
#### Exceptions
[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
The [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') is read-only.

Implements [Clear()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.Clear 'System.Collections.Generic.ICollection`1.Clear')  
  
<a name='TetraPak_Logging_StateDumpOptions_GetEnumerator()'></a>
## StateDumpOptions.GetEnumerator() Method
Returns an enumerator that iterates through the collection.
```csharp
public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string,bool>> GetEnumerator();
```
#### Returns
[System.Collections.Generic.IEnumerator&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')  
An enumerator that can be used to iterate through the collection.

Implements [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1.GetEnumerator 'System.Collections.Generic.IEnumerable`1.GetEnumerator'), [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable.GetEnumerator 'System.Collections.IEnumerable.GetEnumerator')  
  
<a name='TetraPak_Logging_StateDumpOptions_IsOverridden(string)'></a>
## StateDumpOptions.IsOverridden(string) Method
Returns a value indicating whether a specified option is overridden.  
```csharp
public bool IsOverridden(string option);
```
#### Parameters
<a name='TetraPak_Logging_StateDumpOptions_IsOverridden(string)_option'></a>
`option` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the option.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if [option](TetraPak_Logging_StateDumpOptions.md#TetraPak_Logging_StateDumpOptions_IsOverridden(string)_option 'TetraPak.Logging.StateDumpOptions.IsOverridden(string).option') was overridden; otherwise `false`.  
            
  
<a name='TetraPak_Logging_StateDumpOptions_TryGetOverridden(string_string_)'></a>
## StateDumpOptions.TryGetOverridden(string, string?) Method
Returns a value indicating whether a specified option is overridden.  
Also passes the overridden value when assigned.   
```csharp
public bool TryGetOverridden(string option, out string? value);
```
#### Parameters
<a name='TetraPak_Logging_StateDumpOptions_TryGetOverridden(string_string_)_option'></a>
`option` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the option.  
  
<a name='TetraPak_Logging_StateDumpOptions_TryGetOverridden(string_string_)_value'></a>
`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The overridden value, when assigned; otherwise `null`.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if [option](TetraPak_Logging_StateDumpOptions.md#TetraPak_Logging_StateDumpOptions_TryGetOverridden(string_string_)_option 'TetraPak.Logging.StateDumpOptions.TryGetOverridden(string, string?).option') was overridden; otherwise `false`.  
            
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
The [option](TetraPak_Logging_StateDumpOptions.md#TetraPak_Logging_StateDumpOptions_TryGetOverridden(string_string_)_option 'TetraPak.Logging.StateDumpOptions.TryGetOverridden(string, string?).option') was unassigned or blank.  
#### See Also
- [WithOverride(string, string?, bool)](TetraPak_Logging_StateDumpOptions.md#TetraPak_Logging_StateDumpOptions_WithOverride(string_string__bool) 'TetraPak.Logging.StateDumpOptions.WithOverride(string, string?, bool)')
  
<a name='TetraPak_Logging_StateDumpOptions_WithIgnored(string__)'></a>
## StateDumpOptions.WithIgnored(string[]) Method
Ensures one or more values do not get dumped.  
This might be for security reasons or to reduce the amount of state, improving clarity.   
```csharp
public TetraPak.Logging.StateDumpOptions WithIgnored(params string[] ignoredOptions);
```
#### Parameters
<a name='TetraPak_Logging_StateDumpOptions_WithIgnored(string__)_ignoredOptions'></a>
`ignoredOptions` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Identifies one or more options to be ignored.   
  
#### Returns
[StateDumpOptions](TetraPak_Logging_StateDumpOptions.md 'TetraPak.Logging.StateDumpOptions')  
This [StateDumpOptions](TetraPak_Logging_StateDumpOptions.md 'TetraPak.Logging.StateDumpOptions') object.  
  
<a name='TetraPak_Logging_StateDumpOptions_WithOverride(string_string__bool)'></a>
## StateDumpOptions.WithOverride(string, string?, bool) Method
Overrides the value of a specified dumped option's state.  
```csharp
public TetraPak.Logging.StateDumpOptions WithOverride(string option, string? value, bool soft=true);
```
#### Parameters
<a name='TetraPak_Logging_StateDumpOptions_WithOverride(string_string__bool)_option'></a>
`option` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the option to override.  
  
<a name='TetraPak_Logging_StateDumpOptions_WithOverride(string_string__bool)_value'></a>
`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A value to be dumped.  
  
<a name='TetraPak_Logging_StateDumpOptions_WithOverride(string_string__bool)_soft'></a>
`soft` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
(optional; default=`true`)<br/>  
Specifies whether to only override the value if it is set (scheduled to be dumped) and  
the overridden value is itself an assigned string (not `null`).  
If `false`, a "hard override" will take place and the value will be dumped  
(with the overriden value) either way.  
  
#### Returns
[StateDumpOptions](TetraPak_Logging_StateDumpOptions.md 'TetraPak.Logging.StateDumpOptions')  
This [StateDumpOptions](TetraPak_Logging_StateDumpOptions.md 'TetraPak.Logging.StateDumpOptions') object.  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
The [option](TetraPak_Logging_StateDumpOptions.md#TetraPak_Logging_StateDumpOptions_WithOverride(string_string__bool)_option 'TetraPak.Logging.StateDumpOptions.WithOverride(string, string?, bool).option') was unassigned or blank.  
#### See Also
- [TryGetOverridden(string, string?)](TetraPak_Logging_StateDumpOptions.md#TetraPak_Logging_StateDumpOptions_TryGetOverridden(string_string_) 'TetraPak.Logging.StateDumpOptions.TryGetOverridden(string, string?)')
  
<a name='TetraPak_Logging_StateDumpOptions_WithTargetLogger(Microsoft_Extensions_Logging_ILogger)'></a>
## StateDumpOptions.WithTargetLogger(ILogger) Method
Specifies that restricted values (that will normally be dumped as redacted values) can be  
disclosed for specified logger if that logger is declaring a [Microsoft.Extensions.Logging.LogLevel](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.LogLevel 'Microsoft.Extensions.Logging.LogLevel') that  
matches the restricted value's decorated [DisclosureLogLevels](TetraPak_RestrictedValueAttribute.md#TetraPak_RestrictedValueAttribute_DisclosureLogLevels 'TetraPak.RestrictedValueAttribute.DisclosureLogLevels').   
```csharp
public TetraPak.Logging.StateDumpOptions WithTargetLogger(Microsoft.Extensions.Logging.ILogger logger);
```
#### Parameters
<a name='TetraPak_Logging_StateDumpOptions_WithTargetLogger(Microsoft_Extensions_Logging_ILogger)_logger'></a>
`logger` [Microsoft.Extensions.Logging.ILogger](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger 'Microsoft.Extensions.Logging.ILogger')  
A targeted logger provider.  
  
#### Returns
[StateDumpOptions](TetraPak_Logging_StateDumpOptions.md 'TetraPak.Logging.StateDumpOptions')  
This object (fluent API).  
  
