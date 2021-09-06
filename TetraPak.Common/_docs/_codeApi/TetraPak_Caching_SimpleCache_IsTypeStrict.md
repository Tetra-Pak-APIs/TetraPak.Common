#### [TetraPak.Common](index.md 'index')
### [TetraPak.Caching](TetraPak_Caching.md 'TetraPak.Caching').[SimpleCache](TetraPak_Caching_SimpleCache.md 'TetraPak.Caching.SimpleCache')
## SimpleCache.IsTypeStrict Property
Gets or sets a value specifying whether value types should be validated when updated.  
Attempts to update an existing value with a value that is type incompatible will  
throw an [IdentityConflictException](TetraPak_IdentityConflictException.md 'TetraPak.IdentityConflictException').   
```csharp
public bool IsTypeStrict { get; set; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Implements [IsTypeStrict](TetraPak_Caching_ITimeLimitedRepositories_IsTypeStrict.md 'TetraPak.Caching.ITimeLimitedRepositories.IsTypeStrict')  
