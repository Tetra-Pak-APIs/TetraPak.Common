#### [TetraPak.Common](index.md 'index')
### [TetraPak.Configuration](TetraPak_Configuration.md 'TetraPak.Configuration').[ConfigurationSection](TetraPak_Configuration_ConfigurationSection.md 'TetraPak.Configuration.ConfigurationSection')
## ConfigurationSection.ConfigurationSection(IConfiguration?, ILogger?, ConfigPath?) Constructor
Instantiates a [ConfigurationSection](TetraPak_Configuration_ConfigurationSection.md 'TetraPak.Configuration.ConfigurationSection').  
```csharp
public ConfigurationSection(Microsoft.Extensions.Configuration.IConfiguration? configuration, Microsoft.Extensions.Logging.ILogger? logger, TetraPak.Configuration.ConfigPath? sectionIdentifier=null);
```
#### Parameters
<a name='TetraPak_Configuration_ConfigurationSection_ConfigurationSection(Microsoft_Extensions_Configuration_IConfiguration__Microsoft_Extensions_Logging_ILogger__TetraPak_Configuration_ConfigPath_)_configuration'></a>
`configuration` [Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration')  
The [Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') instance that contains the configuration section to be encapsulated.  
  
<a name='TetraPak_Configuration_ConfigurationSection_ConfigurationSection(Microsoft_Extensions_Configuration_IConfiguration__Microsoft_Extensions_Logging_ILogger__TetraPak_Configuration_ConfigPath_)_logger'></a>
`logger` [Microsoft.Extensions.Logging.ILogger](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger 'Microsoft.Extensions.Logging.ILogger')  
Initializes the [Logger](TetraPak_Configuration_ConfigurationSection_Logger.md 'TetraPak.Configuration.ConfigurationSection.Logger') value.  
  
<a name='TetraPak_Configuration_ConfigurationSection_ConfigurationSection(Microsoft_Extensions_Configuration_IConfiguration__Microsoft_Extensions_Logging_ILogger__TetraPak_Configuration_ConfigPath_)_sectionIdentifier'></a>
`sectionIdentifier` [TetraPak.Configuration.ConfigPath](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Configuration.ConfigPath 'TetraPak.Configuration.ConfigPath')  
(optional; default=value from [SectionIdentifier](TetraPak_Configuration_ConfigurationSection_SectionIdentifier.md 'TetraPak.Configuration.ConfigurationSection.SectionIdentifier'))<br/>  
Specifies the configuration section to be encapsulated.   
  
