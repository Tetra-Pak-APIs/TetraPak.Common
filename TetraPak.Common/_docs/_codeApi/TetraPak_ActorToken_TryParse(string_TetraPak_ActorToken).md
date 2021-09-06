#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[ActorToken](TetraPak_ActorToken.md 'TetraPak.ActorToken')
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
When this method returns, contains the token equivalent of the value contained in [s](TetraPak_ActorToken_TryParse(string_TetraPak_ActorToken).md#TetraPak_ActorToken_TryParse(string_TetraPak_ActorToken)_s 'TetraPak.ActorToken.TryParse(string, TetraPak.ActorToken).s'),  
if the conversion succeeded, or null if the conversion failed.  
The conversion fails if the s parameter is null or Empty, or is not of the correct format.  
This parameter is passed uninitialized; any value originally supplied in result will be overwritten.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if [s](TetraPak_ActorToken_TryParse(string_TetraPak_ActorToken).md#TetraPak_ActorToken_TryParse(string_TetraPak_ActorToken)_s 'TetraPak.ActorToken.TryParse(string, TetraPak.ActorToken).s') was converted successfully; otherwise, `false`.  
            
