#### [TetraPak.Common](index.md 'index')
### [TetraPak.Serialization](TetraPak_Serialization.md 'TetraPak.Serialization').[ArrayBufferWriter&lt;T&gt;](TetraPak_Serialization_ArrayBufferWriter_T_.md 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;')
## ArrayBufferWriter&lt;T&gt;.GetMemory(int) Method
Returns a [System.Memory&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Memory-1 'System.Memory`1') to write to that is at least the requested length (specified by [sizeHint](TetraPak_Serialization_ArrayBufferWriter_T__GetMemory(int).md#TetraPak_Serialization_ArrayBufferWriter_T__GetMemory(int)_sizeHint 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.GetMemory(int).sizeHint')).  
If no [sizeHint](TetraPak_Serialization_ArrayBufferWriter_T__GetMemory(int).md#TetraPak_Serialization_ArrayBufferWriter_T__GetMemory(int)_sizeHint 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.GetMemory(int).sizeHint') is provided (or it's equal to ```csharp
0```
), some non-empty buffer is returned.  
```csharp
public System.Memory<T> GetMemory(int sizeHint=0);
```
#### Parameters
<a name='TetraPak_Serialization_ArrayBufferWriter_T__GetMemory(int)_sizeHint'></a>
`sizeHint` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
#### Returns
[System.Memory&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Memory-1 'System.Memory`1')[T](TetraPak_Serialization_ArrayBufferWriter_T_.md#TetraPak_Serialization_ArrayBufferWriter_T__T 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Memory-1 'System.Memory`1')  
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Thrown when [sizeHint](TetraPak_Serialization_ArrayBufferWriter_T__GetMemory(int).md#TetraPak_Serialization_ArrayBufferWriter_T__GetMemory(int)_sizeHint 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.GetMemory(int).sizeHint') is negative.  

Implements [GetMemory(int)](https://docs.microsoft.com/en-us/dotnet/api/System.Buffers.IBufferWriter-1.GetMemory#System_Buffers_IBufferWriter_1_GetMemory_System_Int32_ 'System.Buffers.IBufferWriter`1.GetMemory(System.Int32)')  
### Remarks
This will never return an empty [System.Memory&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Memory-1 'System.Memory`1').  
