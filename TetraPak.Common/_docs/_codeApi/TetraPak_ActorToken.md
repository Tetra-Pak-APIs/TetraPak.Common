#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak')
## ActorToken Class
```csharp
public class ActorToken : TetraPak.Credentials,
TetraPak.IStringValue
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [DynamicEntity](TetraPak_DynamicEntities_DynamicEntity.md 'TetraPak.DynamicEntities.DynamicEntity') &#129106; [TetraPak.DynamicEntities.DynamicIdentifiableEntity&lt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.DynamicEntities.DynamicIdentifiableEntity-1 'TetraPak.DynamicEntities.DynamicIdentifiableEntity`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.DynamicEntities.DynamicIdentifiableEntity-1 'TetraPak.DynamicEntities.DynamicIdentifiableEntity`1') &#129106; [Credentials](TetraPak_Credentials.md 'TetraPak.Credentials') &#129106; ActorToken  

Derived  
&#8627; [BearerToken](TetraPak_BearerToken.md 'TetraPak.BearerToken')  

Implements [IStringValue](TetraPak_IStringValue.md 'TetraPak.IStringValue')  

| Properties | |
| :--- | :--- |
| [StringValue](TetraPak_ActorToken_StringValue.md 'TetraPak.ActorToken.StringValue') | The value's string representation.<br/> |

| Methods | |
| :--- | :--- |
| [OnTryParse(string, string)](TetraPak_ActorToken_OnTryParse(string_string).md 'TetraPak.ActorToken.OnTryParse(string, string)') | Attempts parsing the value. <br/> |
| [ToJwtSecurityToken()](TetraPak_ActorToken_ToJwtSecurityToken().md 'TetraPak.ActorToken.ToJwtSecurityToken()') | Returns the token as a [ToJwtSecurityToken()](TetraPak_ActorToken_ToJwtSecurityToken().md 'TetraPak.ActorToken.ToJwtSecurityToken()') (if applicable).<br/> |
| [TryParse(string, ActorToken)](TetraPak_ActorToken_TryParse(string_TetraPak_ActorToken).md 'TetraPak.ActorToken.TryParse(string, TetraPak.ActorToken)') | Converts the string representation of a token.<br/>A return value indicates whether the conversion succeeded.<br/> |
