#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching')
## ITimeLimitedRepositories Interface
Implementors of this contract can act as a repository for arbitrary values  
with a for a limited time, which can be useful for caching purposes.  
```csharp
public interface ITimeLimitedRepositories
```

Derived  
&#8627; [SimpleCache](TetraPak_Caching_SimpleCache.md 'TetraPak.Caching.SimpleCache')  

| Properties | |
| :--- | :--- |
| [DefaultAdjustedLifeSpan](TetraPak_Caching_ITimeLimitedRepositories_DefaultAdjustedLifeSpan.md 'TetraPak.Caching.ITimeLimitedRepositories.DefaultAdjustedLifeSpan') | Gets a default adjusted lifespan for repository values.<br/> |
| [DefaultExtendedLifeSpan](TetraPak_Caching_ITimeLimitedRepositories_DefaultExtendedLifeSpan.md 'TetraPak.Caching.ITimeLimitedRepositories.DefaultExtendedLifeSpan') | Gets a default extended lifespan for repository values. The extended lifespan<br/>is applied to entities as they are read or updated.<br/> |
| [DefaultLifeSpan](TetraPak_Caching_ITimeLimitedRepositories_DefaultLifeSpan.md 'TetraPak.Caching.ITimeLimitedRepositories.DefaultLifeSpan') | Gets a default lifespan for repository values. <br/> |
| [DefaultMaxLifeSpan](TetraPak_Caching_ITimeLimitedRepositories_DefaultMaxLifeSpan.md 'TetraPak.Caching.ITimeLimitedRepositories.DefaultMaxLifeSpan') | Gets a default maximum lifespan for repository values.<br/>The maximum lifespan can never be exceeded by dynamically extending cached entries' lifespan.  <br/> |
| [IsTypeStrict](TetraPak_Caching_ITimeLimitedRepositories_IsTypeStrict.md 'TetraPak.Caching.ITimeLimitedRepositories.IsTypeStrict') | Gets or sets a value specifying whether value types should be validated when updated.<br/>Attempts to update an existing value with a value that is type incompatible will<br/>throw an [IdentityConflictException](TetraPak_IdentityConflictException.md 'TetraPak.IdentityConflictException'). <br/> |

| Methods | |
| :--- | :--- |
| [AddAsync(string, string, object, Nullable&lt;TimeSpan&gt;, Nullable&lt;DateTime&gt;)](TetraPak_Caching_ITimeLimitedRepositories_AddAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_).md 'TetraPak.Caching.ITimeLimitedRepositories.AddAsync(string, string, object, System.Nullable&lt;System.TimeSpan&gt;, System.Nullable&lt;System.DateTime&gt;)') | Adds a new time limited value.<br/> |
| [AddOrUpdateAsync(string, string, object, Nullable&lt;TimeSpan&gt;, Nullable&lt;DateTime&gt;)](TetraPak_Caching_ITimeLimitedRepositories_AddOrUpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_).md 'TetraPak.Caching.ITimeLimitedRepositories.AddOrUpdateAsync(string, string, object, System.Nullable&lt;System.TimeSpan&gt;, System.Nullable&lt;System.DateTime&gt;)') | Adds a new value or updated an existing one.<br/> |
| [ConfigureAsync(string, ITimeLimitedRepositoryOptions)](TetraPak_Caching_ITimeLimitedRepositories_ConfigureAsync(string_TetraPak_Caching_ITimeLimitedRepositoryOptions).md 'TetraPak.Caching.ITimeLimitedRepositories.ConfigureAsync(string, TetraPak.Caching.ITimeLimitedRepositoryOptions)') | Creates or configures a time limited repository.<br/> |
| [DeleteAsync(string, string)](TetraPak_Caching_ITimeLimitedRepositories_DeleteAsync(string_string).md 'TetraPak.Caching.ITimeLimitedRepositories.DeleteAsync(string, string)') | Removes a time limited value.<br/> |
| [GetAdjustedLifeSpan(string)](TetraPak_Caching_ITimeLimitedRepositories_GetAdjustedLifeSpan(string).md 'TetraPak.Caching.ITimeLimitedRepositories.GetAdjustedLifeSpan(string)') | Gets the reduced lifespan configured for a specified repository.<br/>The reduced lifespan is applied every time a cached entity is read or updated.  <br/> |
| [GetAsync&lt;T&gt;(string, string)](TetraPak_Caching_ITimeLimitedRepositories_GetAsync_T_(string_string).md 'TetraPak.Caching.ITimeLimitedRepositories.GetAsync&lt;T&gt;(string, string)') | Looks up a value in a repository.<br/> |
| [GetExtendedLifeSpan(string)](TetraPak_Caching_ITimeLimitedRepositories_GetExtendedLifeSpan(string).md 'TetraPak.Caching.ITimeLimitedRepositories.GetExtendedLifeSpan(string)') | Gets the extended lifespan configured for a specified repository.<br/>The extended lifespan is applied every time a cached entity is read or updated.  <br/> |
| [GetLifeSpan(string)](TetraPak_Caching_ITimeLimitedRepositories_GetLifeSpan(string).md 'TetraPak.Caching.ITimeLimitedRepositories.GetLifeSpan(string)') | Gets the lifespan configured for a specified repository. <br/> |
| [GetMaxLifeSpan(string)](TetraPak_Caching_ITimeLimitedRepositories_GetMaxLifeSpan(string).md 'TetraPak.Caching.ITimeLimitedRepositories.GetMaxLifeSpan(string)') | Gets the maximum allowed lifespan configured for a specified repository. <br/> |
| [GetRepositoryOptionsAsync(string, bool)](TetraPak_Caching_ITimeLimitedRepositories_GetRepositoryOptionsAsync(string_bool).md 'TetraPak.Caching.ITimeLimitedRepositories.GetRepositoryOptionsAsync(string, bool)') | Obtains the configuration for a specified repository.<br/> |
| [UpdateAsync(string, string, object, Nullable&lt;TimeSpan&gt;, Nullable&lt;DateTime&gt;)](TetraPak_Caching_ITimeLimitedRepositories_UpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_).md 'TetraPak.Caching.ITimeLimitedRepositories.UpdateAsync(string, string, object, System.Nullable&lt;System.TimeSpan&gt;, System.Nullable&lt;System.DateTime&gt;)') | Updates an existing time limited value.<br/> |
