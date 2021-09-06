#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[BearerToken](TetraPak_BearerToken.md 'TetraPak.BearerToken')
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
[s](TetraPak_BearerToken_Parse(string).md#TetraPak_BearerToken_Parse(string)_s 'TetraPak.BearerToken.Parse(string).s') is `null`.  
            
[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')  
[s](TetraPak_BearerToken_Parse(string).md#TetraPak_BearerToken_Parse(string)_s 'TetraPak.BearerToken.Parse(string).s') is not in the correct format.  
            
