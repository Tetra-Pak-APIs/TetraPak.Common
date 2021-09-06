#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching').[SimpleTimeLimitedRepositoryOptions](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions.md 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions')
## SimpleTimeLimitedRepositoryOptions.AdjustedLifeSpan Property
Gets or sets a value that always adjusts the [LifeSpan](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_LifeSpan.md 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions.LifeSpan')  
(and [ExtendedLifeSpan](TetraPak_Caching_SimpleTimeLimitedRepositoryOptions_ExtendedLifeSpan.md 'TetraPak.Caching.SimpleTimeLimitedRepositoryOptions.ExtendedLifeSpan') when applicable).  
This value can be used to always increase or decrease the lifespan values.  
```csharp
public System.TimeSpan AdjustedLifeSpan { get; set; }
```
#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')

Implements [AdjustedLifeSpan](TetraPak_Caching_ITimeLimitedRepositoryOptions_AdjustedLifeSpan.md 'TetraPak.Caching.ITimeLimitedRepositoryOptions.AdjustedLifeSpan')  
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
