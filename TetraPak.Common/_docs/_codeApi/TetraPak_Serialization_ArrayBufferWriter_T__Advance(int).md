#### [TetraPak.Common](index.md 'index')
### [TetraPak.Serialization](TetraPak_Serialization.md 'TetraPak.Serialization').[ArrayBufferWriter&lt;T&gt;](TetraPak_Serialization_ArrayBufferWriter_T_.md 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;')
## ArrayBufferWriter&lt;T&gt;.Advance(int) Method
Notifies [System.Buffers.IBufferWriter&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Buffers.IBufferWriter-1 'System.Buffers.IBufferWriter`1') that [count](TetraPak_Serialization_ArrayBufferWriter_T__Advance(int).md#TetraPak_Serialization_ArrayBufferWriter_T__Advance(int)_count 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.Advance(int).count') amount of data was written to the output [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')/[System.Memory&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Memory-1 'System.Memory`1')
```csharp
public void Advance(int count);
```
#### Parameters
<a name='TetraPak_Serialization_ArrayBufferWriter_T__Advance(int)_count'></a>
`count` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Thrown when [count](TetraPak_Serialization_ArrayBufferWriter_T__Advance(int).md#TetraPak_Serialization_ArrayBufferWriter_T__Advance(int)_count 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.Advance(int).count') is negative.  
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
Thrown when attempting to advance past the end of the underlying buffer.  

Implements [Advance(int)](https://docs.microsoft.com/en-us/dotnet/api/System.Buffers.IBufferWriter-1.Advance#System_Buffers_IBufferWriter_1_Advance_System_Int32_ 'System.Buffers.IBufferWriter`1.Advance(System.Int32)')  
### Remarks
You must request a new buffer after calling Advance to continue writing more data and cannot write to a previously acquired buffer.  
