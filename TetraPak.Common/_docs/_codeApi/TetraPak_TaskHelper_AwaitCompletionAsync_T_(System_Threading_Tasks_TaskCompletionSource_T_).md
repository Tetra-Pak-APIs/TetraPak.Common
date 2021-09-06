#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[TaskHelper](TetraPak_TaskHelper.md 'TetraPak.TaskHelper')
## TaskHelper.AwaitCompletionAsync&lt;T&gt;(TaskCompletionSource&lt;T&gt;) Method
Examines the status of a [System.Threading.Tasks.TaskCompletionSource&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.TaskCompletionSource-1 'System.Threading.Tasks.TaskCompletionSource`1') and awaits its  
completion when applicable (the TCS might have already ran to completion) and then returns it.  
```csharp
public static System.Threading.Tasks.Task<System.Threading.Tasks.TaskCompletionSource<T>> AwaitCompletionAsync<T>(this System.Threading.Tasks.TaskCompletionSource<T> tcs);
```
#### Type parameters
<a name='TetraPak_TaskHelper_AwaitCompletionAsync_T_(System_Threading_Tasks_TaskCompletionSource_T_)_T'></a>
`T`  
The task completion source's result type.  
  
#### Parameters
<a name='TetraPak_TaskHelper_AwaitCompletionAsync_T_(System_Threading_Tasks_TaskCompletionSource_T_)_tcs'></a>
`tcs` [System.Threading.Tasks.TaskCompletionSource&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.TaskCompletionSource-1 'System.Threading.Tasks.TaskCompletionSource`1')[T](TetraPak_TaskHelper_AwaitCompletionAsync_T_(System_Threading_Tasks_TaskCompletionSource_T_).md#TetraPak_TaskHelper_AwaitCompletionAsync_T_(System_Threading_Tasks_TaskCompletionSource_T_)_T 'TetraPak.TaskHelper.AwaitCompletionAsync&lt;T&gt;(System.Threading.Tasks.TaskCompletionSource&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.TaskCompletionSource-1 'System.Threading.Tasks.TaskCompletionSource`1')  
The [System.Threading.Tasks.TaskCompletionSource&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.TaskCompletionSource-1 'System.Threading.Tasks.TaskCompletionSource`1') to be awaited.  
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Threading.Tasks.TaskCompletionSource&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.TaskCompletionSource-1 'System.Threading.Tasks.TaskCompletionSource`1')[T](TetraPak_TaskHelper_AwaitCompletionAsync_T_(System_Threading_Tasks_TaskCompletionSource_T_).md#TetraPak_TaskHelper_AwaitCompletionAsync_T_(System_Threading_Tasks_TaskCompletionSource_T_)_T 'TetraPak.TaskHelper.AwaitCompletionAsync&lt;T&gt;(System.Threading.Tasks.TaskCompletionSource&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.TaskCompletionSource-1 'System.Threading.Tasks.TaskCompletionSource`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The specified [System.Threading.Tasks.TaskCompletionSource&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.TaskCompletionSource-1 'System.Threading.Tasks.TaskCompletionSource`1') ([tcs](TetraPak_TaskHelper_AwaitCompletionAsync_T_(System_Threading_Tasks_TaskCompletionSource_T_).md#TetraPak_TaskHelper_AwaitCompletionAsync_T_(System_Threading_Tasks_TaskCompletionSource_T_)_tcs 'TetraPak.TaskHelper.AwaitCompletionAsync&lt;T&gt;(System.Threading.Tasks.TaskCompletionSource&lt;T&gt;).tcs')). See remarks.  
### Remarks
The method always returns the specified [System.Threading.Tasks.TaskCompletionSource&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.TaskCompletionSource-1 'System.Threading.Tasks.TaskCompletionSource`1')[tcs](TetraPak_TaskHelper_AwaitCompletionAsync_T_(System_Threading_Tasks_TaskCompletionSource_T_).md#TetraPak_TaskHelper_AwaitCompletionAsync_T_(System_Threading_Tasks_TaskCompletionSource_T_)_tcs 'TetraPak.TaskHelper.AwaitCompletionAsync&lt;T&gt;(System.Threading.Tasks.TaskCompletionSource&lt;T&gt;).tcs').  
Caller's should <i>not</i> rely on the instance being assigned after completion as it is a common  
pattern for many asynchronous operations to create the TCS while initiating and then removing is  
upon completion.  
