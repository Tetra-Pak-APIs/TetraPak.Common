#### [TetraPak.Common](index.md 'index')
### [TetraPak.Logging](TetraPak_Logging.md 'TetraPak.Logging')
## StateDump Class
Assists in creating a well formatted state dump of one or more objects.  
```csharp
public class StateDump
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; StateDump  
### Methods
<a name='TetraPak_Logging_StateDump_Add(object_string__TetraPak_Logging_StateDumpOptions_)'></a>
## StateDump.Add(object, string?, StateDumpOptions?) Method
Adds an object (a "[source](TetraPak_Logging_StateDump.md#TetraPak_Logging_StateDump_Add(object_string__TetraPak_Logging_StateDumpOptions_)_source 'TetraPak.Logging.StateDump.Add(object, string?, TetraPak.Logging.StateDumpOptions?).source')) to the state dump.  
```csharp
public void Add(object source, string? name=null, TetraPak.Logging.StateDumpOptions? options=null);
```
#### Parameters
<a name='TetraPak_Logging_StateDump_Add(object_string__TetraPak_Logging_StateDumpOptions_)_source'></a>
`source` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The object to be added.  
  
<a name='TetraPak_Logging_StateDump_Add(object_string__TetraPak_Logging_StateDumpOptions_)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
(optional; default = [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') of [source](TetraPak_Logging_StateDump.md#TetraPak_Logging_StateDump_Add(object_string__TetraPak_Logging_StateDumpOptions_)_source 'TetraPak.Logging.StateDump.Add(object, string?, TetraPak.Logging.StateDumpOptions?).source'))<br/>  
A name for the source.   
  
<a name='TetraPak_Logging_StateDump_Add(object_string__TetraPak_Logging_StateDumpOptions_)_options'></a>
`options` [StateDumpOptions](TetraPak_Logging_StateDumpOptions.md 'TetraPak.Logging.StateDumpOptions')  
(optional)<br/>  
Specifies options for dumping the state of [source](TetraPak_Logging_StateDump.md#TetraPak_Logging_StateDump_Add(object_string__TetraPak_Logging_StateDumpOptions_)_source 'TetraPak.Logging.StateDump.Add(object, string?, TetraPak.Logging.StateDumpOptions?).source').  
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[source](TetraPak_Logging_StateDump.md#TetraPak_Logging_StateDump_Add(object_string__TetraPak_Logging_StateDumpOptions_)_source 'TetraPak.Logging.StateDump.Add(object, string?, TetraPak.Logging.StateDumpOptions?).source') was unassigned.  
            
#### See Also
- [StateDumpOptions](TetraPak_Logging_StateDumpOptions.md 'TetraPak.Logging.StateDumpOptions')
- [RestrictedValueAttribute](TetraPak_RestrictedValueAttribute.md 'TetraPak.RestrictedValueAttribute')
  
<a name='TetraPak_Logging_StateDump_ToString()'></a>
## StateDump.ToString() Method
Overrides the base method to also add a prefix and suffix to the state dump.  
```csharp
public override string ToString();
```
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') presenting the state dump, with a prefix/suffix pair for easy recognition.   
  
<a name='TetraPak_Logging_StateDump_ToString(string)'></a>
## StateDump.ToString(string) Method
Returns the [StateDump](TetraPak_Logging_StateDump.md 'TetraPak.Logging.StateDump')'s textual representation.  
```csharp
public string ToString(string caption);
```
#### Parameters
<a name='TetraPak_Logging_StateDump_ToString(string)_caption'></a>
`caption` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
(optional; default="STATE DUMP)<br/>  
A caption to be included in the state dump prefix and suffix elements.  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') presenting the state dump, with a prefix/suffix pair for easy recognition.   
  
<a name='TetraPak_Logging_StateDump_WithStackTrace(int)'></a>
## StateDump.WithStackTrace(int) Method
Invoking this method will have a [StateDump](TetraPak_Logging_StateDump.md 'TetraPak.Logging.StateDump') include a stacktrace.     
```csharp
public TetraPak.Logging.StateDump WithStackTrace(int skipFrames=1);
```
#### Parameters
<a name='TetraPak_Logging_StateDump_WithStackTrace(int)_skipFrames'></a>
`skipFrames` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
(optional; default = 1)<br/>  
Specifies how many stacktrace frames to be removed from the end of the stacktrace.  
This is to avoid including frames representing calls to the state dump logic itself.  
  
#### Returns
[StateDump](TetraPak_Logging_StateDump.md 'TetraPak.Logging.StateDump')  
This object (fluent API).  
  
#### See Also
- [RestrictedValueAttribute](TetraPak_RestrictedValueAttribute.md 'TetraPak.RestrictedValueAttribute')
