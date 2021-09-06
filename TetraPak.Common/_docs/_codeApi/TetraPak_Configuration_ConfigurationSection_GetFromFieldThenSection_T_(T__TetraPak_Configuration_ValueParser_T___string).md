#### [TetraPak.Common](index.md 'index')
### [TetraPak.Configuration](TetraPak_Configuration.md 'TetraPak.Configuration').[ConfigurationSection](TetraPak_Configuration_ConfigurationSection.md 'TetraPak.Configuration.ConfigurationSection')
## ConfigurationSection.GetFromFieldThenSection&lt;T&gt;(T?, ValueParser&lt;T&gt;?, string) Method
Reads a value from field-behind (name convention based on property). If the field is null  
the value is read from the configuration section and. If the configuration section also  
doesn't supported the value the method returns the [useDefault](TetraPak_Configuration_ConfigurationSection_GetFromFieldThenSection_T_(T__TetraPak_Configuration_ValueParser_T___string).md#TetraPak_Configuration_ConfigurationSection_GetFromFieldThenSection_T_(T__TetraPak_Configuration_ValueParser_T___string)_useDefault 'TetraPak.Configuration.ConfigurationSection.GetFromFieldThenSection&lt;T&gt;(T?, TetraPak.Configuration.ValueParser&lt;T&gt;?, string).useDefault') value.   
```csharp
protected T? GetFromFieldThenSection<T>(T? useDefault=default(T?), TetraPak.Configuration.ValueParser<T>? parser=null, string propertyName=null);
```
#### Type parameters
<a name='TetraPak_Configuration_ConfigurationSection_GetFromFieldThenSection_T_(T__TetraPak_Configuration_ValueParser_T___string)_T'></a>
`T`  
  
#### Parameters
<a name='TetraPak_Configuration_ConfigurationSection_GetFromFieldThenSection_T_(T__TetraPak_Configuration_ValueParser_T___string)_useDefault'></a>
`useDefault` [T](TetraPak_Configuration_ConfigurationSection_GetFromFieldThenSection_T_(T__TetraPak_Configuration_ValueParser_T___string).md#TetraPak_Configuration_ConfigurationSection_GetFromFieldThenSection_T_(T__TetraPak_Configuration_ValueParser_T___string)_T 'TetraPak.Configuration.ConfigurationSection.GetFromFieldThenSection&lt;T&gt;(T?, TetraPak.Configuration.ValueParser&lt;T&gt;?, string).T')  
  
<a name='TetraPak_Configuration_ConfigurationSection_GetFromFieldThenSection_T_(T__TetraPak_Configuration_ValueParser_T___string)_parser'></a>
`parser` [TetraPak.Configuration.ValueParser&lt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Configuration.ValueParser-1 'TetraPak.Configuration.ValueParser`1')[T](TetraPak_Configuration_ConfigurationSection_GetFromFieldThenSection_T_(T__TetraPak_Configuration_ValueParser_T___string).md#TetraPak_Configuration_ConfigurationSection_GetFromFieldThenSection_T_(T__TetraPak_Configuration_ValueParser_T___string)_T 'TetraPak.Configuration.ConfigurationSection.GetFromFieldThenSection&lt;T&gt;(T?, TetraPak.Configuration.ValueParser&lt;T&gt;?, string).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Configuration.ValueParser-1 'TetraPak.Configuration.ValueParser`1')  
  
<a name='TetraPak_Configuration_ConfigurationSection_GetFromFieldThenSection_T_(T__TetraPak_Configuration_ValueParser_T___string)_propertyName'></a>
`propertyName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
#### Returns
[T](TetraPak_Configuration_ConfigurationSection_GetFromFieldThenSection_T_(T__TetraPak_Configuration_ValueParser_T___string).md#TetraPak_Configuration_ConfigurationSection_GetFromFieldThenSection_T_(T__TetraPak_Configuration_ValueParser_T___string)_T 'TetraPak.Configuration.ConfigurationSection.GetFromFieldThenSection&lt;T&gt;(T?, TetraPak.Configuration.ValueParser&lt;T&gt;?, string).T')  
