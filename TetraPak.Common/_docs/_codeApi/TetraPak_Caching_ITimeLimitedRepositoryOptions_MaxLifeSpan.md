#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching').[ITimeLimitedRepositoryOptions](TetraPak_Caching_ITimeLimitedRepositoryOptions.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions')
## ITimeLimitedRepositoryOptions.MaxLifeSpan Property
Gets the maximum total lifespan allowed for any cached value  
within a cache repository. Setting this to anything other than zero will limit the  
total lifespan of cached values to unlimited lifespan due to dynamic lifespan extension  
when reading/updating values (see [ExtendedLifeSpan](TetraPak_Caching_ITimeLimitedRepositoryOptions_ExtendedLifeSpan.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions.ExtendedLifeSpan')).  
```csharp
System.TimeSpan MaxLifeSpan { get; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')
