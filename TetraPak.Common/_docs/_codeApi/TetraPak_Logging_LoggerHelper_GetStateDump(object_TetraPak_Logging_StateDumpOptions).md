#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging').[LoggerHelper](TetraPak_Logging_LoggerHelper.md 'TetraPak.Logging.LoggerHelper')
## LoggerHelper.GetStateDump(object, StateDumpOptions) Method
Generates and returns a string to reflect the state of an object.  
```csharp
public static string GetStateDump(this object obj, TetraPak.Logging.StateDumpOptions options);
```
#### Parameters
<a name='TetraPak_Logging_LoggerHelper_GetStateDump(object_TetraPak_Logging_StateDumpOptions)_obj'></a>
`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The object.  
  
<a name='TetraPak_Logging_LoggerHelper_GetStateDump(object_TetraPak_Logging_StateDumpOptions)_options'></a>
`options` [StateDumpOptions](TetraPak_Logging_StateDumpOptions.md 'TetraPak.Logging.StateDumpOptions')  
Specifies how to render state from the specified object.   
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A JSON formatted string, reflecting the object's current state.  
#### See Also
- [RestrictedValueAttribute](TetraPak_RestrictedValueAttribute.md 'TetraPak.RestrictedValueAttribute')
