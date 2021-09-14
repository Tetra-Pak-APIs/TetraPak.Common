#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching')
## ITimeLimitedRepositoryOptions Interface
Implementors of this class can represent options for an individual  
time limited repository.    
```csharp
public interface ITimeLimitedRepositoryOptions
```

Derived  
&#8627; [SimpleTimeLimitedRepositoryOptions](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions.md 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions')  
### Properties
<a name='TetraPak_Caching_ITimeLimitedRepositoryOptions_AdjustedLifeSpan'></a>
## ITimeLimitedRepositoryOptions.AdjustedLifeSpan Property
Gets a value that reduces the [LifeSpan](TetraPak_Caching_ITimeLimitedRepositoryOptions.md#TetraPak_Caching_ITimeLimitedRepositoryOptions_LifeSpan 'TetraPak.Caching.ITimeLimitedRepositoryOptions.LifeSpan') (and [ExtendedLifeSpan](TetraPak_Caching_ITimeLimitedRepositoryOptions.md#TetraPak_Caching_ITimeLimitedRepositoryOptions_ExtendedLifeSpan 'TetraPak.Caching.ITimeLimitedRepositoryOptions.ExtendedLifeSpan') when applicable).  
Use this value to create a "safe zone" for values that have themselves a limited lifetime  
(outside of the repository, such as access tokens), and that might expire within this time span.   
```csharp
System.TimeSpan AdjustedLifeSpan { get; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')
  
<a name='TetraPak_Caching_ITimeLimitedRepositoryOptions_ExtendedLifeSpan'></a>
## ITimeLimitedRepositoryOptions.ExtendedLifeSpan Property
Gets a lifespan to be re-applied to a value as it is being read from the cache, extending its life span.  
```csharp
System.TimeSpan ExtendedLifeSpan { get; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')
  
<a name='TetraPak_Caching_ITimeLimitedRepositoryOptions_LifeSpan'></a>
## ITimeLimitedRepositoryOptions.LifeSpan Property
Gets the life span for entries of the cache repository.  
```csharp
System.TimeSpan LifeSpan { get; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')
  
<a name='TetraPak_Caching_ITimeLimitedRepositoryOptions_MaxLifeSpan'></a>
## ITimeLimitedRepositoryOptions.MaxLifeSpan Property
Gets the maximum total lifespan allowed for any cached value  
within a cache repository. Setting this to anything other than zero will limit the  
total lifespan of cached values to unlimited lifespan due to dynamic lifespan extension  
when reading/updating values (see [ExtendedLifeSpan](TetraPak_Caching_ITimeLimitedRepositoryOptions.md#TetraPak_Caching_ITimeLimitedRepositoryOptions_ExtendedLifeSpan 'TetraPak.Caching.ITimeLimitedRepositoryOptions.ExtendedLifeSpan')).  
```csharp
System.TimeSpan MaxLifeSpan { get; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')
  
