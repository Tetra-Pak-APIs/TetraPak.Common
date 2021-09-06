#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching')
## SimpleTimeLimitedRepositoryOptions Class
Represents configuration for a named cache repository.  
```csharp
public class SimpleTimeLimitedRepositoryOptions : TetraPak.Configuration.ConfigurationSection,
TetraPak.Caching.ITimeLimitedRepositoryOptions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [ConfigurationSection](TetraPak_Configuration_ConfigurationSection.md 'TetraPak.Configuration.ConfigurationSection') &#129106; SimpleTimeLimitedRepositoryOptions  

Implements [ITimeLimitedRepositoryOptions](TetraPak_Caching_ITimeLimitedRepositoryOptions.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions')  

| Properties | |
| :--- | :--- |
| [AdjustedLifeSpan](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_AdjustedLifeSpan.md 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions.AdjustedLifeSpan') | Gets or sets a value that always adjusts the [LifeSpan](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_LifeSpan.md 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions.LifeSpan')<br/>(and [ExtendedLifeSpan](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_ExtendedLifeSpan.md 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions.ExtendedLifeSpan') when applicable).<br/>This value can be used to always increase or decrease the lifespan values.<br/> |
| [ExtendedLifeSpan](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_ExtendedLifeSpan.md 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions.ExtendedLifeSpan') | Gets or sets a value specifying a lifespan to be re-applied to a value as it is being<br/>read from the cache.<br/> |
| [LifeSpan](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_LifeSpan.md 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions.LifeSpan') | Gets or sets the life span for entries of the configured cache repository.<br/> |
| [MaxLifeSpan](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_MaxLifeSpan.md 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions.MaxLifeSpan') | Gets or sets a value specifying the maximum total lifespan allowed for any cached value<br/>within a specific repository. Setting this to anything other than zero will limit the<br/>total lifespan of cached values to unlimited lifespan due to dynamic lifespan extension<br/>when reading/updating values (see [ExtendedLifeSpan](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_ExtendedLifeSpan.md 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions.ExtendedLifeSpan')).<br/> |
| [Zero](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_Zero.md 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions.Zero') | Returns a configuration with all values initialized to [System.TimeSpan.Zero](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan.Zero 'System.TimeSpan.Zero').<br/> |

| Methods | |
| :--- | :--- |
| [MergeFrom(ITimeLimitedRepositoryOptions)](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_MergeFrom(TetraPak_Caching_ITimeLimitedRepositoryOptions).md 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions.MergeFrom(TetraPak.Caching.ITimeLimitedRepositoryOptions)') | Merges options with other options.<br/> |
| [SetCache(SimpleCache)](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_SetCache(TetraPak_Caching_SimpleCache).md 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions.SetCache(TetraPak.Caching.SimpleCache)') | Simply sets the internal reference to the parent [SimpleCache](TetraPak_Caching_SimpleCache.md 'TetraPak.Caching.SimpleCache') instance.<br/> |
#### See Also
- [SimpleCache](TetraPak_Caching_SimpleCache.md 'TetraPak.Caching.SimpleCache')
- [SimpleCacheConfig](TetraPak_Caching_SimpleCacheConfig.md 'TetraPak.Caching.SimpleCacheConfig')
