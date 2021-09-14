#### [TetraPak.Common](index.md 'index')
### [TetraPak.Configuration](TetraPak_Configuration.md 'TetraPak.Configuration')
## ConfigurationSection Class
Provides access to the configuration framework through a POCO class.   
```csharp
public abstract class ConfigurationSection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ConfigurationSection  

Derived  
&#8627; [SimpleCacheConfig](TetraPak_Caching_SimpleCacheConfig.md 'TetraPak.Caching.SimpleCacheConfig')  
&#8627; [SimpleTimeLimitedRepositoryOptions](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions.md 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions')  
### Constructors
<a name='TetraPak_Configuration_ConfigurationSection_ConfigurationSection(Microsoft_Extensions_Configuration_IConfiguration__Microsoft_Extensions_Logging_ILogger__TetraPak_Configuration_ConfigPath_)'></a>
## ConfigurationSection.ConfigurationSection(IConfiguration?, ILogger?, ConfigPath?) Constructor
Instantiates a [ConfigurationSection](TetraPak_Configuration_ConfigurationSection.md 'TetraPak.Configuration.ConfigurationSection').  
```csharp
public ConfigurationSection(Microsoft.Extensions.Configuration.IConfiguration? configuration, Microsoft.Extensions.Logging.ILogger? logger, TetraPak.Configuration.ConfigPath? configPath=null);
```
#### Parameters
<a name='TetraPak_Configuration_ConfigurationSection_ConfigurationSection(Microsoft_Extensions_Configuration_IConfiguration__Microsoft_Extensions_Logging_ILogger__TetraPak_Configuration_ConfigPath_)_configuration'></a>
`configuration` [Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration')  
The [Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') instance that contains the configuration section to be encapsulated.  
  
<a name='TetraPak_Configuration_ConfigurationSection_ConfigurationSection(Microsoft_Extensions_Configuration_IConfiguration__Microsoft_Extensions_Logging_ILogger__TetraPak_Configuration_ConfigPath_)_logger'></a>
`logger` [Microsoft.Extensions.Logging.ILogger](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger 'Microsoft.Extensions.Logging.ILogger')  
Initializes the [Logger](TetraPak_Configuration_ConfigurationSection.md#TetraPak_Configuration_ConfigurationSection_Logger 'TetraPak.Configuration.ConfigurationSection.Logger') value.  
  
<a name='TetraPak_Configuration_ConfigurationSection_ConfigurationSection(Microsoft_Extensions_Configuration_IConfiguration__Microsoft_Extensions_Logging_ILogger__TetraPak_Configuration_ConfigPath_)_configPath'></a>
`configPath` [TetraPak.Configuration.ConfigPath](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Configuration.ConfigPath 'TetraPak.Configuration.ConfigPath')  
(optional; default=value from [SectionIdentifier](TetraPak_Configuration_ConfigurationSection.md#TetraPak_Configuration_ConfigurationSection_SectionIdentifier 'TetraPak.Configuration.ConfigurationSection.SectionIdentifier'))<br/>  
Specifies the configuration section to be encapsulated.   
  
  
### Properties
<a name='TetraPak_Configuration_ConfigurationSection_IsEmpty'></a>
## ConfigurationSection.IsEmpty Property
Gets a value that indicates whether the configuration section contains no information.   
```csharp
public bool IsEmpty { get; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
  
<a name='TetraPak_Configuration_ConfigurationSection_Logger'></a>
## ConfigurationSection.Logger Property
Gets a logger.  
```csharp
public Microsoft.Extensions.Logging.ILogger? Logger { get; }
```
#### Property Value
[Microsoft.Extensions.Logging.ILogger](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger 'Microsoft.Extensions.Logging.ILogger')
  
<a name='TetraPak_Configuration_ConfigurationSection_ParentConfiguration'></a>
## ConfigurationSection.ParentConfiguration Property
Gets the parent [Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') section  
(or `null` if this section is also the configuration root).  
```csharp
public Microsoft.Extensions.Configuration.IConfiguration? ParentConfiguration { get; }
```
#### Property Value
[Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration')
  
<a name='TetraPak_Configuration_ConfigurationSection_Section'></a>
## ConfigurationSection.Section Property
Gets the encapsulated [Microsoft.Extensions.Configuration.IConfigurationSection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfigurationSection 'Microsoft.Extensions.Configuration.IConfigurationSection').    
```csharp
public Microsoft.Extensions.Configuration.IConfigurationSection? Section { get; set; }
```
#### Property Value
[Microsoft.Extensions.Configuration.IConfigurationSection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfigurationSection 'Microsoft.Extensions.Configuration.IConfigurationSection')
  
<a name='TetraPak_Configuration_ConfigurationSection_SectionIdentifier'></a>
## ConfigurationSection.SectionIdentifier Property
Can be overridden. Returns the expected configuration section identifier like in this example:<br/>```csharp

"MySection": {
  :
}
```
```csharp
public string SectionIdentifier { get; set; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
  
### Methods
<a name='TetraPak_Configuration_ConfigurationSection_GetFromFieldThenSection_T_(T__TetraPak_Configuration_ValueParser_T___string)'></a>
## ConfigurationSection.GetFromFieldThenSection&lt;T&gt;(T?, ValueParser&lt;T&gt;?, string) Method
Reads a value from field-behind (name convention based on property). If the field is null  
the value is read from the configuration section and. If the configuration section also  
doesn't supported the value the method returns the [useDefault](TetraPak_Configuration_ConfigurationSection.md#TetraPak_Configuration_ConfigurationSection_GetFromFieldThenSection_T_(T__TetraPak_Configuration_ValueParser_T___string)_useDefault 'TetraPak.Configuration.ConfigurationSection.GetFromFieldThenSection&lt;T&gt;(T?, TetraPak.Configuration.ValueParser&lt;T&gt;?, string).useDefault') value.   
```csharp
protected T? GetFromFieldThenSection<T>(T? useDefault=default(T?), TetraPak.Configuration.ValueParser<T>? parser=null, string propertyName=null);
```
#### Type parameters
<a name='TetraPak_Configuration_ConfigurationSection_GetFromFieldThenSection_T_(T__TetraPak_Configuration_ValueParser_T___string)_T'></a>
`T`  
  
#### Parameters
<a name='TetraPak_Configuration_ConfigurationSection_GetFromFieldThenSection_T_(T__TetraPak_Configuration_ValueParser_T___string)_useDefault'></a>
`useDefault` [T](TetraPak_Configuration_ConfigurationSection.md#TetraPak_Configuration_ConfigurationSection_GetFromFieldThenSection_T_(T__TetraPak_Configuration_ValueParser_T___string)_T 'TetraPak.Configuration.ConfigurationSection.GetFromFieldThenSection&lt;T&gt;(T?, TetraPak.Configuration.ValueParser&lt;T&gt;?, string).T')  
  
<a name='TetraPak_Configuration_ConfigurationSection_GetFromFieldThenSection_T_(T__TetraPak_Configuration_ValueParser_T___string)_parser'></a>
`parser` [TetraPak.Configuration.ValueParser&lt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Configuration.ValueParser-1 'TetraPak.Configuration.ValueParser`1')[T](TetraPak_Configuration_ConfigurationSection.md#TetraPak_Configuration_ConfigurationSection_GetFromFieldThenSection_T_(T__TetraPak_Configuration_ValueParser_T___string)_T 'TetraPak.Configuration.ConfigurationSection.GetFromFieldThenSection&lt;T&gt;(T?, TetraPak.Configuration.ValueParser&lt;T&gt;?, string).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Configuration.ValueParser-1 'TetraPak.Configuration.ValueParser`1')  
  
<a name='TetraPak_Configuration_ConfigurationSection_GetFromFieldThenSection_T_(T__TetraPak_Configuration_ValueParser_T___string)_propertyName'></a>
`propertyName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
#### Returns
[T](TetraPak_Configuration_ConfigurationSection.md#TetraPak_Configuration_ConfigurationSection_GetFromFieldThenSection_T_(T__TetraPak_Configuration_ValueParser_T___string)_T 'TetraPak.Configuration.ConfigurationSection.GetFromFieldThenSection&lt;T&gt;(T?, TetraPak.Configuration.ValueParser&lt;T&gt;?, string).T')  
  
<a name='TetraPak_Configuration_ConfigurationSection_OnGetField(string)'></a>
## ConfigurationSection.OnGetField(string) Method
Obtains a [System.Reflection.FieldInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.FieldInfo 'System.Reflection.FieldInfo') object for a specified field.  
```csharp
protected virtual System.Reflection.FieldInfo? OnGetField(string fieldName);
```
#### Parameters
<a name='TetraPak_Configuration_ConfigurationSection_OnGetField(string)_fieldName'></a>
`fieldName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the requested field.  
  
#### Returns
[System.Reflection.FieldInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.FieldInfo 'System.Reflection.FieldInfo')  
A [System.Reflection.FieldInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.FieldInfo 'System.Reflection.FieldInfo') object.  
  
