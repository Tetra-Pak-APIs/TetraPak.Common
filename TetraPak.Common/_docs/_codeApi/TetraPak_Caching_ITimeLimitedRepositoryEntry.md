#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching')
## ITimeLimitedRepositoryEntry Interface
Implementors of this class can represent individual time limited repository entries.   
```csharp
public interface ITimeLimitedRepositoryEntry
```
### Properties
<a name='TetraPak_Caching_ITimeLimitedRepositoryEntry_Key'></a>
## ITimeLimitedRepositoryEntry.Key Property
A key identifying the value to be stored within the time limited repository.   
```csharp
string Key { get; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
  
<a name='TetraPak_Caching_ITimeLimitedRepositoryEntry_Repository'></a>
## ITimeLimitedRepositoryEntry.Repository Property
The name of the repository.  
```csharp
string Repository { get; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
  
