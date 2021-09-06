#### [TetraPak.Common](index.md 'index')
### [TetraPak.Configuration](TetraPak_Configuration.md 'TetraPak.Configuration').[ConfigurationSection](TetraPak_Configuration_ConfigurationSection.md 'TetraPak.Configuration.ConfigurationSection')
## ConfigurationSection.SectionIdentifier Property
Can be overridden. Returns the expected configuration section identifier like in this example:<br/>```csharp

"MySection": {
  :
}
```
```csharp
public virtual string SectionIdentifier { get; set; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
