#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching').[SimpleTimeLimitedRepositoryOptions](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions.md 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions')
## SimpleTimeLimitedRepositoryOptions.MergeFrom(ITimeLimitedRepositoryOptions) Method
Merges options with other options.  
```csharp
public void MergeFrom(TetraPak.Caching.ITimeLimitedRepositoryOptions options);
```
#### Parameters
<a name='TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_MergeFrom(TetraPak_Caching_ITimeLimitedRepositoryOptions)_options'></a>
`options` [ITimeLimitedRepositoryOptions](TetraPak_Caching_ITimeLimitedRepositoryOptions.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions')  
  
### Remarks
If [options](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_MergeFrom(TetraPak_Caching_ITimeLimitedRepositoryOptions).md#TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_MergeFrom(TetraPak_Caching_ITimeLimitedRepositoryOptions)_options 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions.MergeFrom(TetraPak.Caching.ITimeLimitedRepositoryOptions).options') is a [ConfigurationSection](TetraPak_Configuration_ConfigurationSection.md 'TetraPak.Configuration.ConfigurationSection') only values  
that are assigned to property backing fields will be merged.  
