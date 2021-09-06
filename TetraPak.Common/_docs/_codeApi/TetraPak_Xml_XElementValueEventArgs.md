#### [TetraPak.Common](index.md 'index')
### [TetraPak.Xml](TetraPak_Xml.md 'TetraPak.Xml')
## XElementValueEventArgs Class
```csharp
public class XElementValueEventArgs : System.EventArgs
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.EventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.EventArgs 'System.EventArgs') &#129106; XElementValueEventArgs  

| Properties | |
| :--- | :--- |
| [Action](TetraPak_Xml_XElementValueEventArgs_Action.md 'TetraPak.Xml.XElementValueEventArgs.Action') | Gets or sets an action to be performed by the operation after the delegate is has run.<br/>The delegate should set this value to [TetraPak.Xml.XElementAction.None](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Xml.XElementAction.None 'TetraPak.Xml.XElementAction.None') to indicate<br/>no further processing by the invoker. <br/> |
| [SourceElement](TetraPak_Xml_XElementValueEventArgs_SourceElement.md 'TetraPak.Xml.XElementValueEventArgs.SourceElement') | The source [System.Xml.Linq.XElement](https://docs.microsoft.com/en-us/dotnet/api/System.Xml.Linq.XElement 'System.Xml.Linq.XElement') for the process.<br/> |
| [TargetElement](TetraPak_Xml_XElementValueEventArgs_TargetElement.md 'TetraPak.Xml.XElementValueEventArgs.TargetElement') | The intended target [System.Xml.Linq.XElement](https://docs.microsoft.com/en-us/dotnet/api/System.Xml.Linq.XElement 'System.Xml.Linq.XElement') for the process.<br/> |
| [Value](TetraPak_Xml_XElementValueEventArgs_Value.md 'TetraPak.Xml.XElementValueEventArgs.Value') | The value to be processed.<br/> |
