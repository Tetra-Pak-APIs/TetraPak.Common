#### [TetraPak.Common](index.md 'index')
### [TetraPak.Xml](TetraPak_Xml.md 'TetraPak.Xml').[XmlPatcher](TetraPak_Xml_XmlPatcher.md 'TetraPak.Xml.XmlPatcher')
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
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TetraPak.Outcome&lt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Outcome-1 'TetraPak.Outcome`1')[XmlPatcher](TetraPak_Xml_XmlPatcher.md 'TetraPak.Xml.XmlPatcher')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Outcome-1 'TetraPak.Outcome`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A [TetraPak.Outcome&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Outcome-1 'TetraPak.Outcome`1') instance to indicate success/failure.  
#### See Also
- [SaveAsync(CancellationToken, string)](TetraPak_Xml_XmlPatcher_SaveAsync(System_Threading_CancellationToken_string).md 'TetraPak.Xml.XmlPatcher.SaveAsync(System.Threading.CancellationToken, string)')
