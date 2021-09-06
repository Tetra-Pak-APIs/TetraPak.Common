#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching').[SimpleCache](TetraPak_Caching_SimpleCache.md 'TetraPak.Caching.SimpleCache')
## SimpleCache.DefaultMaxLifeSpan Property
Gets a default maximum lifespan for repository values.  
The maximum lifespan can never be exceeded by dynamically extending cached entries' lifespan.    
```csharp
public System.TimeSpan DefaultMaxLifeSpan { get; set; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')

Implements [DefaultMaxLifeSpan](TetraPak_Caching_ITimeLimitedRepositories_DefaultMaxLifeSpan.md 'TetraPak.Caching.ITimeLimitedRepositories.DefaultMaxLifeSpan')  
#### See Also
- [DefaultLifeSpan](TetraPak_Caching_ITimeLimitedRepositories_DefaultLifeSpan.md 'TetraPak.Caching.ITimeLimitedRepositories.DefaultLifeSpan')
- [DefaultExtendedLifeSpan](TetraPak_Caching_ITimeLimitedRepositories_DefaultExtendedLifeSpan.md 'TetraPak.Caching.ITimeLimitedRepositories.DefaultExtendedLifeSpan')
- [DefaultAdjustedLifeSpan](TetraPak_Caching_ITimeLimitedRepositories_DefaultAdjustedLifeSpan.md 'TetraPak.Caching.ITimeLimitedRepositories.DefaultAdjustedLifeSpan')
