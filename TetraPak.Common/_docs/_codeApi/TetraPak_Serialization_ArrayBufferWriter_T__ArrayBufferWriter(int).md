#### [TetraPak.Common](index.md 'index')
### [TetraPak.Serialization](TetraPak_Serialization.md 'TetraPak.Serialization').[ArrayBufferWriter&lt;T&gt;](TetraPak_Serialization_ArrayBufferWriter_T_.md 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;')
## ArrayBufferWriter&lt;T&gt;.ArrayBufferWriter(int) Constructor
Creates an instance of an [ArrayBufferWriter&lt;T&gt;](TetraPak_Serialization_ArrayBufferWriter_T_.md 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;'), in which data can be written to,  
with an initial capacity specified.  
```csharp
public ArrayBufferWriter(int initialCapacity);
```
#### Parameters
<a name='TetraPak_Serialization_ArrayBufferWriter_T__ArrayBufferWriter(int)_initialCapacity'></a>
`initialCapacity` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The minimum capacity with which to initialize the underlying buffer.
  
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Thrown when [initialCapacity](TetraPak_Serialization_ArrayBufferWriter_T__ArrayBufferWriter(int).md#TetraPak_Serialization_ArrayBufferWriter_T__ArrayBufferWriter(int)_initialCapacity 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.ArrayBufferWriter(int).initialCapacity') is not positive (i.e. less than or equal to 0).  
