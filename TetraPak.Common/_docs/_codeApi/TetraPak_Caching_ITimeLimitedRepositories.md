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
### Properties
<a name='TetraPak_Caching_ITimeLimitedRepositories_DefaultAdjustedLifeSpan'></a>
## ITimeLimitedRepositories.DefaultAdjustedLifeSpan Property
Gets a default adjusted lifespan for repository values.  
```csharp
System.TimeSpan DefaultAdjustedLifeSpan { get; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')
#### See Also
- [DefaultLifeSpan](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_DefaultLifeSpan 'TetraPak.Caching.ITimeLimitedRepositories.DefaultLifeSpan')
- [DefaultExtendedLifeSpan](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_DefaultExtendedLifeSpan 'TetraPak.Caching.ITimeLimitedRepositories.DefaultExtendedLifeSpan')
- [DefaultMaxLifeSpan](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_DefaultMaxLifeSpan 'TetraPak.Caching.ITimeLimitedRepositories.DefaultMaxLifeSpan')
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_DefaultExtendedLifeSpan'></a>
## ITimeLimitedRepositories.DefaultExtendedLifeSpan Property
Gets a default extended lifespan for repository values. The extended lifespan  
is applied to entities as they are read or updated.  
```csharp
System.TimeSpan DefaultExtendedLifeSpan { get; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')
### Remarks
Set this value to zero ("0" or "0:0:0") to avoid extending entries' cache lifespan.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_DefaultLifeSpan'></a>
## ITimeLimitedRepositories.DefaultLifeSpan Property
Gets a default lifespan for repository values.   
```csharp
System.TimeSpan DefaultLifeSpan { get; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_DefaultMaxLifeSpan'></a>
## ITimeLimitedRepositories.DefaultMaxLifeSpan Property
Gets a default maximum lifespan for repository values.  
The maximum lifespan can never be exceeded by dynamically extending cached entries' lifespan.    
```csharp
System.TimeSpan DefaultMaxLifeSpan { get; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')
#### See Also
- [DefaultLifeSpan](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_DefaultLifeSpan 'TetraPak.Caching.ITimeLimitedRepositories.DefaultLifeSpan')
- [DefaultExtendedLifeSpan](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_DefaultExtendedLifeSpan 'TetraPak.Caching.ITimeLimitedRepositories.DefaultExtendedLifeSpan')
- [DefaultAdjustedLifeSpan](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_DefaultAdjustedLifeSpan 'TetraPak.Caching.ITimeLimitedRepositories.DefaultAdjustedLifeSpan')
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_IsTypeStrict'></a>
## ITimeLimitedRepositories.IsTypeStrict Property
Gets or sets a value specifying whether value types should be validated when updated.  
Attempts to update an existing value with a value that is type incompatible will  
throw an [IdentityConflictException](TetraPak_IdentityConflictException.md 'TetraPak.IdentityConflictException').   
```csharp
bool IsTypeStrict { get; set; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
  
### Methods
<a name='TetraPak_Caching_ITimeLimitedRepositories_AddAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)'></a>
## ITimeLimitedRepositories.AddAsync(string, string, object, Nullable&lt;TimeSpan&gt;, Nullable&lt;DateTime&gt;) Method
Adds a new time limited value.  
```csharp
System.Threading.Tasks.Task AddAsync(string repository, string key, object value, System.Nullable<System.TimeSpan> customLifeSpan=null, System.Nullable<System.DateTime> spawnTimeUtc=null);
```
#### Parameters
<a name='TetraPak_Caching_ITimeLimitedRepositories_AddAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository where the new value should exist.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_AddAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_key'></a>
`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Value's unique identifier.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_AddAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_value'></a>
`value` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The value to be added.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_AddAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_customLifeSpan'></a>
`customLifeSpan` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
(optional; default=[DefaultLifeSpan](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_DefaultLifeSpan 'TetraPak.Caching.ITimeLimitedRepositories.DefaultLifeSpan'))<br/>  
A custom lifespan for the value.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_AddAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_spawnTimeUtc'></a>
`spawnTimeUtc` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
(optional; default=[System.DateTime.UtcNow](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime.UtcNow 'System.DateTime.UtcNow'))<br/>  
Specifies the spawn time for the value.  
  
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
#### Exceptions
[IdentityConflictException](TetraPak_IdentityConflictException.md 'TetraPak.IdentityConflictException')  
A value with the same [key](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_AddAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_key 'TetraPak.Caching.ITimeLimitedRepositories.AddAsync(string, string, object, System.Nullable&lt;System.TimeSpan&gt;, System.Nullable&lt;System.DateTime&gt;).key') was already added.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_AddOrUpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)'></a>
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
(optional; default=[DefaultLifeSpan](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_DefaultLifeSpan 'TetraPak.Caching.ITimeLimitedRepositories.DefaultLifeSpan'))<br/>  
A custom lifespan for the value.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_AddOrUpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_spawnTimeUtc'></a>
`spawnTimeUtc` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
(optional; default=[System.DateTime.UtcNow](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime.UtcNow 'System.DateTime.UtcNow'))<br/>  
Specifies the spawn time for the value.  
  
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
#### Exceptions
[System.InvalidCastException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidCastException 'System.InvalidCastException')  
A value with the same [key](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_AddOrUpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_key 'TetraPak.Caching.ITimeLimitedRepositories.AddOrUpdateAsync(string, string, object, System.Nullable&lt;System.TimeSpan&gt;, System.Nullable&lt;System.DateTime&gt;).key') was already added but its value is incompatible with the new value.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_ConfigureAsync(string_TetraPak_Caching_ITimeLimitedRepositoryOptions)'></a>
## ITimeLimitedRepositories.ConfigureAsync(string, ITimeLimitedRepositoryOptions) Method
Creates or configures a time limited repository.  
```csharp
System.Threading.Tasks.Task ConfigureAsync(string repository, TetraPak.Caching.ITimeLimitedRepositoryOptions options);
```
#### Parameters
<a name='TetraPak_Caching_ITimeLimitedRepositories_ConfigureAsync(string_TetraPak_Caching_ITimeLimitedRepositoryOptions)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository to be configured.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_ConfigureAsync(string_TetraPak_Caching_ITimeLimitedRepositoryOptions)_options'></a>
`options` [ITimeLimitedRepositoryOptions](TetraPak_Caching_ITimeLimitedRepositoryOptions.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions')  
Specifies the repository configuration.  
  
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_DeleteAsync(string_string)'></a>
## ITimeLimitedRepositories.DeleteAsync(string, string) Method
Removes a time limited value.  
```csharp
System.Threading.Tasks.Task DeleteAsync(string repository, string key);
```
#### Parameters
<a name='TetraPak_Caching_ITimeLimitedRepositories_DeleteAsync(string_string)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository to remove the value from.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_DeleteAsync(string_string)_key'></a>
`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Value's unique identifier.  
  
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
#### Exceptions
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
The [key](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_DeleteAsync(string_string)_key 'TetraPak.Caching.ITimeLimitedRepositories.DeleteAsync(string, string).key') was not recognized.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_GetAdjustedLifeSpan(string)'></a>
## ITimeLimitedRepositories.GetAdjustedLifeSpan(string) Method
Gets the reduced lifespan configured for a specified repository.  
The reduced lifespan is applied every time a cached entity is read or updated.    
```csharp
System.TimeSpan GetAdjustedLifeSpan(string repository);
```
#### Parameters
<a name='TetraPak_Caching_ITimeLimitedRepositories_GetAdjustedLifeSpan(string)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository.      
  
#### Returns
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')  
A [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') value.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_GetAsync_T_(string_string)'></a>
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
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TetraPak.Outcome&lt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')[T](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_GetAsync_T_(string_string)_T 'TetraPak.Caching.ITimeLimitedRepositories.GetAsync&lt;T&gt;(string, string).T')[&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
An [Outcome&lt;T&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;') to indicate success/failure and also carry the requested value  
(or an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') on failure).  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_GetExtendedLifeSpan(string)'></a>
## ITimeLimitedRepositories.GetExtendedLifeSpan(string) Method
Gets the extended lifespan configured for a specified repository.  
The extended lifespan is applied every time a cached entity is read or updated.    
```csharp
System.TimeSpan GetExtendedLifeSpan(string repository);
```
#### Parameters
<a name='TetraPak_Caching_ITimeLimitedRepositories_GetExtendedLifeSpan(string)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository.      
  
#### Returns
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')  
A [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') value.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_GetLifeSpan(string)'></a>
## ITimeLimitedRepositories.GetLifeSpan(string) Method
Gets the lifespan configured for a specified repository.   
```csharp
System.TimeSpan GetLifeSpan(string repository);
```
#### Parameters
<a name='TetraPak_Caching_ITimeLimitedRepositories_GetLifeSpan(string)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository.      
  
#### Returns
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')  
A [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') value.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_GetMaxLifeSpan(string)'></a>
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
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_GetRepositoryOptionsAsync(string_bool)'></a>
## ITimeLimitedRepositories.GetRepositoryOptionsAsync(string, bool) Method
Obtains the configuration for a specified repository.  
```csharp
System.Threading.Tasks.Task<TetraPak.Caching.ITimeLimitedRepositoryOptions> GetRepositoryOptionsAsync(string repository, bool useDefault=true);
```
#### Parameters
<a name='TetraPak_Caching_ITimeLimitedRepositories_GetRepositoryOptionsAsync(string_bool)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_GetRepositoryOptionsAsync(string_bool)_useDefault'></a>
`useDefault` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Specifies whether to return default options when none could be found.  
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[ITimeLimitedRepositoryOptions](TetraPak_Caching_ITimeLimitedRepositoryOptions.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A [ITimeLimitedRepositoryOptions](TetraPak_Caching_ITimeLimitedRepositoryOptions.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions') instance.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_UpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)'></a>
## ITimeLimitedRepositories.UpdateAsync(string, string, object, Nullable&lt;TimeSpan&gt;, Nullable&lt;DateTime&gt;) Method
Updates an existing time limited value.  
```csharp
System.Threading.Tasks.Task UpdateAsync(string repository, string key, object value, System.Nullable<System.TimeSpan> customLifeSpan=null, System.Nullable<System.DateTime> spawnTimeUtc=null);
```
#### Parameters
<a name='TetraPak_Caching_ITimeLimitedRepositories_UpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository where the value should exist.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_UpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_key'></a>
`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Value's unique identifier.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_UpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_value'></a>
`value` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The value to be added.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_UpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_customLifeSpan'></a>
`customLifeSpan` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
(optional; default=[DefaultLifeSpan](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_DefaultLifeSpan 'TetraPak.Caching.ITimeLimitedRepositories.DefaultLifeSpan'))<br/>  
A custom lifespan for the value.  
  
<a name='TetraPak_Caching_ITimeLimitedRepositories_UpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_spawnTimeUtc'></a>
`spawnTimeUtc` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
(optional; default=[System.DateTime.UtcNow](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime.UtcNow 'System.DateTime.UtcNow'))<br/>  
Specifies the spawn time for the value.  
  
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
#### Exceptions
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
A value could not be identified from the specified [key](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_UpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_key 'TetraPak.Caching.ITimeLimitedRepositories.UpdateAsync(string, string, object, System.Nullable&lt;System.TimeSpan&gt;, System.Nullable&lt;System.DateTime&gt;).key').  
  
