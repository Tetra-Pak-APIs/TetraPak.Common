#### [TetraPak.Common](index.md 'index')
### [TetraPak.DynamicEntities](TetraPak_DynamicEntities.md 'TetraPak.DynamicEntities').[DynamicPath](TetraPak_DynamicEntities_DynamicPath.md 'TetraPak.DynamicEntities.DynamicPath')
## DynamicPath.implicit operator DynamicPath(string) Operator
Implicitly converts a string literal into a [DynamicPath](TetraPak_DynamicEntities_DynamicPath.md 'TetraPak.DynamicEntities.DynamicPath').  
```csharp
public static TetraPak.DynamicEntities.DynamicPath implicit operator DynamicPath(string stringValue);
```
#### Parameters
<a name='TetraPak_DynamicEntities_DynamicPath_op_ImplicitTetraPak_DynamicEntities_DynamicPath(string)_stringValue'></a>
`stringValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string representation of the [DynamicPath](TetraPak_DynamicEntities_DynamicPath.md 'TetraPak.DynamicEntities.DynamicPath') value.  
  
#### Returns
[DynamicPath](TetraPak_DynamicEntities_DynamicPath.md 'TetraPak.DynamicEntities.DynamicPath')  
A [DynamicPath](TetraPak_DynamicEntities_DynamicPath.md 'TetraPak.DynamicEntities.DynamicPath') value.  
#### Exceptions
[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')  
The [stringValue](TetraPak_DynamicEntities_DynamicPath_op_ImplicitTetraPak_DynamicEntities_DynamicPath(string).md#TetraPak_DynamicEntities_DynamicPath_op_ImplicitTetraPak_DynamicEntities_DynamicPath(string)_stringValue 'TetraPak.DynamicEntities.DynamicPath.op_Implicit TetraPak.DynamicEntities.DynamicPath(string).stringValue') string representation was incorrectly formed.  
