#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching').[SimpleCache](TetraPak_Caching_SimpleCache.md 'TetraPak.Caching.SimpleCache')
## SimpleCache.OnDeleteAsync(string, string, bool) Method
Removes a time limited value, optionally without validation.  
```csharp
protected virtual System.Threading.Tasks.Task OnDeleteAsync(string repository, string key, bool safe);
```
#### Parameters
<a name='TetraPak_Caching_SimpleCache_OnDeleteAsync(string_string_bool)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository to remove the value from.  
  
<a name='TetraPak_Caching_SimpleCache_OnDeleteAsync(string_string_bool)_key'></a>
`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Value's unique identifier.  
  
<a name='TetraPak_Caching_SimpleCache_OnDeleteAsync(string_string_bool)_safe'></a>
`safe` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
When set no validation will take place. Attempting to remove an unrecognized  
value will not throw an exception.  
  
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
#### Exceptions
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
The [key](TetraPak_Caching_SimpleCache_OnDeleteAsync(string_string_bool).md#TetraPak_Caching_SimpleCache_OnDeleteAsync(string_string_bool)_key 'TetraPak.Caching.SimpleCache.OnDeleteAsync(string, string, bool).key') was not recognized and [safe](TetraPak_Caching_SimpleCache_OnDeleteAsync(string_string_bool).md#TetraPak_Caching_SimpleCache_OnDeleteAsync(string_string_bool)_safe 'TetraPak.Caching.SimpleCache.OnDeleteAsync(string, string, bool).safe') was not set.  
