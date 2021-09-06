#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching').[SimpleCache](TetraPak_Caching_SimpleCache.md 'TetraPak.Caching.SimpleCache')
## SimpleCache.DeleteAsync(string, string) Method
Removes a time limited value.  
```csharp
public virtual System.Threading.Tasks.Task DeleteAsync(string repository, string key);
```
#### Parameters
<a name='TetraPak_Caching_SimpleCache_DeleteAsync(string_string)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository to remove the value from.  
  
<a name='TetraPak_Caching_SimpleCache_DeleteAsync(string_string)_key'></a>
`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Value's unique identifier.  
  
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
#### Exceptions
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
The [key](TetraPak_Caching_SimpleCache_DeleteAsync(string_string).md#TetraPak_Caching_SimpleCache_DeleteAsync(string_string)_key 'TetraPak.Caching.SimpleCache.DeleteAsync(string, string).key') was not recognized.  

Implements [DeleteAsync(string, string)](TetraPak_Caching_ITimeLimitedRepositories_DeleteAsync(string_string).md 'TetraPak.Caching.ITimeLimitedRepositories.DeleteAsync(string, string)')  
