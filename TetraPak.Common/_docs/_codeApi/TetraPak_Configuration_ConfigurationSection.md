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

| Constructors | |
| :--- | :--- |
| [ConfigurationSection(IConfiguration?, ILogger?, ConfigPath?)](TetraPak_Configuration_ConfigurationSection_ConfigurationSection(Microsoft_Extensions_Configuration_IConfiguration__Microsoft_Extensions_Logging_ILogger__TetraPak_Configuration_ConfigPath_).md 'TetraPak.Configuration.ConfigurationSection.ConfigurationSection(Microsoft.Extensions.Configuration.IConfiguration?, Microsoft.Extensions.Logging.ILogger?, TetraPak.Configuration.ConfigPath?)') | Instantiates a [ConfigurationSection](TetraPak_Configuration_ConfigurationSection.md 'TetraPak.Configuration.ConfigurationSection').<br/> |

| Properties | |
| :--- | :--- |
| [IsEmpty](TetraPak_Configuration_ConfigurationSection_IsEmpty.md 'TetraPak.Configuration.ConfigurationSection.IsEmpty') | Gets a value that indicates whether the configuration section contains no information. <br/> |
| [Logger](TetraPak_Configuration_ConfigurationSection_Logger.md 'TetraPak.Configuration.ConfigurationSection.Logger') | Gets a logger.<br/> |
| [ParentConfiguration](TetraPak_Configuration_ConfigurationSection_ParentConfiguration.md 'TetraPak.Configuration.ConfigurationSection.ParentConfiguration') | Gets the parent [Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') section<br/>(or `null` if this section is also the configuration root).<br/> |
| [Section](TetraPak_Configuration_ConfigurationSection_Section.md 'TetraPak.Configuration.ConfigurationSection.Section') | Gets the encapsulated [Microsoft.Extensions.Configuration.IConfigurationSection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfigurationSection 'Microsoft.Extensions.Configuration.IConfigurationSection').  <br/> |
| [SectionIdentifier](TetraPak_Configuration_ConfigurationSection_SectionIdentifier.md 'TetraPak.Configuration.ConfigurationSection.SectionIdentifier') | Can be overridden. Returns the expected configuration section identifier like in this example:<br/> |

| Methods | |
| :--- | :--- |
| [GetFromFieldThenSection&lt;T&gt;(T?, ValueParser&lt;T&gt;?, string)](TetraPak_Configuration_ConfigurationSection_GetFromFieldThenSection_T_(T__TetraPak_Configuration_ValueParser_T___string).md 'TetraPak.Configuration.ConfigurationSection.GetFromFieldThenSection&lt;T&gt;(T?, TetraPak.Configuration.ValueParser&lt;T&gt;?, string)') | Reads a value from field-behind (name convention based on property). If the field is null<br/>the value is read from the configuration section and. If the configuration section also<br/>doesn't supported the value the method returns the [useDefault](TetraPak_Configuration_ConfigurationSection_GetFromFieldThenSection_T_(T__TetraPak_Configuration_ValueParser_T___string).md#TetraPak_Configuration_ConfigurationSection_GetFromFieldThenSection_T_(T__TetraPak_Configuration_ValueParser_T___string)_useDefault 'TetraPak.Configuration.ConfigurationSection.GetFromFieldThenSection&lt;T&gt;(T?, TetraPak.Configuration.ValueParser&lt;T&gt;?, string).useDefault') value. <br/> |
| [OnGetField(string)](TetraPak_Configuration_ConfigurationSection_OnGetField(string).md 'TetraPak.Configuration.ConfigurationSection.OnGetField(string)') | Obtains a [System.Reflection.FieldInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.FieldInfo 'System.Reflection.FieldInfo') object for a specified field.<br/> |
