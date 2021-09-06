#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching')
## SimpleCache Class
Implements a very simple memory cache with automatic purging.  
```csharp
public class SimpleCache :
TetraPak.Caching.ITimeLimitedRepositories
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SimpleCache  

Implements [ITimeLimitedRepositories](TetraPak_Caching_ITimeLimitedRepositories.md 'TetraPak.Caching.ITimeLimitedRepositories')  

| Properties | |
| :--- | :--- |
| [AutoPurgeInterval](TetraPak_Caching_SimpleCache_AutoPurgeInterval.md 'TetraPak.Caching.SimpleCache.AutoPurgeInterval') | Gets or sets an interval between automatic purging processes.<br/> |
| [DefaultAdjustedLifeSpan](TetraPak_Caching_SimpleCache_DefaultAdjustedLifeSpan.md 'TetraPak.Caching.SimpleCache.DefaultAdjustedLifeSpan') | Gets a default adjusted lifespan for repository values.<br/> |
| [DefaultExtendedLifeSpan](TetraPak_Caching_SimpleCache_DefaultExtendedLifeSpan.md 'TetraPak.Caching.SimpleCache.DefaultExtendedLifeSpan') | Gets a default extended lifespan for repository values. The extended lifespan<br/>is applied to entities as they are read or updated.<br/> |
| [DefaultLifeSpan](TetraPak_Caching_SimpleCache_DefaultLifeSpan.md 'TetraPak.Caching.SimpleCache.DefaultLifeSpan') | Gets a default lifespan for repository values. <br/> |
| [DefaultMaxLifeSpan](TetraPak_Caching_SimpleCache_DefaultMaxLifeSpan.md 'TetraPak.Caching.SimpleCache.DefaultMaxLifeSpan') | Gets a default maximum lifespan for repository values.<br/>The maximum lifespan can never be exceeded by dynamically extending cached entries' lifespan.  <br/> |
| [IsTypeStrict](TetraPak_Caching_SimpleCache_IsTypeStrict.md 'TetraPak.Caching.SimpleCache.IsTypeStrict') | Gets or sets a value specifying whether value types should be validated when updated.<br/>Attempts to update an existing value with a value that is type incompatible will<br/>throw an [IdentityConflictException](TetraPak_IdentityConflictException.md 'TetraPak.IdentityConflictException'). <br/> |
| [Logger](TetraPak_Caching_SimpleCache_Logger.md 'TetraPak.Caching.SimpleCache.Logger') | Gets a logging provider.<br/> |

| Methods | |
| :--- | :--- |
| [AddAsync(string, string, object, Nullable&lt;TimeSpan&gt;, Nullable&lt;DateTime&gt;)](TetraPak_Caching_SimpleCache_AddAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_).md 'TetraPak.Caching.SimpleCache.AddAsync(string, string, object, System.Nullable&lt;System.TimeSpan&gt;, System.Nullable&lt;System.DateTime&gt;)') | Adds a new time limited value.<br/> |
| [AddOrUpdateAsync(string, string, object, Nullable&lt;TimeSpan&gt;, Nullable&lt;DateTime&gt;)](TetraPak_Caching_SimpleCache_AddOrUpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_).md 'TetraPak.Caching.SimpleCache.AddOrUpdateAsync(string, string, object, System.Nullable&lt;System.TimeSpan&gt;, System.Nullable&lt;System.DateTime&gt;)') | Adds a new value or updated an existing one.<br/> |
| [ConfigureAsync(string, ITimeLimitedRepositoryOptions)](TetraPak_Caching_SimpleCache_ConfigureAsync(string_TetraPak_Caching_ITimeLimitedRepositoryOptions).md 'TetraPak.Caching.SimpleCache.ConfigureAsync(string, TetraPak.Caching.ITimeLimitedRepositoryOptions)') | Creates or configures a time limited repository.<br/> |
| [DeleteAsync(string, string)](TetraPak_Caching_SimpleCache_DeleteAsync(string_string).md 'TetraPak.Caching.SimpleCache.DeleteAsync(string, string)') | Removes a time limited value.<br/> |
| [GetAdjustedLifeSpan(string)](TetraPak_Caching_SimpleCache_GetAdjustedLifeSpan(string).md 'TetraPak.Caching.SimpleCache.GetAdjustedLifeSpan(string)') | Gets the reduced lifespan configured for a specified repository.<br/>The reduced lifespan is applied every time a cached entity is read or updated.  <br/> |
| [GetAsync&lt;T&gt;(string, string)](TetraPak_Caching_SimpleCache_GetAsync_T_(string_string).md 'TetraPak.Caching.SimpleCache.GetAsync&lt;T&gt;(string, string)') | Looks up a value in a repository.<br/> |
| [GetExtendedLifeSpan(string)](TetraPak_Caching_SimpleCache_GetExtendedLifeSpan(string).md 'TetraPak.Caching.SimpleCache.GetExtendedLifeSpan(string)') | Gets the extended lifespan configured for a specified repository.<br/>The extended lifespan is applied every time a cached entity is read or updated.  <br/> |
| [GetLifeSpan(string)](TetraPak_Caching_SimpleCache_GetLifeSpan(string).md 'TetraPak.Caching.SimpleCache.GetLifeSpan(string)') | Gets the lifespan configured for a specified repository. <br/> |
| [GetMaxLifeSpan(string)](TetraPak_Caching_SimpleCache_GetMaxLifeSpan(string).md 'TetraPak.Caching.SimpleCache.GetMaxLifeSpan(string)') | Gets the maximum allowed lifespan configured for a specified repository. <br/> |
| [GetRepositoryOptionsAsync(string, bool)](TetraPak_Caching_SimpleCache_GetRepositoryOptionsAsync(string_bool).md 'TetraPak.Caching.SimpleCache.GetRepositoryOptionsAsync(string, bool)') | Obtains the configuration for a specified repository.<br/> |
| [OnDeleteAsync(string, string, bool)](TetraPak_Caching_SimpleCache_OnDeleteAsync(string_string_bool).md 'TetraPak.Caching.SimpleCache.OnDeleteAsync(string, string, bool)') | Removes a time limited value, optionally without validation.<br/> |
| [OnPurgeDeadEntries(IEnumerable&lt;ITimeLimitedRepositoryEntry&gt;)](TetraPak_Caching_SimpleCache_OnPurgeDeadEntries(System_Collections_Generic_IEnumerable_TetraPak_Caching_ITimeLimitedRepositoryEntry_).md 'TetraPak.Caching.SimpleCache.OnPurgeDeadEntries(System.Collections.Generic.IEnumerable&lt;TetraPak.Caching.ITimeLimitedRepositoryEntry&gt;)') | This method gets called from a background thread to allow selecting entries to be removed.<br/>The default implementation simply returns a collection of entries that are "dead"<br/>(the [TetraPak.Caching.ITimeLimitedRepositoryEntry.IsLive(System.TimeSpan@)](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Caching.ITimeLimitedRepositoryEntry.IsLive#TetraPak_Caching_ITimeLimitedRepositoryEntry_IsLive_System_TimeSpan@_ 'TetraPak.Caching.ITimeLimitedRepositoryEntry.IsLive(System.TimeSpan@)') returns `false`).<br/> |
| [OnPurgeDeadEntriesAsync()](TetraPak_Caching_SimpleCache_OnPurgeDeadEntriesAsync().md 'TetraPak.Caching.SimpleCache.OnPurgeDeadEntriesAsync()') | Gets called automatically (in a background thread) to remove dead entries. <br/> |
| [UpdateAsync(string, string, object, Nullable&lt;TimeSpan&gt;, Nullable&lt;DateTime&gt;)](TetraPak_Caching_SimpleCache_UpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_).md 'TetraPak.Caching.SimpleCache.UpdateAsync(string, string, object, System.Nullable&lt;System.TimeSpan&gt;, System.Nullable&lt;System.DateTime&gt;)') | Updates an existing time limited value.<br/> |
