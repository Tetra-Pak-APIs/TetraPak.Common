#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[ActorToken](TetraPak_ActorToken.md 'TetraPak.ActorToken')
## ActorToken.ToJwtSecurityToken() Method
Returns the token as a [ToJwtSecurityToken()](TetraPak_ActorToken_ToJwtSecurityToken().md 'TetraPak.ActorToken.ToJwtSecurityToken()') (if applicable).  
```csharp
public System.IdentityModel.Tokens.Jwt.JwtSecurityToken ToJwtSecurityToken();
```
#### Returns
[System.IdentityModel.Tokens.Jwt.JwtSecurityToken](https://docs.microsoft.com/en-us/dotnet/api/System.IdentityModel.Tokens.Jwt.JwtSecurityToken 'System.IdentityModel.Tokens.Jwt.JwtSecurityToken')  
A [ToJwtSecurityToken()](TetraPak_ActorToken_ToJwtSecurityToken().md 'TetraPak.ActorToken.ToJwtSecurityToken()') if the token has that form; otherwise `null`.  
