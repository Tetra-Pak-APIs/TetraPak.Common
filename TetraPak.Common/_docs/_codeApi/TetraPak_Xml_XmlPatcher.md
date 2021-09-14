#### [TetraPak.Common](index.md 'index')
### [TetraPak.Xml](TetraPak_Xml.md 'TetraPak.Xml')
## XmlPatcher Class
Supports convenient XML patching capabilities.  
```csharp
public class XmlPatcher
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; XmlPatcher  
### Methods
<a name='TetraPak_Xml_XmlPatcher_CopyValue(string_System_Collections_Generic_IEnumerable_string__TetraPak_Xml_ValueEventDelegate_bool)'></a>
## XmlPatcher.CopyValue(string, IEnumerable&lt;string&gt;, ValueEventDelegate, bool) Method
Copies a specified value to one or more target nodes.  
```csharp
public System.Threading.Tasks.Task<TetraPak.Outcome<TetraPak.Xml.XmlPatcher>> CopyValue(string source, System.Collections.Generic.IEnumerable<string> targets, TetraPak.Xml.ValueEventDelegate copyDelegate=null, bool failOnTargetNotFound=true);
```
#### Parameters
<a name='TetraPak_Xml_XmlPatcher_CopyValue(string_System_Collections_Generic_IEnumerable_string__TetraPak_Xml_ValueEventDelegate_bool)_source'></a>
`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Identifies (XPath) the value to be copied.  
  
<a name='TetraPak_Xml_XmlPatcher_CopyValue(string_System_Collections_Generic_IEnumerable_string__TetraPak_Xml_ValueEventDelegate_bool)_targets'></a>
`targets` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
Identifies (XPath) the nodes to copy the value to.  
  
<a name='TetraPak_Xml_XmlPatcher_CopyValue(string_System_Collections_Generic_IEnumerable_string__TetraPak_Xml_ValueEventDelegate_bool)_copyDelegate'></a>
`copyDelegate` [TetraPak.Xml.ValueEventDelegate](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Xml.ValueEventDelegate 'TetraPak.Xml.ValueEventDelegate')  
(optional)<br/>  
A delegate for custom processing. The delegate should set the [TetraPak.Xml](TetraPak_Xml.md 'TetraPak.Xml')
  
<a name='TetraPak_Xml_XmlPatcher_CopyValue(string_System_Collections_Generic_IEnumerable_string__TetraPak_Xml_ValueEventDelegate_bool)_failOnTargetNotFound'></a>
`failOnTargetNotFound` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
(optional; default=`true`)<br/>  
Specifies whether to abort the patching process if one target cannot be found.  
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TetraPak.Outcome&lt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')[XmlPatcher](TetraPak_Xml_XmlPatcher.md 'TetraPak.Xml.XmlPatcher')[&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
An [Outcome&lt;T&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;') value to indicate success/failure.  
  
<a name='TetraPak_Xml_XmlPatcher_LoadAsync(string_System_Threading_CancellationToken)'></a>
## XmlPatcher.LoadAsync(string, CancellationToken) Method
Loads an XML document into a new [XmlPatcher](TetraPak_Xml_XmlPatcher.md 'TetraPak.Xml.XmlPatcher') instance, ready to be patched.  
```csharp
public static System.Threading.Tasks.Task<TetraPak.Outcome<TetraPak.Xml.XmlPatcher>> LoadAsync(string path, System.Threading.CancellationToken cancellationToken);
```
#### Parameters
<a name='TetraPak_Xml_XmlPatcher_LoadAsync(string_System_Threading_CancellationToken)_path'></a>
`path` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The path to the XML document to be patched.  
  
<a name='TetraPak_Xml_XmlPatcher_LoadAsync(string_System_Threading_CancellationToken)_cancellationToken'></a>
`cancellationToken` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')  
A [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken'), allowing the asynchronous load operation to be cancelled.  
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TetraPak.Outcome&lt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')[XmlPatcher](TetraPak_Xml_XmlPatcher.md 'TetraPak.Xml.XmlPatcher')[&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A [Outcome&lt;T&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;') instance to indicate success/failure.  
#### See Also
- [SaveAsync(CancellationToken, string)](TetraPak_Xml_XmlPatcher.md#TetraPak_Xml_XmlPatcher_SaveAsync(System_Threading_CancellationToken_string) 'TetraPak.Xml.XmlPatcher.SaveAsync(System.Threading.CancellationToken, string)')
  
<a name='TetraPak_Xml_XmlPatcher_SaveAsync(System_Threading_CancellationToken_string)'></a>
## XmlPatcher.SaveAsync(CancellationToken, string) Method
Saves the patched XML document.  
```csharp
public System.Threading.Tasks.Task<TetraPak.Outcome<TetraPak.Xml.XmlPatcher>> SaveAsync(System.Threading.CancellationToken cancellationToken, string path=null);
```
#### Parameters
<a name='TetraPak_Xml_XmlPatcher_SaveAsync(System_Threading_CancellationToken_string)_cancellationToken'></a>
`cancellationToken` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')  
A [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken'), allowing the asynchronous save operation to be cancelled.  
  
<a name='TetraPak_Xml_XmlPatcher_SaveAsync(System_Threading_CancellationToken_string)_path'></a>
`path` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
(optional; default=the path used to load the document)<br/>  
The path to the XML document to be saved.  
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TetraPak.Outcome&lt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')[XmlPatcher](TetraPak_Xml_XmlPatcher.md 'TetraPak.Xml.XmlPatcher')[&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A [Outcome&lt;T&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;') instance to indicate success/failure.  
  
