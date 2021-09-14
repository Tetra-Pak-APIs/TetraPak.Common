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
### Constructors
<a name='TetraPak_Serialization_ArrayBufferWriter_T__ArrayBufferWriter()'></a>
## ArrayBufferWriter&lt;T&gt;.ArrayBufferWriter() Constructor
Creates an instance of an [ArrayBufferWriter&lt;T&gt;](TetraPak_Serialization_ArrayBufferWriter_T_.md 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;'), in which data can be written to,  
with the default initial capacity.  
```csharp
public ArrayBufferWriter();
```
  
<a name='TetraPak_Serialization_ArrayBufferWriter_T__ArrayBufferWriter(int)'></a>
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
Thrown when [initialCapacity](TetraPak_Serialization_ArrayBufferWriter_T_.md#TetraPak_Serialization_ArrayBufferWriter_T__ArrayBufferWriter(int)_initialCapacity 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.ArrayBufferWriter(int).initialCapacity') is not positive (i.e. less than or equal to 0).  
  
### Properties
<a name='TetraPak_Serialization_ArrayBufferWriter_T__Capacity'></a>
## ArrayBufferWriter&lt;T&gt;.Capacity Property
Returns the total amount of space within the underlying buffer.  
```csharp
public int Capacity { get; }
```
#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
  
<a name='TetraPak_Serialization_ArrayBufferWriter_T__FreeCapacity'></a>
## ArrayBufferWriter&lt;T&gt;.FreeCapacity Property
Returns the amount of space available that can still be written into without forcing the underlying buffer to grow.  
```csharp
public int FreeCapacity { get; }
```
#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
  
<a name='TetraPak_Serialization_ArrayBufferWriter_T__WrittenCount'></a>
## ArrayBufferWriter&lt;T&gt;.WrittenCount Property
Returns the amount of data written to the underlying buffer so far.  
```csharp
public int WrittenCount { get; }
```
#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
  
<a name='TetraPak_Serialization_ArrayBufferWriter_T__WrittenMemory'></a>
## ArrayBufferWriter&lt;T&gt;.WrittenMemory Property
Returns the data written to the underlying buffer so far, as a [System.ReadOnlyMemory&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlyMemory-1 'System.ReadOnlyMemory`1').  
```csharp
public System.ReadOnlyMemory<T> WrittenMemory { get; }
```
#### Property Value
[System.ReadOnlyMemory&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlyMemory-1 'System.ReadOnlyMemory`1')[T](TetraPak_Serialization_ArrayBufferWriter_T_.md#TetraPak_Serialization_ArrayBufferWriter_T__T 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlyMemory-1 'System.ReadOnlyMemory`1')
  
<a name='TetraPak_Serialization_ArrayBufferWriter_T__WrittenSpan'></a>
## ArrayBufferWriter&lt;T&gt;.WrittenSpan Property
Returns the data written to the underlying buffer so far, as a [System.ReadOnlySpan&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1').  
```csharp
public System.ReadOnlySpan<T> WrittenSpan { get; }
```
#### Property Value
[System.ReadOnlySpan&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')[T](TetraPak_Serialization_ArrayBufferWriter_T_.md#TetraPak_Serialization_ArrayBufferWriter_T__T 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')
  
### Methods
<a name='TetraPak_Serialization_ArrayBufferWriter_T__Advance(int)'></a>
## ArrayBufferWriter&lt;T&gt;.Advance(int) Method
Notifies [System.Buffers.IBufferWriter&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Buffers.IBufferWriter-1 'System.Buffers.IBufferWriter`1') that [count](TetraPak_Serialization_ArrayBufferWriter_T_.md#TetraPak_Serialization_ArrayBufferWriter_T__Advance(int)_count 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.Advance(int).count') amount of data was written to the output [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')/[System.Memory&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Memory-1 'System.Memory`1')
```csharp
public void Advance(int count);
```
#### Parameters
<a name='TetraPak_Serialization_ArrayBufferWriter_T__Advance(int)_count'></a>
`count` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Thrown when [count](TetraPak_Serialization_ArrayBufferWriter_T_.md#TetraPak_Serialization_ArrayBufferWriter_T__Advance(int)_count 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.Advance(int).count') is negative.  
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
Thrown when attempting to advance past the end of the underlying buffer.  

Implements [Advance(int)](https://docs.microsoft.com/en-us/dotnet/api/System.Buffers.IBufferWriter-1.Advance#System_Buffers_IBufferWriter_1_Advance_System_Int32_ 'System.Buffers.IBufferWriter`1.Advance(System.Int32)')  
### Remarks
You must request a new buffer after calling Advance to continue writing more data and cannot write to a previously acquired buffer.  
  
<a name='TetraPak_Serialization_ArrayBufferWriter_T__Clear()'></a>
## ArrayBufferWriter&lt;T&gt;.Clear() Method
Clears the data written to the underlying buffer.  
```csharp
public void Clear();
```
### Remarks
You must clear the [ArrayBufferWriter&lt;T&gt;](TetraPak_Serialization_ArrayBufferWriter_T_.md 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;') before trying to re-use it.  
  
<a name='TetraPak_Serialization_ArrayBufferWriter_T__GetMemory(int)'></a>
## ArrayBufferWriter&lt;T&gt;.GetMemory(int) Method
Returns a [System.Memory&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Memory-1 'System.Memory`1') to write to that is at least the requested length (specified by [sizeHint](TetraPak_Serialization_ArrayBufferWriter_T_.md#TetraPak_Serialization_ArrayBufferWriter_T__GetMemory(int)_sizeHint 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.GetMemory(int).sizeHint')).  
If no [sizeHint](TetraPak_Serialization_ArrayBufferWriter_T_.md#TetraPak_Serialization_ArrayBufferWriter_T__GetMemory(int)_sizeHint 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.GetMemory(int).sizeHint') is provided (or it's equal to ```csharp
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
Thrown when [sizeHint](TetraPak_Serialization_ArrayBufferWriter_T_.md#TetraPak_Serialization_ArrayBufferWriter_T__GetMemory(int)_sizeHint 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.GetMemory(int).sizeHint') is negative.  

Implements [GetMemory(int)](https://docs.microsoft.com/en-us/dotnet/api/System.Buffers.IBufferWriter-1.GetMemory#System_Buffers_IBufferWriter_1_GetMemory_System_Int32_ 'System.Buffers.IBufferWriter`1.GetMemory(System.Int32)')  
### Remarks
This will never return an empty [System.Memory&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Memory-1 'System.Memory`1').  
  
<a name='TetraPak_Serialization_ArrayBufferWriter_T__GetSpan(int)'></a>
## ArrayBufferWriter&lt;T&gt;.GetSpan(int) Method
Returns a [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1') to write to that is at least the requested length (specified by [sizeHint](TetraPak_Serialization_ArrayBufferWriter_T_.md#TetraPak_Serialization_ArrayBufferWriter_T__GetSpan(int)_sizeHint 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.GetSpan(int).sizeHint')).  
If no [sizeHint](TetraPak_Serialization_ArrayBufferWriter_T_.md#TetraPak_Serialization_ArrayBufferWriter_T__GetSpan(int)_sizeHint 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.GetSpan(int).sizeHint') is provided (or it's equal to ```csharp
0```
), some non-empty buffer is returned.  
```csharp
public System.Span<T> GetSpan(int sizeHint=0);
```
#### Parameters
<a name='TetraPak_Serialization_ArrayBufferWriter_T__GetSpan(int)_sizeHint'></a>
`sizeHint` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
#### Returns
[System.Span&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')[T](TetraPak_Serialization_ArrayBufferWriter_T_.md#TetraPak_Serialization_ArrayBufferWriter_T__T 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')  
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Thrown when [sizeHint](TetraPak_Serialization_ArrayBufferWriter_T_.md#TetraPak_Serialization_ArrayBufferWriter_T__GetSpan(int)_sizeHint 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;.GetSpan(int).sizeHint') is negative.  

Implements [GetSpan(int)](https://docs.microsoft.com/en-us/dotnet/api/System.Buffers.IBufferWriter-1.GetSpan#System_Buffers_IBufferWriter_1_GetSpan_System_Int32_ 'System.Buffers.IBufferWriter`1.GetSpan(System.Int32)')  
### Remarks
This will never return an empty [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1').  
  
