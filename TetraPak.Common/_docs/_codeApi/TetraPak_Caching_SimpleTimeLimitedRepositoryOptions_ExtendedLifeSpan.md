#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching').[SimpleTimeLimitedRepositoryOptions](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions.md 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions')
## SimpleTimeLimitedRepositoryOptions.ExtendedLifeSpan Property
Gets or sets a value specifying a lifespan to be re-applied to a value as it is being  
read from the cache.  
```csharp
public System.TimeSpan ExtendedLifeSpan { get; set; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')

Implements [ExtendedLifeSpan](TetraPak_Caching_ITimeLimitedRepositoryOptions_ExtendedLifeSpan.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions.ExtendedLifeSpan')  
### Remarks
Set this value to an asterisk (*) to always renew by same value as [LifeSpan](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_LifeSpan.md 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions.LifeSpan').  
