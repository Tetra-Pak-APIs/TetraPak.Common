#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching').[SimpleCache](TetraPak_Caching_SimpleCache.md 'TetraPak.Caching.SimpleCache')
## SimpleCache.GetAdjustedLifeSpan(string) Method
Gets the reduced lifespan configured for a specified repository.  
The reduced lifespan is applied every time a cached entity is read or updated.    
```csharp
public System.TimeSpan GetAdjustedLifeSpan(string repository);
```
#### Parameters
<a name='TetraPak_Caching_SimpleCache_GetAdjustedLifeSpan(string)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository.      
  
#### Returns
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')  
A [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') value.  

Implements [GetAdjustedLifeSpan(string)](TetraPak_Caching_ITimeLimitedRepositories_GetAdjustedLifeSpan(string).md 'TetraPak.Caching.ITimeLimitedRepositories.GetAdjustedLifeSpan(string)')  
