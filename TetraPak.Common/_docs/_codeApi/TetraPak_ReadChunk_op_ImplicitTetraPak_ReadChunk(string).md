#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[ReadChunk](TetraPak_ReadChunk.md 'TetraPak.ReadChunk')
## ReadChunk.implicit operator ReadChunk(string) Operator
Implicitly converts a string literal into a [ReadChunk](TetraPak_ReadChunk.md 'TetraPak.ReadChunk').  
```csharp
public static TetraPak.ReadChunk implicit operator ReadChunk(string stringValue);
```
#### Parameters
<a name='TetraPak_ReadChunk_op_ImplicitTetraPak_ReadChunk(string)_stringValue'></a>
`stringValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string representation of the [ReadChunk](TetraPak_ReadChunk.md 'TetraPak.ReadChunk') value.  
  
#### Returns
[ReadChunk](TetraPak_ReadChunk.md 'TetraPak.ReadChunk')  
A [ReadChunk](TetraPak_ReadChunk.md 'TetraPak.ReadChunk') value.  
#### Exceptions
[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')  
The [stringValue](TetraPak_ReadChunk_op_ImplicitTetraPak_ReadChunk(string).md#TetraPak_ReadChunk_op_ImplicitTetraPak_ReadChunk(string)_stringValue 'TetraPak.ReadChunk.op_Implicit TetraPak.ReadChunk(string).stringValue') string representation was incorrectly formed.  
