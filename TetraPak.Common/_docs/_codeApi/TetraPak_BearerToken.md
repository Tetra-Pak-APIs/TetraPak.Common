#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak')
## BearerToken Class
Represents a bearer token (a token with 'Bearer ' prefix).  
```csharp
public class BearerToken : TetraPak.ActorToken
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [DynamicEntity](TetraPak_DynamicEntities_DynamicEntity.md 'TetraPak.DynamicEntities.DynamicEntity') &#129106; [TetraPak.DynamicEntities.DynamicIdentifiableEntity&lt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.DynamicEntities.DynamicIdentifiableEntity-1 'TetraPak.DynamicEntities.DynamicIdentifiableEntity`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.DynamicEntities.DynamicIdentifiableEntity-1 'TetraPak.DynamicEntities.DynamicIdentifiableEntity`1') &#129106; [Credentials](TetraPak_Credentials.md 'TetraPak.Credentials') &#129106; [ActorToken](TetraPak_ActorToken.md 'TetraPak.ActorToken') &#129106; BearerToken  

| Methods | |
| :--- | :--- |
| [Parse(string)](TetraPak_BearerToken_Parse(string).md 'TetraPak.BearerToken.Parse(string)') | Converts the string representation of a bearer token to its [BearerToken](TetraPak_BearerToken.md 'TetraPak.BearerToken') equivalent.<br/> |
| [TryParse(string, BearerToken)](TetraPak_BearerToken_TryParse(string_TetraPak_BearerToken).md 'TetraPak.BearerToken.TryParse(string, TetraPak.BearerToken)') | Converts the string representation of a bearer token.<br/>A return value indicates whether the conversion succeeded.<br/> |
