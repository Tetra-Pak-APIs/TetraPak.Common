#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching').[SimpleCache](TetraPak_Caching_SimpleCache.md 'TetraPak.Caching.SimpleCache')
## SimpleCache.DefaultExtendedLifeSpan Property
Gets a default extended lifespan for repository values. The extended lifespan  
is applied to entities as they are read or updated.  
```csharp
public System.TimeSpan DefaultExtendedLifeSpan { get; set; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')

Implements [DefaultExtendedLifeSpan](TetraPak_Caching_ITimeLimitedRepositories_DefaultExtendedLifeSpan.md 'TetraPak.Caching.ITimeLimitedRepositories.DefaultExtendedLifeSpan')  
### Remarks
Set this value to zero ("0" or "0:0:0") to avoid extending entries' cache lifespan.  
