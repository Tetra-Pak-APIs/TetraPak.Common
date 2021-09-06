#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching').[ITimeLimitedRepositories](TetraPak_Caching_ITimeLimitedRepositories.md 'TetraPak.Caching.ITimeLimitedRepositories')
## ITimeLimitedRepositories.AddOrUpdateAsync(string, string, object, Nullable&lt;TimeSpan&gt;, Nullable&lt;DateTime&gt;) Method
Adds a new value or updated an existing one.  
```csharp
System.Threading.Tasks.Task AddOrUpdateAsync(string repository, string key, object value, System.Nullable<System.TimeSpan> customLifeSpan=null, System.Nullable<System.DateTime> spawnTimeUtc=null);
```
#### Parameters
<a name='TetraPak_Caching_ITimeLimitedRepositories_AddOrUpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository where the value should exist.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_AddOrUpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_key'></a>
`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Value's unique identifier.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_AddOrUpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_value'></a>
`value` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The value to be added or updated.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_AddOrUpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_customLifeSpan'></a>
`customLifeSpan` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
(optional; default=[DefaultLifeSpan](TetraPak_Caching_ITimeLimitedRepositories_DefaultLifeSpan.md 'TetraPak.Caching.ITimeLimitedRepositories.DefaultLifeSpan'))<br/>  
A custom lifespan for the value.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_AddOrUpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_spawnTimeUtc'></a>
`spawnTimeUtc` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
(optional; default=[System.DateTime.UtcNow](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime.UtcNow 'System.DateTime.UtcNow'))<br/>  
Specifies the spawn time for the value.  
  
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
#### Exceptions
[System.InvalidCastException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidCastException 'System.InvalidCastException')  
A value with the same [key](TetraPak_Caching_ITimeLimitedRepositories_AddOrUpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_).md#TetraPak_Caching_ITimeLimitedRepositories_AddOrUpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_key 'TetraPak.Caching.ITimeLimitedRepositories.AddOrUpdateAsync(string, string, object, System.Nullable&lt;System.TimeSpan&gt;, System.Nullable&lt;System.DateTime&gt;).key') was already added but its value is incompatible with the new value.  
