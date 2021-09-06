#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[DictionaryExtensions](TetraPak_DictionaryExtensions.md 'TetraPak.DictionaryExtensions')
## DictionaryExtensions.Map&lt;TValue&gt;(IDictionary&lt;string,TValue&gt;, IDictionary&lt;string,string&gt;, bool) Method
Generates a new [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') where all keys are  
renamed according to a specified key map.  
```csharp
public static System.Collections.Generic.IDictionary<string,TValue> Map<TValue>(this System.Collections.Generic.IDictionary<string,TValue> self, System.Collections.Generic.IDictionary<string,string> keyMap, bool isRestricted=false);
```
#### Type parameters
<a name='TetraPak_DictionaryExtensions_Map_TValue_(System_Collections_Generic_IDictionary_string_TValue__System_Collections_Generic_IDictionary_string_string__bool)_TValue'></a>
`TValue`  
The dictionary's value [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type').  
  
#### Parameters
<a name='TetraPak_DictionaryExtensions_Map_TValue_(System_Collections_Generic_IDictionary_string_TValue__System_Collections_Generic_IDictionary_string_string__bool)_self'></a>
`self` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](TetraPak_DictionaryExtensions_Map_TValue_(System_Collections_Generic_IDictionary_string_TValue__System_Collections_Generic_IDictionary_string_string__bool).md#TetraPak_DictionaryExtensions_Map_TValue_(System_Collections_Generic_IDictionary_string_TValue__System_Collections_Generic_IDictionary_string_string__bool)_TValue 'TetraPak.DictionaryExtensions.Map&lt;TValue&gt;(System.Collections.Generic.IDictionary&lt;string,TValue&gt;, System.Collections.Generic.IDictionary&lt;string,string&gt;, bool).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
The source dictionary.   
  
<a name='TetraPak_DictionaryExtensions_Map_TValue_(System_Collections_Generic_IDictionary_string_TValue__System_Collections_Generic_IDictionary_string_string__bool)_keyMap'></a>
`keyMap` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
A dictionary containing the key mapping (keys=source keys, values=target keys).  
  
<a name='TetraPak_DictionaryExtensions_Map_TValue_(System_Collections_Generic_IDictionary_string_TValue__System_Collections_Generic_IDictionary_string_string__bool)_isRestricted'></a>
`isRestricted` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
(optional; default=`false`)<br/>  
Specifies whether to only include attributes whose keys can be found in the [keyMap](TetraPak_DictionaryExtensions_Map_TValue_(System_Collections_Generic_IDictionary_string_TValue__System_Collections_Generic_IDictionary_string_string__bool).md#TetraPak_DictionaryExtensions_Map_TValue_(System_Collections_Generic_IDictionary_string_TValue__System_Collections_Generic_IDictionary_string_string__bool)_keyMap 'TetraPak.DictionaryExtensions.Map&lt;TValue&gt;(System.Collections.Generic.IDictionary&lt;string,TValue&gt;, System.Collections.Generic.IDictionary&lt;string,string&gt;, bool).keyMap').    
  
#### Returns
[System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](TetraPak_DictionaryExtensions_Map_TValue_(System_Collections_Generic_IDictionary_string_TValue__System_Collections_Generic_IDictionary_string_string__bool).md#TetraPak_DictionaryExtensions_Map_TValue_(System_Collections_Generic_IDictionary_string_TValue__System_Collections_Generic_IDictionary_string_string__bool)_TValue 'TetraPak.DictionaryExtensions.Map&lt;TValue&gt;(System.Collections.Generic.IDictionary&lt;string,TValue&gt;, System.Collections.Generic.IDictionary&lt;string,string&gt;, bool).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
A remapped dictionary.  
#### See Also
- [MapSafe&lt;TValue&gt;(IDictionary&lt;string,TValue&gt;, KeyMapInfo, bool)](TetraPak_DictionaryExtensions_MapSafe_TValue_(System_Collections_Generic_IDictionary_string_TValue__TetraPak_Serialization_KeyMapInfo_bool).md 'TetraPak.DictionaryExtensions.MapSafe&lt;TValue&gt;(System.Collections.Generic.IDictionary&lt;string,TValue&gt;, TetraPak.Serialization.KeyMapInfo, bool)')
