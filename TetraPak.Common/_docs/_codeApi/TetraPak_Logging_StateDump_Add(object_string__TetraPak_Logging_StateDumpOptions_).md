#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging').[StateDump](TetraPak_Logging_StateDump.md 'TetraPak.Logging.StateDump')
## StateDump.Add(object, string?, StateDumpOptions?) Method
Adds an object (a "[source](TetraPak_Logging_StateDump_Add(object_string__TetraPak_Logging_StateDumpOptions_).md#TetraPak_Logging_StateDump_Add(object_string__TetraPak_Logging_StateDumpOptions_)_source 'TetraPak.Logging.StateDump.Add(object, string?, TetraPak.Logging.StateDumpOptions?).source')) to the state dump.  
```csharp
public void Add(object source, string? name=null, TetraPak.Logging.StateDumpOptions? options=null);
```
#### Parameters
<a name='TetraPak_Logging_StateDump_Add(object_string__TetraPak_Logging_StateDumpOptions_)_source'></a>
`source` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The object to be added.  
  
<a name='TetraPak_Logging_StateDump_Add(object_string__TetraPak_Logging_StateDumpOptions_)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
(optional; default = [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') of [source](TetraPak_Logging_StateDump_Add(object_string__TetraPak_Logging_StateDumpOptions_).md#TetraPak_Logging_StateDump_Add(object_string__TetraPak_Logging_StateDumpOptions_)_source 'TetraPak.Logging.StateDump.Add(object, string?, TetraPak.Logging.StateDumpOptions?).source'))<br/>  
A name for the source.   
  
<a name='TetraPak_Logging_StateDump_Add(object_string__TetraPak_Logging_StateDumpOptions_)_options'></a>
`options` [StateDumpOptions](TetraPak_Logging_StateDumpOptions.md 'TetraPak.Logging.StateDumpOptions')  
(optional)<br/>  
Specifies options for dumping the state of [source](TetraPak_Logging_StateDump_Add(object_string__TetraPak_Logging_StateDumpOptions_).md#TetraPak_Logging_StateDump_Add(object_string__TetraPak_Logging_StateDumpOptions_)_source 'TetraPak.Logging.StateDump.Add(object, string?, TetraPak.Logging.StateDumpOptions?).source').  
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[source](TetraPak_Logging_StateDump_Add(object_string__TetraPak_Logging_StateDumpOptions_).md#TetraPak_Logging_StateDump_Add(object_string__TetraPak_Logging_StateDumpOptions_)_source 'TetraPak.Logging.StateDump.Add(object, string?, TetraPak.Logging.StateDumpOptions?).source') was unassigned.  
            
#### See Also
- [StateDumpOptions](TetraPak_Logging_StateDumpOptions.md 'TetraPak.Logging.StateDumpOptions')
- [RestrictedValueAttribute](TetraPak_RestrictedValueAttribute.md 'TetraPak.RestrictedValueAttribute')
