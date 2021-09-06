#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching').[ITimeLimitedRepositories](TetraPak_Caching_ITimeLimitedRepositories.md 'TetraPak.Caching.ITimeLimitedRepositories')
## ITimeLimitedRepositories.GetMaxLifeSpan(string) Method
Gets the maximum allowed lifespan configured for a specified repository.   
```csharp
System.TimeSpan GetMaxLifeSpan(string repository);
```
#### Parameters
<a name='TetraPak_Caching_ITimeLimitedRepositories_GetMaxLifeSpan(string)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository.      
  
#### Returns
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')  
A [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') value.  
