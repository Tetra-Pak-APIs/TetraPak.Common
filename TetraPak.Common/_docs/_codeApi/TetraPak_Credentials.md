#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak')
## Credentials Class
Represents a generic credentials value, typically used for authentication use purposes.  
```csharp
public class Credentials : TetraPak.DynamicEntities.DynamicIdentifiableEntity<string>,
System.IDisposable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [DynamicEntity](TetraPak_DynamicEntities_DynamicEntity.md 'TetraPak.DynamicEntities.DynamicEntity') &#129106; [TetraPak.DynamicEntities.DynamicIdentifiableEntity&lt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.DynamicEntities.DynamicIdentifiableEntity-1 'TetraPak.DynamicEntities.DynamicIdentifiableEntity`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.DynamicEntities.DynamicIdentifiableEntity-1 'TetraPak.DynamicEntities.DynamicIdentifiableEntity`1') &#129106; Credentials  

Derived  
&#8627; [ActorToken](TetraPak_ActorToken.md 'TetraPak.ActorToken')  

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')  

| Constructors | |
| :--- | :--- |
| [Credentials()](TetraPak_Credentials_Credentials().md 'TetraPak.Credentials.Credentials()') | Initializes the [Credentials](TetraPak_Credentials.md 'TetraPak.Credentials') value.<br/> |
| [Credentials(string, string, string)](TetraPak_Credentials_Credentials(string_string_string).md 'TetraPak.Credentials.Credentials(string, string, string)') | Initializes the [Credentials](TetraPak_Credentials.md 'TetraPak.Credentials') value.<br/> |

| Properties | |
| :--- | :--- |
| [Identity](TetraPak_Credentials_Identity.md 'TetraPak.Credentials.Identity') | Gets or sets the credentials identity element.<br/> |
| [IsAssigned](TetraPak_Credentials_IsAssigned.md 'TetraPak.Credentials.IsAssigned') | Gets a value indicating whether the credentials are assigned.<br/> |
| [NewSecret](TetraPak_Credentials_NewSecret.md 'TetraPak.Credentials.NewSecret') | Gets or sets a new credentials secret/password element.<br/> |
| [Secret](TetraPak_Credentials_Secret.md 'TetraPak.Credentials.Secret') | Gets or sets the credentials secret/password element.<br/> |

| Methods | |
| :--- | :--- |
| [CloneWithoutSecrets()](TetraPak_Credentials_CloneWithoutSecrets().md 'TetraPak.Credentials.CloneWithoutSecrets()') | Clones the entity without any secrets, to support scenarios where secrets are not necessary.<br/> |
| [Dispose()](TetraPak_Credentials_Dispose().md 'TetraPak.Credentials.Dispose()') | Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources. |
