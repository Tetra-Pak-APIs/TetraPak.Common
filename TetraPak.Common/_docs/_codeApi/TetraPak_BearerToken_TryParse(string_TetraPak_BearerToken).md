#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[BearerToken](TetraPak_BearerToken.md 'TetraPak.BearerToken')
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
When this method returns, contains the token equivalent of the value contained in [s](TetraPak_BearerToken_TryParse(string_TetraPak_BearerToken).md#TetraPak_BearerToken_TryParse(string_TetraPak_BearerToken)_s 'TetraPak.BearerToken.TryParse(string, TetraPak.BearerToken).s'),  
if the conversion succeeded, or null if the conversion failed.  
The conversion fails if the s parameter is null or Empty, or is not of the correct format.  
This parameter is passed uninitialized; any value originally supplied in result will be overwritten.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if [s](TetraPak_BearerToken_TryParse(string_TetraPak_BearerToken).md#TetraPak_BearerToken_TryParse(string_TetraPak_BearerToken)_s 'TetraPak.BearerToken.TryParse(string, TetraPak.BearerToken).s') was converted successfully; otherwise, `false`.  
            
