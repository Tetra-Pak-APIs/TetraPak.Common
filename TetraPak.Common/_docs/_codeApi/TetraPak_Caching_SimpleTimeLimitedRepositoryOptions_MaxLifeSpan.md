#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching').[SimpleTimeLimitedRepositoryOptions](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions.md 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions')
## SimpleTimeLimitedRepositoryOptions.MaxLifeSpan Property
Gets or sets a value specifying the maximum total lifespan allowed for any cached value  
within a specific repository. Setting this to anything other than zero will limit the  
total lifespan of cached values to unlimited lifespan due to dynamic lifespan extension  
when reading/updating values (see [ExtendedLifeSpan](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_ExtendedLifeSpan.md 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions.ExtendedLifeSpan')).  
```csharp
public System.TimeSpan MaxLifeSpan { get; set; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')

Implements [MaxLifeSpan](TetraPak_Caching_ITimeLimitedRepositoryOptions_MaxLifeSpan.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions.MaxLifeSpan')  
