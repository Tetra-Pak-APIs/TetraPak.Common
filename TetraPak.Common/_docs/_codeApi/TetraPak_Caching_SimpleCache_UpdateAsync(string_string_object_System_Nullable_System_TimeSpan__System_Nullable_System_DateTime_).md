#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching').[SimpleCache](TetraPak_Caching_SimpleCache.md 'TetraPak.Caching.SimpleCache')
## SimpleCache.UpdateAsync(string, string, object, Nullable&lt;TimeSpan&gt;, Nullable&lt;DateTime&gt;) Method
Updates an existing time limited value.  
```csharp
public System.Threading.Tasks.Task UpdateAsync(string repository, string key, object value, System.Nullable<System.TimeSpan> customLifeSpan=null, System.Nullable<System.DateTime> spawnTimeUtc=null);
```
#### Parameters
<a name='TetraPak_Caching_SimpleCache_UpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository where the value should exist.  
  
<a name='TetraPak_Caching_SimpleCache_UpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_key'></a>
`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Value's unique identifier.  
  
<a name='TetraPak_Caching_SimpleCache_UpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_value'></a>
`value` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The value to be added.  
  
<a name='TetraPak_Caching_SimpleCache_UpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_customLifeSpan'></a>
`customLifeSpan` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
(optional; default=[DefaultLifeSpan](TetraPak_Caching_ITimeLimitedRepositories_DefaultLifeSpan.md 'TetraPak.Caching.ITimeLimitedRepositories.DefaultLifeSpan'))<br/>  
A custom lifespan for the value.  
  
<a name='TetraPak_Caching_SimpleCache_UpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_spawnTimeUtc'></a>
`spawnTimeUtc` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
(optional; default=[System.DateTime.UtcNow](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime.UtcNow 'System.DateTime.UtcNow'))<br/>  
Specifies the spawn time for the value.  
  
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
#### Exceptions
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
A value could not be identified from the specified [key](TetraPak_Caching_SimpleCache_UpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_).md#TetraPak_Caching_SimpleCache_UpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_key 'TetraPak.Caching.SimpleCache.UpdateAsync(string, string, object, System.Nullable&lt;System.TimeSpan&gt;, System.Nullable&lt;System.DateTime&gt;).key').  

Implements [UpdateAsync(string, string, object, Nullable<TimeSpan>, Nullable<DateTime>)](TetraPak_Caching_ITimeLimitedRepositories_UpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_).md 'TetraPak.Caching.ITimeLimitedRepositories.UpdateAsync(string, string, object, System.Nullable&lt;System.TimeSpan&gt;, System.Nullable&lt;System.DateTime&gt;)')  
