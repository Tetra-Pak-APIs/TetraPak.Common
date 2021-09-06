#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching').[SimpleCache](TetraPak_Caching_SimpleCache.md 'TetraPak.Caching.SimpleCache')
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
