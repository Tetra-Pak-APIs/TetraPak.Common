#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak')
## StringHelper Class
Convenience extension methods for [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') operations.  
```csharp
public static class StringHelper
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; StringHelper  
### Methods
<a name='TetraPak_StringHelper_Concat_TKey_TValue_(System_Collections_Generic_IEnumerable_System_Collections_Generic_KeyValuePair_TKey_TValue___string_System_Func_object_string_)'></a>
## StringHelper.Concat&lt;TKey,TValue&gt;(IEnumerable&lt;KeyValuePair&lt;TKey,TValue&gt;&gt;, string, Func&lt;object,string&gt;) Method
Builds a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') value from a collection of key/value pairs.  
```csharp
public static string Concat<TKey,TValue>(this System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>> self, string separator=", ", System.Func<object,string> callback=null);
```
#### Type parameters
<a name='TetraPak_StringHelper_Concat_TKey_TValue_(System_Collections_Generic_IEnumerable_System_Collections_Generic_KeyValuePair_TKey_TValue___string_System_Func_object_string_)_TKey'></a>
`TKey`  
The key value pair key type.  
  
<a name='TetraPak_StringHelper_Concat_TKey_TValue_(System_Collections_Generic_IEnumerable_System_Collections_Generic_KeyValuePair_TKey_TValue___string_System_Func_object_string_)_TValue'></a>
`TValue`  
The key value pair value type.  
  
#### Parameters
<a name='TetraPak_StringHelper_Concat_TKey_TValue_(System_Collections_Generic_IEnumerable_System_Collections_Generic_KeyValuePair_TKey_TValue___string_System_Func_object_string_)_self'></a>
`self` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](TetraPak_StringHelper.md#TetraPak_StringHelper_Concat_TKey_TValue_(System_Collections_Generic_IEnumerable_System_Collections_Generic_KeyValuePair_TKey_TValue___string_System_Func_object_string_)_TKey 'TetraPak.StringHelper.Concat&lt;TKey,TValue&gt;(System.Collections.Generic.IEnumerable&lt;System.Collections.Generic.KeyValuePair&lt;TKey,TValue&gt;&gt;, string, System.Func&lt;object,string&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](TetraPak_StringHelper.md#TetraPak_StringHelper_Concat_TKey_TValue_(System_Collections_Generic_IEnumerable_System_Collections_Generic_KeyValuePair_TKey_TValue___string_System_Func_object_string_)_TValue 'TetraPak.StringHelper.Concat&lt;TKey,TValue&gt;(System.Collections.Generic.IEnumerable&lt;System.Collections.Generic.KeyValuePair&lt;TKey,TValue&gt;&gt;, string, System.Func&lt;object,string&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The collection of key value pairs.  
  
<a name='TetraPak_StringHelper_Concat_TKey_TValue_(System_Collections_Generic_IEnumerable_System_Collections_Generic_KeyValuePair_TKey_TValue___string_System_Func_object_string_)_separator'></a>
`separator` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
(optional; default=", ")<br/>  
A separator to be used for separating the individual items in the result.  
  
<a name='TetraPak_StringHelper_Concat_TKey_TValue_(System_Collections_Generic_IEnumerable_System_Collections_Generic_KeyValuePair_TKey_TValue___string_System_Func_object_string_)_callback'></a>
`callback` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
(optional)<br/>  
A callback method to customize the result (will be called once per item to produce a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
representation for that item.  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation of the collection.  
  
<a name='TetraPak_StringHelper_ToLowerInitial(string_bool)'></a>
## StringHelper.ToLowerInitial(string, bool) Method
Ensures the first letter in the string is lowercase.  
```csharp
public static string ToLowerInitial(this string self, bool findFirstLetter=false);
```
#### Parameters
<a name='TetraPak_StringHelper_ToLowerInitial(string_bool)_self'></a>
`self` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string to be transformed.  
  
<a name='TetraPak_StringHelper_ToLowerInitial(string_bool)_findFirstLetter'></a>
`findFirstLetter` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
(optional; default = `false`)<br/>  
When set; the first occurence if a letter is automatically found (and transformed).   
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The transformed string.  
  
<a name='TetraPak_StringHelper_ToUpperInitial(string_bool)'></a>
## StringHelper.ToUpperInitial(string, bool) Method
Ensures the first letter in the string is uppercase.  
```csharp
public static string ToUpperInitial(this string self, bool findFirstLetter=false);
```
#### Parameters
<a name='TetraPak_StringHelper_ToUpperInitial(string_bool)_self'></a>
`self` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string to be transformed.  
  
<a name='TetraPak_StringHelper_ToUpperInitial(string_bool)_findFirstLetter'></a>
`findFirstLetter` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
(optional; default = `false`)<br/>  
When set; the first occurence if a letter is automatically found (and transformed).   
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The transformed string.  
  
