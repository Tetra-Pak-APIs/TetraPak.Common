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
### Properties
<a name='TetraPak_ActorToken_StringValue'></a>
## ActorToken.StringValue Property
The value's string representation.  
```csharp
public string StringValue { get; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Implements [StringValue](TetraPak_IStringValue.md#TetraPak_IStringValue_StringValue 'TetraPak.IStringValue.StringValue')  
  
### Methods
<a name='TetraPak_ActorToken_OnTryParse(string_string)'></a>
## ActorToken.OnTryParse(string, string) Method
Attempts parsing the value.   
```csharp
protected virtual bool OnTryParse(string value, out string identity);
```
#### Parameters
<a name='TetraPak_ActorToken_OnTryParse(string_string)_value'></a>
`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The value to be parsed.  
  
<a name='TetraPak_ActorToken_OnTryParse(string_string)_identity'></a>
`identity` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Passes back the identity (token).  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if parsing was successful; otherwise `false`.  
            
  
<a name='TetraPak_ActorToken_ToJwtSecurityToken()'></a>
## ActorToken.ToJwtSecurityToken() Method
Returns the token as a [ToJwtSecurityToken()](TetraPak_ActorToken.md#TetraPak_ActorToken_ToJwtSecurityToken() 'TetraPak.ActorToken.ToJwtSecurityToken()') (if applicable).  
```csharp
public System.IdentityModel.Tokens.Jwt.JwtSecurityToken ToJwtSecurityToken();
```
#### Returns
[System.IdentityModel.Tokens.Jwt.JwtSecurityToken](https://docs.microsoft.com/en-us/dotnet/api/System.IdentityModel.Tokens.Jwt.JwtSecurityToken 'System.IdentityModel.Tokens.Jwt.JwtSecurityToken')  
A [ToJwtSecurityToken()](TetraPak_ActorToken.md#TetraPak_ActorToken_ToJwtSecurityToken() 'TetraPak.ActorToken.ToJwtSecurityToken()') if the token has that form; otherwise `null`.  
  
<a name='TetraPak_ActorToken_TryParse(string_TetraPak_ActorToken)'></a>
## ActorToken.TryParse(string, ActorToken) Method
Converts the string representation of a token.  
A return value indicates whether the conversion succeeded.  
```csharp
public static bool TryParse(string s, out TetraPak.ActorToken token);
```
#### Parameters
<a name='TetraPak_ActorToken_TryParse(string_TetraPak_ActorToken)_s'></a>
`s` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string containing a token to convert.  
  
<a name='TetraPak_ActorToken_TryParse(string_TetraPak_ActorToken)_token'></a>
`token` [ActorToken](TetraPak_ActorToken.md 'TetraPak.ActorToken')  
When this method returns, contains the token equivalent of the value contained in [s](TetraPak_ActorToken.md#TetraPak_ActorToken_TryParse(string_TetraPak_ActorToken)_s 'TetraPak.ActorToken.TryParse(string, TetraPak.ActorToken).s'),  
if the conversion succeeded, or null if the conversion failed.  
The conversion fails if the s parameter is null or Empty, or is not of the correct format.  
This parameter is passed uninitialized; any value originally supplied in result will be overwritten.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if [s](TetraPak_ActorToken.md#TetraPak_ActorToken_TryParse(string_TetraPak_ActorToken)_s 'TetraPak.ActorToken.TryParse(string, TetraPak.ActorToken).s') was converted successfully; otherwise, `false`.  
            
  
