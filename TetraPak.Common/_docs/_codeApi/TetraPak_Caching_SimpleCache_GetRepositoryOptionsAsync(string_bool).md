#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching').[SimpleCache](TetraPak_Caching_SimpleCache.md 'TetraPak.Caching.SimpleCache')
## SimpleCache.GetRepositoryOptionsAsync(string, bool) Method
Obtains the configuration for a specified repository.  
```csharp
public System.Threading.Tasks.Task<TetraPak.Caching.ITimeLimitedRepositoryOptions> GetRepositoryOptionsAsync(string repository, bool useDefault=true);
```
#### Parameters
<a name='TetraPak_Caching_SimpleCache_GetRepositoryOptionsAsync(string_bool)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository.  
  
<a name='TetraPak_Caching_SimpleCache_GetRepositoryOptionsAsync(string_bool)_useDefault'></a>
`useDefault` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Specifies whether to return default options when none could be found.  
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[ITimeLimitedRepositoryOptions](TetraPak_Caching_ITimeLimitedRepositoryOptions.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A [ITimeLimitedRepositoryOptions](TetraPak_Caching_ITimeLimitedRepositoryOptions.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions') instance.  

Implements [GetRepositoryOptionsAsync(string, bool)](TetraPak_Caching_ITimeLimitedRepositories_GetRepositoryOptionsAsync(string_bool).md 'TetraPak.Caching.ITimeLimitedRepositories.GetRepositoryOptionsAsync(string, bool)')  
