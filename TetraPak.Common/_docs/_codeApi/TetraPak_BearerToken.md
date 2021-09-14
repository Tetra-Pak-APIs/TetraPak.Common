#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak')
## BearerToken Class
Represents a bearer token (a token with 'Bearer ' prefix).  
```csharp
public class BearerToken : TetraPak.ActorToken
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [DynamicEntity](TetraPak_DynamicEntities_DynamicEntity.md 'TetraPak.DynamicEntities.DynamicEntity') &#129106; [TetraPak.DynamicEntities.DynamicIdentifiableEntity&lt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.DynamicEntities.DynamicIdentifiableEntity-1 'TetraPak.DynamicEntities.DynamicIdentifiableEntity`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.DynamicEntities.DynamicIdentifiableEntity-1 'TetraPak.DynamicEntities.DynamicIdentifiableEntity`1') &#129106; [Credentials](TetraPak_Credentials.md 'TetraPak.Credentials') &#129106; [ActorToken](TetraPak_ActorToken.md 'TetraPak.ActorToken') &#129106; BearerToken  
### Methods
<a name='TetraPak_BearerToken_Parse(string)'></a>
## BearerToken.Parse(string) Method
Converts the string representation of a bearer token to its [BearerToken](TetraPak_BearerToken.md 'TetraPak.BearerToken') equivalent.  
```csharp
public static TetraPak.BearerToken Parse(string s);
```
#### Parameters
<a name='TetraPak_BearerToken_Parse(string)_s'></a>
`s` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string containing a token to convert.  
  
#### Returns
[BearerToken](TetraPak_BearerToken.md 'TetraPak.BearerToken')  
A [BearerToken](TetraPak_BearerToken.md 'TetraPak.BearerToken') equivalent to the value contained in s.  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[s](TetraPak_BearerToken.md#TetraPak_BearerToken_Parse(string)_s 'TetraPak.BearerToken.Parse(string).s') is `null`.  
            
[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')  
[s](TetraPak_BearerToken.md#TetraPak_BearerToken_Parse(string)_s 'TetraPak.BearerToken.Parse(string).s') is not in the correct format.  
            
  
<a name='TetraPak_BearerToken_TryParse(string_TetraPak_BearerToken)'></a>
## BearerToken.TryParse(string, BearerToken) Method
Converts the string representation of a bearer token.  
A return value indicates whether the conversion succeeded.  
```csharp
public static bool TryParse(string s, out TetraPak.BearerToken token);
```
#### Parameters
<a name='TetraPak_BearerToken_TryParse(string_TetraPak_BearerToken)_s'></a>
`s` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string containing a bearer token to convert.  
  
<a name='TetraPak_BearerToken_TryParse(string_TetraPak_BearerToken)_token'></a>
`token` [BearerToken](TetraPak_BearerToken.md 'TetraPak.BearerToken')  
When this method returns, contains the token equivalent of the value contained in [s](TetraPak_BearerToken.md#TetraPak_BearerToken_TryParse(string_TetraPak_BearerToken)_s 'TetraPak.BearerToken.TryParse(string, TetraPak.BearerToken).s'),  
if the conversion succeeded, or null if the conversion failed.  
The conversion fails if the s parameter is null or Empty, or is not of the correct format.  
This parameter is passed uninitialized; any value originally supplied in result will be overwritten.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if [s](TetraPak_BearerToken.md#TetraPak_BearerToken_TryParse(string_TetraPak_BearerToken)_s 'TetraPak.BearerToken.TryParse(string, TetraPak.BearerToken).s') was converted successfully; otherwise, `false`.  
            
  
