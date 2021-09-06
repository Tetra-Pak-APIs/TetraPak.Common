#### [TetraPak.Common](index.md 'index')
### [TetraPak.Xml](TetraPak_Xml.md 'TetraPak.Xml').[XmlPatcher](TetraPak_Xml_XmlPatcher.md 'TetraPak.Xml.XmlPatcher')
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
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TetraPak.Outcome&lt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Outcome-1 'TetraPak.Outcome`1')[XmlPatcher](TetraPak_Xml_XmlPatcher.md 'TetraPak.Xml.XmlPatcher')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Outcome-1 'TetraPak.Outcome`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
An [TetraPak.Outcome&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Outcome-1 'TetraPak.Outcome`1') value to indicate success/failure.  
