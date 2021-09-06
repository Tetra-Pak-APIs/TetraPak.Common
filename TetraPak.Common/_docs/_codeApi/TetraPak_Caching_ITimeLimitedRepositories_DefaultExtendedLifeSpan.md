#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching').[ITimeLimitedRepositories](TetraPak_Caching_ITimeLimitedRepositories.md 'TetraPak.Caching.ITimeLimitedRepositories')
## ITimeLimitedRepositories.DefaultExtendedLifeSpan Property
Gets a default extended lifespan for repository values. The extended lifespan  
is applied to entities as they are read or updated.  
```csharp
System.TimeSpan DefaultExtendedLifeSpan { get; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')
### Remarks
Set this value to zero ("0" or "0:0:0") to avoid extending entries' cache lifespan.  
