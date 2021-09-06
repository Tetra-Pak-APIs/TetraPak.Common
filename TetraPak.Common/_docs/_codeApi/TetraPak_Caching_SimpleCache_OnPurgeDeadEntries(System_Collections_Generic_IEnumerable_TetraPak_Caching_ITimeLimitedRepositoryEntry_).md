#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching').[SimpleCache](TetraPak_Caching_SimpleCache.md 'TetraPak.Caching.SimpleCache')
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
