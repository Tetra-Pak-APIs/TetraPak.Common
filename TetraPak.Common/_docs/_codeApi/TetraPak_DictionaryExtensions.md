#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak')
## DictionaryExtensions Class
```csharp
public static class DictionaryExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DictionaryExtensions  
### Methods
<a name='TetraPak_DictionaryExtensions_Map_TValue_(System_Collections_Generic_IDictionary_string_TValue__System_Collections_Generic_IDictionary_string_string__bool)'></a>
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
`self` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](TetraPak_DictionaryExtensions.md#TetraPak_DictionaryExtensions_Map_TValue_(System_Collections_Generic_IDictionary_string_TValue__System_Collections_Generic_IDictionary_string_string__bool)_TValue 'TetraPak.DictionaryExtensions.Map&lt;TValue&gt;(System.Collections.Generic.IDictionary&lt;string,TValue&gt;, System.Collections.Generic.IDictionary&lt;string,string&gt;, bool).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
The source dictionary.   
  
<a name='TetraPak_DictionaryExtensions_Map_TValue_(System_Collections_Generic_IDictionary_string_TValue__System_Collections_Generic_IDictionary_string_string__bool)_keyMap'></a>
`keyMap` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
A dictionary containing the key mapping (keys=source keys, values=target keys).  
  
<a name='TetraPak_DictionaryExtensions_Map_TValue_(System_Collections_Generic_IDictionary_string_TValue__System_Collections_Generic_IDictionary_string_string__bool)_isRestricted'></a>
`isRestricted` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
(optional; default=`false`)<br/>  
Specifies whether to only include attributes whose keys can be found in the [keyMap](TetraPak_DictionaryExtensions.md#TetraPak_DictionaryExtensions_Map_TValue_(System_Collections_Generic_IDictionary_string_TValue__System_Collections_Generic_IDictionary_string_string__bool)_keyMap 'TetraPak.DictionaryExtensions.Map&lt;TValue&gt;(System.Collections.Generic.IDictionary&lt;string,TValue&gt;, System.Collections.Generic.IDictionary&lt;string,string&gt;, bool).keyMap').    
  
#### Returns
[System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](TetraPak_DictionaryExtensions.md#TetraPak_DictionaryExtensions_Map_TValue_(System_Collections_Generic_IDictionary_string_TValue__System_Collections_Generic_IDictionary_string_string__bool)_TValue 'TetraPak.DictionaryExtensions.Map&lt;TValue&gt;(System.Collections.Generic.IDictionary&lt;string,TValue&gt;, System.Collections.Generic.IDictionary&lt;string,string&gt;, bool).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
A remapped dictionary.  
#### See Also
- [MapSafe&lt;TValue&gt;(IDictionary&lt;string,TValue&gt;, KeyMapInfo, bool)](TetraPak_DictionaryExtensions.md#TetraPak_DictionaryExtensions_MapSafe_TValue_(System_Collections_Generic_IDictionary_string_TValue__TetraPak_Serialization_KeyMapInfo_bool) 'TetraPak.DictionaryExtensions.MapSafe&lt;TValue&gt;(System.Collections.Generic.IDictionary&lt;string,TValue&gt;, TetraPak.Serialization.KeyMapInfo, bool)')
  
<a name='TetraPak_DictionaryExtensions_MapSafe_TValue_(System_Collections_Generic_IDictionary_string_TValue__TetraPak_Serialization_KeyMapInfo_bool)'></a>
## DictionaryExtensions.MapSafe&lt;TValue&gt;(IDictionary&lt;string,TValue&gt;, KeyMapInfo, bool) Method
Generates a new [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') where all keys are  
renamed according to a specified key map.  
```csharp
public static System.Collections.Generic.IDictionary<string,TValue> MapSafe<TValue>(this System.Collections.Generic.IDictionary<string,TValue> self, TetraPak.Serialization.KeyMapInfo keyMap, bool isRestricted=false);
```
#### Type parameters
<a name='TetraPak_DictionaryExtensions_MapSafe_TValue_(System_Collections_Generic_IDictionary_string_TValue__TetraPak_Serialization_KeyMapInfo_bool)_TValue'></a>
`TValue`  
The dictionary's value [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type').  
  
#### Parameters
<a name='TetraPak_DictionaryExtensions_MapSafe_TValue_(System_Collections_Generic_IDictionary_string_TValue__TetraPak_Serialization_KeyMapInfo_bool)_self'></a>
`self` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](TetraPak_DictionaryExtensions.md#TetraPak_DictionaryExtensions_MapSafe_TValue_(System_Collections_Generic_IDictionary_string_TValue__TetraPak_Serialization_KeyMapInfo_bool)_TValue 'TetraPak.DictionaryExtensions.MapSafe&lt;TValue&gt;(System.Collections.Generic.IDictionary&lt;string,TValue&gt;, TetraPak.Serialization.KeyMapInfo, bool).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
The source dictionary.   
  
<a name='TetraPak_DictionaryExtensions_MapSafe_TValue_(System_Collections_Generic_IDictionary_string_TValue__TetraPak_Serialization_KeyMapInfo_bool)_keyMap'></a>
`keyMap` [KeyMapInfo](TetraPak_Serialization_KeyMapInfo.md 'TetraPak.Serialization.KeyMapInfo')  
A dictionary containing the key mapping (keys=source keys, values=target keys).  
  
<a name='TetraPak_DictionaryExtensions_MapSafe_TValue_(System_Collections_Generic_IDictionary_string_TValue__TetraPak_Serialization_KeyMapInfo_bool)_isRestricted'></a>
`isRestricted` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
(optional; default=`false`)<br/>  
Specifies whether to only include attributes whose keys can be found in the [keyMap](TetraPak_DictionaryExtensions.md#TetraPak_DictionaryExtensions_MapSafe_TValue_(System_Collections_Generic_IDictionary_string_TValue__TetraPak_Serialization_KeyMapInfo_bool)_keyMap 'TetraPak.DictionaryExtensions.MapSafe&lt;TValue&gt;(System.Collections.Generic.IDictionary&lt;string,TValue&gt;, TetraPak.Serialization.KeyMapInfo, bool).keyMap').    
  
#### Returns
[System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](TetraPak_DictionaryExtensions.md#TetraPak_DictionaryExtensions_MapSafe_TValue_(System_Collections_Generic_IDictionary_string_TValue__TetraPak_Serialization_KeyMapInfo_bool)_TValue 'TetraPak.DictionaryExtensions.MapSafe&lt;TValue&gt;(System.Collections.Generic.IDictionary&lt;string,TValue&gt;, TetraPak.Serialization.KeyMapInfo, bool).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
A remapped dictionary.  
  
<a name='TetraPak_DictionaryExtensions_MapTo_T_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__System_Func_System_Collections_Generic_KeyValuePair_TKey_TValue__T_)'></a>
## DictionaryExtensions.MapTo&lt;T,TKey,TValue&gt;(IDictionary&lt;TKey,TValue&gt;, Func&lt;KeyValuePair&lt;TKey,TValue&gt;,T&gt;) Method
Maps all key/value elements to a collection of items of a specified type.  
```csharp
public static System.Collections.Generic.IEnumerable<T> MapTo<T,TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue> self, System.Func<System.Collections.Generic.KeyValuePair<TKey,TValue>,T> mapper);
```
#### Type parameters
<a name='TetraPak_DictionaryExtensions_MapTo_T_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__System_Func_System_Collections_Generic_KeyValuePair_TKey_TValue__T_)_T'></a>
`T`  
  
<a name='TetraPak_DictionaryExtensions_MapTo_T_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__System_Func_System_Collections_Generic_KeyValuePair_TKey_TValue__T_)_TKey'></a>
`TKey`  
  
<a name='TetraPak_DictionaryExtensions_MapTo_T_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__System_Func_System_Collections_Generic_KeyValuePair_TKey_TValue__T_)_TValue'></a>
`TValue`  
  
#### Parameters
<a name='TetraPak_DictionaryExtensions_MapTo_T_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__System_Func_System_Collections_Generic_KeyValuePair_TKey_TValue__T_)_self'></a>
`self` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](TetraPak_DictionaryExtensions.md#TetraPak_DictionaryExtensions_MapTo_T_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__System_Func_System_Collections_Generic_KeyValuePair_TKey_TValue__T_)_TKey 'TetraPak.DictionaryExtensions.MapTo&lt;T,TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, System.Func&lt;System.Collections.Generic.KeyValuePair&lt;TKey,TValue&gt;,T&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](TetraPak_DictionaryExtensions.md#TetraPak_DictionaryExtensions_MapTo_T_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__System_Func_System_Collections_Generic_KeyValuePair_TKey_TValue__T_)_TValue 'TetraPak.DictionaryExtensions.MapTo&lt;T,TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, System.Func&lt;System.Collections.Generic.KeyValuePair&lt;TKey,TValue&gt;,T&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
  
<a name='TetraPak_DictionaryExtensions_MapTo_T_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__System_Func_System_Collections_Generic_KeyValuePair_TKey_TValue__T_)_mapper'></a>
`mapper` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](TetraPak_DictionaryExtensions.md#TetraPak_DictionaryExtensions_MapTo_T_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__System_Func_System_Collections_Generic_KeyValuePair_TKey_TValue__T_)_TKey 'TetraPak.DictionaryExtensions.MapTo&lt;T,TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, System.Func&lt;System.Collections.Generic.KeyValuePair&lt;TKey,TValue&gt;,T&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](TetraPak_DictionaryExtensions.md#TetraPak_DictionaryExtensions_MapTo_T_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__System_Func_System_Collections_Generic_KeyValuePair_TKey_TValue__T_)_TValue 'TetraPak.DictionaryExtensions.MapTo&lt;T,TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, System.Func&lt;System.Collections.Generic.KeyValuePair&lt;TKey,TValue&gt;,T&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](TetraPak_DictionaryExtensions.md#TetraPak_DictionaryExtensions_MapTo_T_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__System_Func_System_Collections_Generic_KeyValuePair_TKey_TValue__T_)_T 'TetraPak.DictionaryExtensions.MapTo&lt;T,TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, System.Func&lt;System.Collections.Generic.KeyValuePair&lt;TKey,TValue&gt;,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](TetraPak_DictionaryExtensions.md#TetraPak_DictionaryExtensions_MapTo_T_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__System_Func_System_Collections_Generic_KeyValuePair_TKey_TValue__T_)_T 'TetraPak.DictionaryExtensions.MapTo&lt;T,TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, System.Func&lt;System.Collections.Generic.KeyValuePair&lt;TKey,TValue&gt;,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
  
