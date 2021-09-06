#### [TetraPak.Common](index.md 'index')
### [TetraPak.Serialization](TetraPak_Serialization.md 'TetraPak.Serialization')
## ArrayBufferWriter&lt;T&gt; Class
```csharp
internal sealed class ArrayBufferWriter<T> :
System.Buffers.IBufferWriter<T>
```
#### Type parameters
<a name='TetraPak_Serialization_ArrayBufferWriter_T__T'></a>
`T`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ArrayBufferWriter&lt;T&gt;  

Implements [System.Buffers.IBufferWriter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Buffers.IBufferWriter-1 'System.Buffers.IBufferWriter`1')[T](TetraPak_Serialization_ArrayBufferWriter_T_.md#TetraPak_Serialization_ArrayBufferWriter_T__T 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Buffers.IBufferWriter-1 'System.Buffers.IBufferWriter`1')  

| Constructors | |
| :--- | :--- |
| [ArrayBufferWriter()](TetraPak_Serialization_ArrayBufferWriter_T__ArrayBufferWriter().md 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.ArrayBufferWriter()') | Creates an instance of an [ArrayBufferWriter&lt;T&gt;](TetraPak_Serialization_ArrayBufferWriter_T_.md 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;'), in which data can be written to,<br/>with the default initial capacity.<br/> |
| [ArrayBufferWriter(int)](TetraPak_Serialization_ArrayBufferWriter_T__ArrayBufferWriter(int).md 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.ArrayBufferWriter(int)') | Creates an instance of an [ArrayBufferWriter&lt;T&gt;](TetraPak_Serialization_ArrayBufferWriter_T_.md 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;'), in which data can be written to,<br/>with an initial capacity specified.<br/> |

| Properties | |
| :--- | :--- |
| [Capacity](TetraPak_Serialization_ArrayBufferWriter_T__Capacity.md 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.Capacity') | Returns the total amount of space within the underlying buffer.<br/> |
| [FreeCapacity](TetraPak_Serialization_ArrayBufferWriter_T__FreeCapacity.md 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.FreeCapacity') | Returns the amount of space available that can still be written into without forcing the underlying buffer to grow.<br/> |
| [WrittenCount](TetraPak_Serialization_ArrayBufferWriter_T__WrittenCount.md 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.WrittenCount') | Returns the amount of data written to the underlying buffer so far.<br/> |
| [WrittenMemory](TetraPak_Serialization_ArrayBufferWriter_T__WrittenMemory.md 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.WrittenMemory') | Returns the data written to the underlying buffer so far, as a [System.ReadOnlyMemory&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlyMemory-1 'System.ReadOnlyMemory`1').<br/> |
| [WrittenSpan](TetraPak_Serialization_ArrayBufferWriter_T__WrittenSpan.md 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.WrittenSpan') | Returns the data written to the underlying buffer so far, as a [System.ReadOnlySpan&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1').<br/> |

| Methods | |
| :--- | :--- |
| [Advance(int)](TetraPak_Serialization_ArrayBufferWriter_T__Advance(int).md 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.Advance(int)') | Notifies [System.Buffers.IBufferWriter&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Buffers.IBufferWriter-1 'System.Buffers.IBufferWriter`1') that [count](TetraPak_Serialization_ArrayBufferWriter_T__Advance(int).md#TetraPak_Serialization_ArrayBufferWriter_T__Advance(int)_count 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.Advance(int).count') amount of data was written to the output [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')/[System.Memory&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Memory-1 'System.Memory`1') |
| [Clear()](TetraPak_Serialization_ArrayBufferWriter_T__Clear().md 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.Clear()') | Clears the data written to the underlying buffer.<br/> |
| [GetMemory(int)](TetraPak_Serialization_ArrayBufferWriter_T__GetMemory(int).md 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.GetMemory(int)') | Returns a [System.Memory&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Memory-1 'System.Memory`1') to write to that is at least the requested length (specified by [sizeHint](TetraPak_Serialization_ArrayBufferWriter_T__GetMemory(int).md#TetraPak_Serialization_ArrayBufferWriter_T__GetMemory(int)_sizeHint 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.GetMemory(int).sizeHint')).<br/>If no [sizeHint](TetraPak_Serialization_ArrayBufferWriter_T__GetMemory(int).md#TetraPak_Serialization_ArrayBufferWriter_T__GetMemory(int)_sizeHint 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.GetMemory(int).sizeHint') is provided (or it's equal to ), some non-empty buffer is returned.<br/> |
| [GetSpan(int)](TetraPak_Serialization_ArrayBufferWriter_T__GetSpan(int).md 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.GetSpan(int)') | Returns a [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1') to write to that is at least the requested length (specified by [sizeHint](TetraPak_Serialization_ArrayBufferWriter_T__GetSpan(int).md#TetraPak_Serialization_ArrayBufferWriter_T__GetSpan(int)_sizeHint 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.GetSpan(int).sizeHint')).<br/>If no [sizeHint](TetraPak_Serialization_ArrayBufferWriter_T__GetSpan(int).md#TetraPak_Serialization_ArrayBufferWriter_T__GetSpan(int)_sizeHint 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.GetSpan(int).sizeHint') is provided (or it's equal to ), some non-empty buffer is returned.<br/> |
