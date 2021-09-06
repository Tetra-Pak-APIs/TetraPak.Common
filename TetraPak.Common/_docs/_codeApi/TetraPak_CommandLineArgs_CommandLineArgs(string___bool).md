#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[CommandLineArgs](TetraPak_CommandLineArgs.md 'TetraPak.CommandLineArgs')
## CommandLineArgs.CommandLineArgs(string[], bool) Constructor
Initializes the value.  
```csharp
public CommandLineArgs(string[] args, bool ignoreCase=false);
```
#### Parameters
<a name='TetraPak_CommandLineArgs_CommandLineArgs(string___bool)_args'></a>
`args` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The command line arguments to be represented as a value.  
  
<a name='TetraPak_CommandLineArgs_CommandLineArgs(string___bool)_ignoreCase'></a>
`ignoreCase` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
(optional; default=`false`)<br/>  
Specifies whether command line keys are case sensitive when looking up values (see [Get(string[])](TetraPak_CommandLineArgs_Get(string__).md 'TetraPak.CommandLineArgs.Get(string[])')).  
  
#### Exceptions
[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')  
The [args](TetraPak_CommandLineArgs_CommandLineArgs(string___bool).md#TetraPak_CommandLineArgs_CommandLineArgs(string___bool)_args 'TetraPak.CommandLineArgs.CommandLineArgs(string[], bool).args') string representation was incorrectly formed.  
