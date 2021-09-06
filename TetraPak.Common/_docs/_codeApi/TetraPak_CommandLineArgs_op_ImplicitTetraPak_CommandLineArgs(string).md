#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[CommandLineArgs](TetraPak_CommandLineArgs.md 'TetraPak.CommandLineArgs')
## CommandLineArgs.implicit operator CommandLineArgs(string) Operator
Implicitly converts a string literal into a [CommandLineArgs](TetraPak_CommandLineArgs.md 'TetraPak.CommandLineArgs').  
```csharp
public static TetraPak.CommandLineArgs implicit operator CommandLineArgs(string stringValue);
```
#### Parameters
<a name='TetraPak_CommandLineArgs_op_ImplicitTetraPak_CommandLineArgs(string)_stringValue'></a>
`stringValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string representation of the [CommandLineArgs](TetraPak_CommandLineArgs.md 'TetraPak.CommandLineArgs') value.  
  
#### Returns
[CommandLineArgs](TetraPak_CommandLineArgs.md 'TetraPak.CommandLineArgs')  
A [CommandLineArgs](TetraPak_CommandLineArgs.md 'TetraPak.CommandLineArgs') value.  
#### Exceptions
[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')  
The [stringValue](TetraPak_CommandLineArgs_op_ImplicitTetraPak_CommandLineArgs(string).md#TetraPak_CommandLineArgs_op_ImplicitTetraPak_CommandLineArgs(string)_stringValue 'TetraPak.CommandLineArgs.op_Implicit TetraPak.CommandLineArgs(string).stringValue') string representation was incorrectly formed.  
