#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching').[ITimeLimitedRepositoryOptions](TetraPak_Caching_ITimeLimitedRepositoryOptions.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions')
## ITimeLimitedRepositoryOptions.AdjustedLifeSpan Property
Gets a value that reduces the [LifeSpan](TetraPak_Caching_ITimeLimitedRepositoryOptions_LifeSpan.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions.LifeSpan') (and [ExtendedLifeSpan](TetraPak_Caching_ITimeLimitedRepositoryOptions_ExtendedLifeSpan.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions.ExtendedLifeSpan') when applicable).  
Use this value to create a "safe zone" for values that have themselves a limited lifetime  
(outside of the repository, such as access tokens), and that might expire within this time span.   
```csharp
System.TimeSpan AdjustedLifeSpan { get; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')
