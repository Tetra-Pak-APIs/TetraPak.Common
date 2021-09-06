#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching')
## ITimeLimitedRepositoryOptions Interface
Implementors of this class can represent options for an individual  
time limited repository.    
```csharp
public interface ITimeLimitedRepositoryOptions
```

Derived  
&#8627; [SimpleTimeLimitedRepositoryOptions](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions.md 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions')  

| Properties | |
| :--- | :--- |
| [AdjustedLifeSpan](TetraPak_Caching_ITimeLimitedRepositoryOptions_AdjustedLifeSpan.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions.AdjustedLifeSpan') | Gets a value that reduces the [LifeSpan](TetraPak_Caching_ITimeLimitedRepositoryOptions_LifeSpan.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions.LifeSpan') (and [ExtendedLifeSpan](TetraPak_Caching_ITimeLimitedRepositoryOptions_ExtendedLifeSpan.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions.ExtendedLifeSpan') when applicable).<br/>Use this value to create a "safe zone" for values that have themselves a limited lifetime<br/>(outside of the repository, such as access tokens), and that might expire within this time span. <br/> |
| [ExtendedLifeSpan](TetraPak_Caching_ITimeLimitedRepositoryOptions_ExtendedLifeSpan.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions.ExtendedLifeSpan') | Gets a lifespan to be re-applied to a value as it is being read from the cache, extending its life span.<br/> |
| [LifeSpan](TetraPak_Caching_ITimeLimitedRepositoryOptions_LifeSpan.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions.LifeSpan') | Gets the life span for entries of the cache repository.<br/> |
| [MaxLifeSpan](TetraPak_Caching_ITimeLimitedRepositoryOptions_MaxLifeSpan.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions.MaxLifeSpan') | Gets the maximum total lifespan allowed for any cached value<br/>within a cache repository. Setting this to anything other than zero will limit the<br/>total lifespan of cached values to unlimited lifespan due to dynamic lifespan extension<br/>when reading/updating values (see [ExtendedLifeSpan](TetraPak_Caching_ITimeLimitedRepositoryOptions_ExtendedLifeSpan.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions.ExtendedLifeSpan')).<br/> |
