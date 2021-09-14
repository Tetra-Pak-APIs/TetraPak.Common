#### [TetraPak.Common](index.md 'index')
### [TetraPak.Serialization](TetraPak_Serialization.md 'TetraPak.Serialization')
## KeyMapInfo Class
Contains a key map and other mapping settings.  
```csharp
public class KeyMapInfo
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; KeyMapInfo  
### Properties
<a name='TetraPak_Serialization_KeyMapInfo_IsStrict'></a>
## KeyMapInfo.IsStrict Property
Specifies whether to only include keys supported by the [Map](TetraPak_Serialization_KeyMapInfo.md#TetraPak_Serialization_KeyMapInfo_Map 'TetraPak.Serialization.KeyMapInfo.Map').  
```csharp
public bool IsStrict { get; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
  
<a name='TetraPak_Serialization_KeyMapInfo_Map'></a>
## KeyMapInfo.Map Property
A dictionary where each key corresponds to an incoming attribute name and each  
value the attribute name to be used instead.  
```csharp
public System.Collections.Generic.IDictionary<string,string> Map { get; }
```
#### Property Value
[System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')
  
