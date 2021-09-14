#### [TetraPak.Common](index.md 'index')
### [TetraPak.Xml](TetraPak_Xml.md 'TetraPak.Xml')
## XElementValueEventArgs Class
```csharp
public class XElementValueEventArgs : System.EventArgs
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.EventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.EventArgs 'System.EventArgs') &#129106; XElementValueEventArgs  
### Properties
<a name='TetraPak_Xml_XElementValueEventArgs_Action'></a>
## XElementValueEventArgs.Action Property
Gets or sets an action to be performed by the operation after the delegate is has run.  
The delegate should set this value to [TetraPak.Xml.XElementAction.None](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Xml.XElementAction.None 'TetraPak.Xml.XElementAction.None') to indicate  
no further processing by the invoker.   
```csharp
public TetraPak.Xml.XElementAction Action { get; set; }
```
#### Property Value
[TetraPak.Xml.XElementAction](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Xml.XElementAction 'TetraPak.Xml.XElementAction')
  
<a name='TetraPak_Xml_XElementValueEventArgs_SourceElement'></a>
## XElementValueEventArgs.SourceElement Property
The source [System.Xml.Linq.XElement](https://docs.microsoft.com/en-us/dotnet/api/System.Xml.Linq.XElement 'System.Xml.Linq.XElement') for the process.  
```csharp
public System.Xml.Linq.XElement SourceElement { get; }
```
#### Property Value
[System.Xml.Linq.XElement](https://docs.microsoft.com/en-us/dotnet/api/System.Xml.Linq.XElement 'System.Xml.Linq.XElement')
  
<a name='TetraPak_Xml_XElementValueEventArgs_TargetElement'></a>
## XElementValueEventArgs.TargetElement Property
The intended target [System.Xml.Linq.XElement](https://docs.microsoft.com/en-us/dotnet/api/System.Xml.Linq.XElement 'System.Xml.Linq.XElement') for the process.  
```csharp
public System.Xml.Linq.XElement TargetElement { get; }
```
#### Property Value
[System.Xml.Linq.XElement](https://docs.microsoft.com/en-us/dotnet/api/System.Xml.Linq.XElement 'System.Xml.Linq.XElement')
  
<a name='TetraPak_Xml_XElementValueEventArgs_Value'></a>
## XElementValueEventArgs.Value Property
The value to be processed.  
```csharp
public string Value { get; set; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
  
