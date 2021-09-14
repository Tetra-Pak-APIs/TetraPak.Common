#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching')
## SimpleTimeLimitedRepositoryOptions Class
Represents configuration for a named cache repository.  
```csharp
public class SimpleTimeLimitedRepositoryOptions : TetraPak.Configuration.ConfigurationSection,
TetraPak.Caching.ITimeLimitedRepositoryOptions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [ConfigurationSection](TetraPak_Configuration_ConfigurationSection.md 'TetraPak.Configuration.ConfigurationSection') &#129106; SimpleTimeLimitedRepositoryOptions  

Implements [ITimeLimitedRepositoryOptions](TetraPak_Caching_ITimeLimitedRepositoryOptions.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions')  
### Properties
<a name='TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_AdjustedLifeSpan'></a>
## SimpleTimeLimitedRepositoryOptions.AdjustedLifeSpan Property
Gets or sets a value that always adjusts the [LifeSpan](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions.md#TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_LifeSpan 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions.LifeSpan')  
(and [ExtendedLifeSpan](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions.md#TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_ExtendedLifeSpan 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions.ExtendedLifeSpan') when applicable).  
This value can be used to always increase or decrease the lifespan values.  
```csharp
public System.TimeSpan AdjustedLifeSpan { get; set; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')

Implements [AdjustedLifeSpan](TetraPak_Caching_ITimeLimitedRepositoryOptions.md#TetraPak_Caching_ITimeLimitedRepositoryOptions_AdjustedLifeSpan 'TetraPak.Caching.ITimeLimitedRepositoryOptions.AdjustedLifeSpan')  
### Remarks
One typical application for this is to create a "safe zone" for values that themselves  
have a limited lifetime (outside of the repository),  
and that might expire within this time span, before they can be consumed.



  
Consider, for example, cached security tokens. Those are typically intended to be used  
when consuming remote services, such as APIs. Depending on network load/capacity you might see  
that after your code retrieves a cached token for your request to the service that validates the  
token needs some extra seconds. If the token is about to expire in, say, three seconds, and your call  
takes that (or more) time to get through to the remote service, the token will not be accepted by that  
service. In those scenarios it is usually a good idea to simply decrease the lifespan of such tokens  
with a few seconds to discard the cached (about to expire) security token  
and force acquiring of a new one.   
  
<a name='TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_ExtendedLifeSpan'></a>
## SimpleTimeLimitedRepositoryOptions.ExtendedLifeSpan Property
Gets or sets a value specifying a lifespan to be re-applied to a value as it is being  
read from the cache.  
```csharp
public System.TimeSpan ExtendedLifeSpan { get; set; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')

Implements [ExtendedLifeSpan](TetraPak_Caching_ITimeLimitedRepositoryOptions.md#TetraPak_Caching_ITimeLimitedRepositoryOptions_ExtendedLifeSpan 'TetraPak.Caching.ITimeLimitedRepositoryOptions.ExtendedLifeSpan')  
### Remarks
Set this value to an asterisk (*) to always renew by same value as [LifeSpan](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions.md#TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_LifeSpan 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions.LifeSpan').  
  
<a name='TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_LifeSpan'></a>
## SimpleTimeLimitedRepositoryOptions.LifeSpan Property
Gets or sets the life span for entries of the configured cache repository.  
```csharp
public System.TimeSpan LifeSpan { get; set; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')

Implements [LifeSpan](TetraPak_Caching_ITimeLimitedRepositoryOptions.md#TetraPak_Caching_ITimeLimitedRepositoryOptions_LifeSpan 'TetraPak.Caching.ITimeLimitedRepositoryOptions.LifeSpan')  
  
<a name='TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_MaxLifeSpan'></a>
## SimpleTimeLimitedRepositoryOptions.MaxLifeSpan Property
Gets or sets a value specifying the maximum total lifespan allowed for any cached value  
within a specific repository. Setting this to anything other than zero will limit the  
total lifespan of cached values to unlimited lifespan due to dynamic lifespan extension  
when reading/updating values (see [ExtendedLifeSpan](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions.md#TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_ExtendedLifeSpan 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions.ExtendedLifeSpan')).  
```csharp
public System.TimeSpan MaxLifeSpan { get; set; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')

Implements [MaxLifeSpan](TetraPak_Caching_ITimeLimitedRepositoryOptions.md#TetraPak_Caching_ITimeLimitedRepositoryOptions_MaxLifeSpan 'TetraPak.Caching.ITimeLimitedRepositoryOptions.MaxLifeSpan')  
  
<a name='TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_Zero'></a>
## SimpleTimeLimitedRepositoryOptions.Zero Property
Returns a configuration with all values initialized to [System.TimeSpan.Zero](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan.Zero 'System.TimeSpan.Zero').  
```csharp
public static TetraPak.Caching.SimpleTimeLimitedRepositoryOptions Zero { get; }
```
#### Property Value
[SimpleTimeLimitedRepositoryOptions](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions.md 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions')
  
### Methods
<a name='TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_MergeFrom(TetraPak_Caching_ITimeLimitedRepositoryOptions)'></a>
## SimpleTimeLimitedRepositoryOptions.MergeFrom(ITimeLimitedRepositoryOptions) Method
Merges options with other options.  
```csharp
public void MergeFrom(TetraPak.Caching.ITimeLimitedRepositoryOptions options);
```
#### Parameters
<a name='TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_MergeFrom(TetraPak_Caching_ITimeLimitedRepositoryOptions)_options'></a>
`options` [ITimeLimitedRepositoryOptions](TetraPak_Caching_ITimeLimitedRepositoryOptions.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions')  
  
### Remarks
If [options](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions.md#TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_MergeFrom(TetraPak_Caching_ITimeLimitedRepositoryOptions)_options 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions.MergeFrom(TetraPak.Caching.ITimeLimitedRepositoryOptions).options') is a [ConfigurationSection](TetraPak_Configuration_ConfigurationSection.md 'TetraPak.Configuration.ConfigurationSection') only values  
that are assigned to property backing fields will be merged.  
  
<a name='TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_SetCache(TetraPak_Caching_SimpleCache)'></a>
## SimpleTimeLimitedRepositoryOptions.SetCache(SimpleCache) Method
Simply sets the internal reference to the parent [SimpleCache](TetraPak_Caching_SimpleCache.md 'TetraPak.Caching.SimpleCache') instance.  
```csharp
internal void SetCache(TetraPak.Caching.SimpleCache cache);
```
#### Parameters
<a name='TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_SetCache(TetraPak_Caching_SimpleCache)_cache'></a>
`cache` [SimpleCache](TetraPak_Caching_SimpleCache.md 'TetraPak.Caching.SimpleCache')  
The parent [SimpleCache](TetraPak_Caching_SimpleCache.md 'TetraPak.Caching.SimpleCache') instance.  
  
  
#### See Also
- [SimpleCache](TetraPak_Caching_SimpleCache.md 'TetraPak.Caching.SimpleCache')
- [SimpleCacheConfig](TetraPak_Caching_SimpleCacheConfig.md 'TetraPak.Caching.SimpleCacheConfig')
