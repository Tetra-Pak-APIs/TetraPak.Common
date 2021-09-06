#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching').[ITimeLimitedRepositories](TetraPak_Caching_ITimeLimitedRepositories.md 'TetraPak.Caching.ITimeLimitedRepositories')
## ITimeLimitedRepositories.GetAsync&lt;T&gt;(string, string) Method
Looks up a value in a repository.  
```csharp
System.Threading.Tasks.Task<TetraPak.Outcome<T>> GetAsync<T>(string repository, string key);
```
#### Type parameters
<a name='TetraPak_Caching_ITimeLimitedRepositories_GetAsync_T_(string_string)_T'></a>
`T`  
The requested value [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type').  
  
#### Parameters
<a name='TetraPak_Caching_ITimeLimitedRepositories_GetAsync_T_(string_string)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository where the value should exist.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_GetAsync_T_(string_string)_key'></a>
`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the requested value.  
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TetraPak.Outcome&lt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Outcome-1 'TetraPak.Outcome`1')[T](TetraPak_Caching_ITimeLimitedRepositories_GetAsync_T_(string_string).md#TetraPak_Caching_ITimeLimitedRepositories_GetAsync_T_(string_string)_T 'TetraPak.Caching.ITimeLimitedRepositories.GetAsync&lt;T&gt;(string, string).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Outcome-1 'TetraPak.Outcome`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
An [TetraPak.Outcome&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Outcome-1 'TetraPak.Outcome`1') to indicate success/failure and also carry the requested value  
(or an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') on failure).  
