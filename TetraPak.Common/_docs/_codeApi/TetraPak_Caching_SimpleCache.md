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
### Properties
<a name='TetraPak_Caching_SimpleCache_AutoPurgeInterval'></a>
## SimpleCache.AutoPurgeInterval Property
Gets or sets an interval between automatic purging processes.  
```csharp
public System.TimeSpan AutoPurgeInterval { get; set; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')
### Remarks
By setting this value to anything lower than [System.TimeSpan.MaxValue](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan.MaxValue 'System.TimeSpan.MaxValue') the  
[SimpleCache](TetraPak_Caching_SimpleCache.md 'TetraPak.Caching.SimpleCache') instance will automatically remove all entries regularly,  
to avoid resources leaks.    
  
<a name='TetraPak_Caching_SimpleCache_DefaultAdjustedLifeSpan'></a>
## SimpleCache.DefaultAdjustedLifeSpan Property
Gets a default adjusted lifespan for repository values.  
```csharp
public System.TimeSpan DefaultAdjustedLifeSpan { get; set; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')

Implements [DefaultAdjustedLifeSpan](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_DefaultAdjustedLifeSpan 'TetraPak.Caching.ITimeLimitedRepositories.DefaultAdjustedLifeSpan')  
#### See Also
- [DefaultLifeSpan](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_DefaultLifeSpan 'TetraPak.Caching.ITimeLimitedRepositories.DefaultLifeSpan')
- [DefaultExtendedLifeSpan](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_DefaultExtendedLifeSpan 'TetraPak.Caching.ITimeLimitedRepositories.DefaultExtendedLifeSpan')
- [DefaultMaxLifeSpan](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_DefaultMaxLifeSpan 'TetraPak.Caching.ITimeLimitedRepositories.DefaultMaxLifeSpan')
  
<a name='TetraPak_Caching_SimpleCache_DefaultExtendedLifeSpan'></a>
## SimpleCache.DefaultExtendedLifeSpan Property
Gets a default extended lifespan for repository values. The extended lifespan  
is applied to entities as they are read or updated.  
```csharp
public System.TimeSpan DefaultExtendedLifeSpan { get; set; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')

Implements [DefaultExtendedLifeSpan](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_DefaultExtendedLifeSpan 'TetraPak.Caching.ITimeLimitedRepositories.DefaultExtendedLifeSpan')  
### Remarks
Set this value to zero ("0" or "0:0:0") to avoid extending entries' cache lifespan.  
  
<a name='TetraPak_Caching_SimpleCache_DefaultLifeSpan'></a>
## SimpleCache.DefaultLifeSpan Property
Gets a default lifespan for repository values.   
```csharp
public System.TimeSpan DefaultLifeSpan { get; set; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')

Implements [DefaultLifeSpan](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_DefaultLifeSpan 'TetraPak.Caching.ITimeLimitedRepositories.DefaultLifeSpan')  
  
<a name='TetraPak_Caching_SimpleCache_DefaultMaxLifeSpan'></a>
## SimpleCache.DefaultMaxLifeSpan Property
Gets a default maximum lifespan for repository values.  
The maximum lifespan can never be exceeded by dynamically extending cached entries' lifespan.    
```csharp
public System.TimeSpan DefaultMaxLifeSpan { get; set; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')

Implements [DefaultMaxLifeSpan](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_DefaultMaxLifeSpan 'TetraPak.Caching.ITimeLimitedRepositories.DefaultMaxLifeSpan')  
#### See Also
- [DefaultLifeSpan](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_DefaultLifeSpan 'TetraPak.Caching.ITimeLimitedRepositories.DefaultLifeSpan')
- [DefaultExtendedLifeSpan](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_DefaultExtendedLifeSpan 'TetraPak.Caching.ITimeLimitedRepositories.DefaultExtendedLifeSpan')
- [DefaultAdjustedLifeSpan](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_DefaultAdjustedLifeSpan 'TetraPak.Caching.ITimeLimitedRepositories.DefaultAdjustedLifeSpan')
  
<a name='TetraPak_Caching_SimpleCache_IsTypeStrict'></a>
## SimpleCache.IsTypeStrict Property
Gets or sets a value specifying whether value types should be validated when updated.  
Attempts to update an existing value with a value that is type incompatible will  
throw an [IdentityConflictException](TetraPak_IdentityConflictException.md 'TetraPak.IdentityConflictException').   
```csharp
public bool IsTypeStrict { get; set; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Implements [IsTypeStrict](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_IsTypeStrict 'TetraPak.Caching.ITimeLimitedRepositories.IsTypeStrict')  
  
<a name='TetraPak_Caching_SimpleCache_Logger'></a>
## SimpleCache.Logger Property
Gets a logging provider.  
```csharp
public Microsoft.Extensions.Logging.ILogger<TetraPak.Caching.SimpleCache> Logger { get; }
```
#### Property Value
[Microsoft.Extensions.Logging.ILogger&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger-1 'Microsoft.Extensions.Logging.ILogger`1')[SimpleCache](TetraPak_Caching_SimpleCache.md 'TetraPak.Caching.SimpleCache')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger-1 'Microsoft.Extensions.Logging.ILogger`1')
  
### Methods
<a name='TetraPak_Caching_SimpleCache_AddAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)'></a>
## SimpleCache.AddAsync(string, string, object, Nullable&lt;TimeSpan&gt;, Nullable&lt;DateTime&gt;) Method
Adds a new time limited value.  
```csharp
public System.Threading.Tasks.Task AddAsync(string repository, string key, object value, System.Nullable<System.TimeSpan> customLifeSpan=null, System.Nullable<System.DateTime> spawnTimeUtc=null);
```
#### Parameters
<a name='TetraPak_Caching_SimpleCache_AddAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository where the new value should exist.  
  
<a name='TetraPak_Caching_SimpleCache_AddAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_key'></a>
`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Value's unique identifier.  
  
<a name='TetraPak_Caching_SimpleCache_AddAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_value'></a>
`value` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The value to be added.  
  
<a name='TetraPak_Caching_SimpleCache_AddAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_customLifeSpan'></a>
`customLifeSpan` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
(optional; default=[DefaultLifeSpan](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_DefaultLifeSpan 'TetraPak.Caching.ITimeLimitedRepositories.DefaultLifeSpan'))<br/>  
A custom lifespan for the value.  
  
<a name='TetraPak_Caching_SimpleCache_AddAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_spawnTimeUtc'></a>
`spawnTimeUtc` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
(optional; default=[System.DateTime.UtcNow](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime.UtcNow 'System.DateTime.UtcNow'))<br/>  
Specifies the spawn time for the value.  
  
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
#### Exceptions
[IdentityConflictException](TetraPak_IdentityConflictException.md 'TetraPak.IdentityConflictException')  
A value with the same [key](TetraPak_Caching_SimpleCache.md#TetraPak_Caching_SimpleCache_AddAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_key 'TetraPak.Caching.SimpleCache.AddAsync(string, string, object, System.Nullable&lt;System.TimeSpan&gt;, System.Nullable&lt;System.DateTime&gt;).key') was already added.  

Implements [AddAsync(string, string, object, Nullable<TimeSpan>, Nullable<DateTime>)](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_AddAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_) 'TetraPak.Caching.ITimeLimitedRepositories.AddAsync(string, string, object, System.Nullable&lt;System.TimeSpan&gt;, System.Nullable&lt;System.DateTime&gt;)')  
  
<a name='TetraPak_Caching_SimpleCache_AddOrUpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)'></a>
## SimpleCache.AddOrUpdateAsync(string, string, object, Nullable&lt;TimeSpan&gt;, Nullable&lt;DateTime&gt;) Method
Adds a new value or updated an existing one.  
```csharp
public System.Threading.Tasks.Task AddOrUpdateAsync(string repository, string key, object value, System.Nullable<System.TimeSpan> customLifeSpan=null, System.Nullable<System.DateTime> spawnTimeUtc=null);
```
#### Parameters
<a name='TetraPak_Caching_SimpleCache_AddOrUpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository where the value should exist.  
  
<a name='TetraPak_Caching_SimpleCache_AddOrUpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_key'></a>
`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Value's unique identifier.  
  
<a name='TetraPak_Caching_SimpleCache_AddOrUpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_value'></a>
`value` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The value to be added or updated.  
  
<a name='TetraPak_Caching_SimpleCache_AddOrUpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_customLifeSpan'></a>
`customLifeSpan` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
(optional; default=[DefaultLifeSpan](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_DefaultLifeSpan 'TetraPak.Caching.ITimeLimitedRepositories.DefaultLifeSpan'))<br/>  
A custom lifespan for the value.  
  
<a name='TetraPak_Caching_SimpleCache_AddOrUpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_spawnTimeUtc'></a>
`spawnTimeUtc` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
(optional; default=[System.DateTime.UtcNow](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime.UtcNow 'System.DateTime.UtcNow'))<br/>  
Specifies the spawn time for the value.  
  
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
#### Exceptions
[System.InvalidCastException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidCastException 'System.InvalidCastException')  
A value with the same [key](TetraPak_Caching_SimpleCache.md#TetraPak_Caching_SimpleCache_AddOrUpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_key 'TetraPak.Caching.SimpleCache.AddOrUpdateAsync(string, string, object, System.Nullable&lt;System.TimeSpan&gt;, System.Nullable&lt;System.DateTime&gt;).key') was already added but its value is incompatible with the new value.  

Implements [AddOrUpdateAsync(string, string, object, Nullable<TimeSpan>, Nullable<DateTime>)](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_AddOrUpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_) 'TetraPak.Caching.ITimeLimitedRepositories.AddOrUpdateAsync(string, string, object, System.Nullable&lt;System.TimeSpan&gt;, System.Nullable&lt;System.DateTime&gt;)')  
  
<a name='TetraPak_Caching_SimpleCache_ConfigureAsync(string_TetraPak_Caching_ITimeLimitedRepositoryOptions)'></a>
## SimpleCache.ConfigureAsync(string, ITimeLimitedRepositoryOptions) Method
Creates or configures a time limited repository.  
```csharp
public virtual System.Threading.Tasks.Task ConfigureAsync(string repository, TetraPak.Caching.ITimeLimitedRepositoryOptions options);
```
#### Parameters
<a name='TetraPak_Caching_SimpleCache_ConfigureAsync(string_TetraPak_Caching_ITimeLimitedRepositoryOptions)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository to be configured.  
  
<a name='TetraPak_Caching_SimpleCache_ConfigureAsync(string_TetraPak_Caching_ITimeLimitedRepositoryOptions)_options'></a>
`options` [ITimeLimitedRepositoryOptions](TetraPak_Caching_ITimeLimitedRepositoryOptions.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions')  
Specifies the repository configuration.  
  
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  

Implements [ConfigureAsync(string, ITimeLimitedRepositoryOptions)](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_ConfigureAsync(string_TetraPak_Caching_ITimeLimitedRepositoryOptions) 'TetraPak.Caching.ITimeLimitedRepositories.ConfigureAsync(string, TetraPak.Caching.ITimeLimitedRepositoryOptions)')  
  
<a name='TetraPak_Caching_SimpleCache_DeleteAsync(string_string)'></a>
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
The [key](TetraPak_Caching_SimpleCache.md#TetraPak_Caching_SimpleCache_DeleteAsync(string_string)_key 'TetraPak.Caching.SimpleCache.DeleteAsync(string, string).key') was not recognized.  

Implements [DeleteAsync(string, string)](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_DeleteAsync(string_string) 'TetraPak.Caching.ITimeLimitedRepositories.DeleteAsync(string, string)')  
  
<a name='TetraPak_Caching_SimpleCache_GetAdjustedLifeSpan(string)'></a>
## SimpleCache.GetAdjustedLifeSpan(string) Method
Gets the reduced lifespan configured for a specified repository.  
The reduced lifespan is applied every time a cached entity is read or updated.    
```csharp
public System.TimeSpan GetAdjustedLifeSpan(string repository);
```
#### Parameters
<a name='TetraPak_Caching_SimpleCache_GetAdjustedLifeSpan(string)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository.      
  
#### Returns
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')  
A [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') value.  

Implements [GetAdjustedLifeSpan(string)](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_GetAdjustedLifeSpan(string) 'TetraPak.Caching.ITimeLimitedRepositories.GetAdjustedLifeSpan(string)')  
  
<a name='TetraPak_Caching_SimpleCache_GetAsync_T_(string_string)'></a>
## SimpleCache.GetAsync&lt;T&gt;(string, string) Method
Looks up a value in a repository.  
```csharp
public virtual System.Threading.Tasks.Task<TetraPak.Outcome<T>> GetAsync<T>(string repository, string key);
```
#### Type parameters
<a name='TetraPak_Caching_SimpleCache_GetAsync_T_(string_string)_T'></a>
`T`  
The requested value [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type').  
  
#### Parameters
<a name='TetraPak_Caching_SimpleCache_GetAsync_T_(string_string)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository where the value should exist.  
  
<a name='TetraPak_Caching_SimpleCache_GetAsync_T_(string_string)_key'></a>
`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the requested value.  
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TetraPak.Outcome&lt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')[T](TetraPak_Caching_SimpleCache.md#TetraPak_Caching_SimpleCache_GetAsync_T_(string_string)_T 'TetraPak.Caching.SimpleCache.GetAsync&lt;T&gt;(string, string).T')[&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
An [Outcome&lt;T&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;') to indicate success/failure and also carry the requested value  
(or an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') on failure).  

Implements [GetAsync<T>(string, string)](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_GetAsync_T_(string_string) 'TetraPak.Caching.ITimeLimitedRepositories.GetAsync&lt;T&gt;(string, string)')  
  
<a name='TetraPak_Caching_SimpleCache_GetExtendedLifeSpan(string)'></a>
## SimpleCache.GetExtendedLifeSpan(string) Method
Gets the extended lifespan configured for a specified repository.  
The extended lifespan is applied every time a cached entity is read or updated.    
```csharp
public System.TimeSpan GetExtendedLifeSpan(string repository);
```
#### Parameters
<a name='TetraPak_Caching_SimpleCache_GetExtendedLifeSpan(string)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository.      
  
#### Returns
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')  
A [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') value.  

Implements [GetExtendedLifeSpan(string)](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_GetExtendedLifeSpan(string) 'TetraPak.Caching.ITimeLimitedRepositories.GetExtendedLifeSpan(string)')  
  
<a name='TetraPak_Caching_SimpleCache_GetLifeSpan(string)'></a>
## SimpleCache.GetLifeSpan(string) Method
Gets the lifespan configured for a specified repository.   
```csharp
public System.TimeSpan GetLifeSpan(string repository);
```
#### Parameters
<a name='TetraPak_Caching_SimpleCache_GetLifeSpan(string)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository.      
  
#### Returns
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')  
A [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') value.  

Implements [GetLifeSpan(string)](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_GetLifeSpan(string) 'TetraPak.Caching.ITimeLimitedRepositories.GetLifeSpan(string)')  
  
<a name='TetraPak_Caching_SimpleCache_GetMaxLifeSpan(string)'></a>
## SimpleCache.GetMaxLifeSpan(string) Method
Gets the maximum allowed lifespan configured for a specified repository.   
```csharp
public System.TimeSpan GetMaxLifeSpan(string repository);
```
#### Parameters
<a name='TetraPak_Caching_SimpleCache_GetMaxLifeSpan(string)_repository'></a>
`repository` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies the repository.      
  
#### Returns
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')  
A [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') value.  

Implements [GetMaxLifeSpan(string)](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_GetMaxLifeSpan(string) 'TetraPak.Caching.ITimeLimitedRepositories.GetMaxLifeSpan(string)')  
  
<a name='TetraPak_Caching_SimpleCache_GetRepositoryOptionsAsync(string_bool)'></a>
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

Implements [GetRepositoryOptionsAsync(string, bool)](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_GetRepositoryOptionsAsync(string_bool) 'TetraPak.Caching.ITimeLimitedRepositories.GetRepositoryOptionsAsync(string, bool)')  
  
<a name='TetraPak_Caching_SimpleCache_OnDeleteAsync(string_string_bool)'></a>
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
The [key](TetraPak_Caching_SimpleCache.md#TetraPak_Caching_SimpleCache_OnDeleteAsync(string_string_bool)_key 'TetraPak.Caching.SimpleCache.OnDeleteAsync(string, string, bool).key') was not recognized and [safe](TetraPak_Caching_SimpleCache.md#TetraPak_Caching_SimpleCache_OnDeleteAsync(string_string_bool)_safe 'TetraPak.Caching.SimpleCache.OnDeleteAsync(string, string, bool).safe') was not set.  
  
<a name='TetraPak_Caching_SimpleCache_OnPurgeDeadEntries(System_Collections_Generic_IEnumerable_TetraPak_Caching_ITimeLimitedRepositoryEntry_)'></a>
## SimpleCache.OnPurgeDeadEntries(IEnumerable&lt;ITimeLimitedRepositoryEntry&gt;) Method
This method gets called from a background thread to allow selecting entries to be removed.  
The default implementation simply returns a collection of entries that are "dead"  
(the [TetraPak.Caching.ITimeLimitedRepositoryEntry.IsLive(System.TimeSpan@)](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Caching.ITimeLimitedRepositoryEntry.IsLive#TetraPak_Caching_ITimeLimitedRepositoryEntry_IsLive_System_TimeSpan@_ 'TetraPak.Caching.ITimeLimitedRepositoryEntry.IsLive(System.TimeSpan@)') returns `false`).  
```csharp
protected virtual System.Threading.Tasks.Task<TetraPak.Caching.ITimeLimitedRepositoryEntry[]> OnPurgeDeadEntries(System.Collections.Generic.IEnumerable<TetraPak.Caching.ITimeLimitedRepositoryEntry> entries);
```
#### Parameters
<a name='TetraPak_Caching_SimpleCache_OnPurgeDeadEntries(System_Collections_Generic_IEnumerable_TetraPak_Caching_ITimeLimitedRepositoryEntry_)_entries'></a>
`entries` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[ITimeLimitedRepositoryEntry](TetraPak_Caching_ITimeLimitedRepositoryEntry.md 'TetraPak.Caching.ITimeLimitedRepositoryEntry')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A collection of entries that should be examined.   
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[ITimeLimitedRepositoryEntry](TetraPak_Caching_ITimeLimitedRepositoryEntry.md 'TetraPak.Caching.ITimeLimitedRepositoryEntry')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A collection of entries that should be removed.  
  
<a name='TetraPak_Caching_SimpleCache_OnPurgeDeadEntriesAsync()'></a>
## SimpleCache.OnPurgeDeadEntriesAsync() Method
Gets called automatically (in a background thread) to remove dead entries.   
```csharp
protected virtual System.Threading.Tasks.Task OnPurgeDeadEntriesAsync();
```
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
  
<a name='TetraPak_Caching_SimpleCache_UpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)'></a>
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
(optional; default=[DefaultLifeSpan](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_DefaultLifeSpan 'TetraPak.Caching.ITimeLimitedRepositories.DefaultLifeSpan'))<br/>  
A custom lifespan for the value.  
  
<a name='TetraPak_Caching_SimpleCache_UpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_spawnTimeUtc'></a>
`spawnTimeUtc` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
(optional; default=[System.DateTime.UtcNow](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime.UtcNow 'System.DateTime.UtcNow'))<br/>  
Specifies the spawn time for the value.  
  
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
#### Exceptions
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
A value could not be identified from the specified [key](TetraPak_Caching_SimpleCache.md#TetraPak_Caching_SimpleCache_UpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_)_key 'TetraPak.Caching.SimpleCache.UpdateAsync(string, string, object, System.Nullable&lt;System.TimeSpan&gt;, System.Nullable&lt;System.DateTime&gt;).key').  

Implements [UpdateAsync(string, string, object, Nullable<TimeSpan>, Nullable<DateTime>)](TetraPak_Caching_ITimeLimitedRepositories.md#TetraPak_Caching_ITimeLimitedRepositories_UpdateAsync(string_string_object_System_Nullable_System_TimeSpan__System_Nullable_System_DateTime_) 'TetraPak.Caching.ITimeLimitedRepositories.UpdateAsync(string, string, object, System.Nullable&lt;System.TimeSpan&gt;, System.Nullable&lt;System.DateTime&gt;)')  
  
