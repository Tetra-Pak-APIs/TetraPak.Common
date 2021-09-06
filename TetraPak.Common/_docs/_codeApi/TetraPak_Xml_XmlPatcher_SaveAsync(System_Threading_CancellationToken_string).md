#### [TetraPak.Common](index.md 'index')
### [TetraPak.Xml](TetraPak_Xml.md 'TetraPak.Xml').[XmlPatcher](TetraPak_Xml_XmlPatcher.md 'TetraPak.Xml.XmlPatcher')
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
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TetraPak.Outcome&lt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Outcome-1 'TetraPak.Outcome`1')[XmlPatcher](TetraPak_Xml_XmlPatcher.md 'TetraPak.Xml.XmlPatcher')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Outcome-1 'TetraPak.Outcome`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A [TetraPak.Outcome&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Outcome-1 'TetraPak.Outcome`1') instance to indicate success/failure.  
