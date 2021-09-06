#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching').[SimpleCache](TetraPak_Caching_SimpleCache.md 'TetraPak.Caching.SimpleCache')
## SimpleCache.GetExtendedLifeSpan(string) Method
Gets the extended lifespan configured for a specified repository.  
The extended lifespan is applied every time a cached entity is read or updated.    
```csharp
public System.TimeSpan GetExtendedLifeSpan(string repository);
```
#### Parameters
<a name='TetraPak_Caching_SimpleCache_GetExtendedLifeSpan(string)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository.      
  
#### Returns
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')  
A [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') value.  

Implements [GetExtendedLifeSpan(string)](TetraPak_Caching_ITimeLimitedRepositories_GetExtendedLifeSpan(string).md 'TetraPak.Caching.ITimeLimitedRepositories.GetExtendedLifeSpan(string)')  
