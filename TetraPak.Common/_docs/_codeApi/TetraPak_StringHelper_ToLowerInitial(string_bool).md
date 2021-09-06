#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[StringHelper](TetraPak_StringHelper.md 'TetraPak.StringHelper')
## StringHelper.ToLowerInitial(string, bool) Method
Ensures the first letter in the string is lowercase.  
```csharp
public static string ToLowerInitial(this string self, bool findFirstLetter=false);
```
#### Parameters
<a name='TetraPak_StringHelper_ToLowerInitial(string_bool)_self'></a>
`self` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string to be transformed.  
  
<a name='TetraPak_StringHelper_ToLowerInitial(string_bool)_findFirstLetter'></a>
`findFirstLetter` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
(optional; default = `false`)<br/>  
When set; the first occurence if a letter is automatically found (and transformed).   
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The transformed string.  
