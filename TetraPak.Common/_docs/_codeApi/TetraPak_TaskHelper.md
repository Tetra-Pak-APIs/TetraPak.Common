#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak')
## TaskHelper Class
```csharp
public static class TaskHelper
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; TaskHelper  
### Methods
<a name='TetraPak_TaskHelper_AwaitCompletionAsync_T_(System_Threading_Tasks_TaskCompletionSource_T_)'></a>
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
`tcs` [System.Threading.Tasks.TaskCompletionSource&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.TaskCompletionSource-1 'System.Threading.Tasks.TaskCompletionSource`1')[T](TetraPak_TaskHelper.md#TetraPak_TaskHelper_AwaitCompletionAsync_T_(System_Threading_Tasks_TaskCompletionSource_T_)_T 'TetraPak.TaskHelper.AwaitCompletionAsync&lt;T&gt;(System.Threading.Tasks.TaskCompletionSource&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.TaskCompletionSource-1 'System.Threading.Tasks.TaskCompletionSource`1')  
The [System.Threading.Tasks.TaskCompletionSource&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.TaskCompletionSource-1 'System.Threading.Tasks.TaskCompletionSource`1') to be awaited.  
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Threading.Tasks.TaskCompletionSource&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.TaskCompletionSource-1 'System.Threading.Tasks.TaskCompletionSource`1')[T](TetraPak_TaskHelper.md#TetraPak_TaskHelper_AwaitCompletionAsync_T_(System_Threading_Tasks_TaskCompletionSource_T_)_T 'TetraPak.TaskHelper.AwaitCompletionAsync&lt;T&gt;(System.Threading.Tasks.TaskCompletionSource&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.TaskCompletionSource-1 'System.Threading.Tasks.TaskCompletionSource`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The specified [System.Threading.Tasks.TaskCompletionSource&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.TaskCompletionSource-1 'System.Threading.Tasks.TaskCompletionSource`1') ([tcs](TetraPak_TaskHelper.md#TetraPak_TaskHelper_AwaitCompletionAsync_T_(System_Threading_Tasks_TaskCompletionSource_T_)_tcs 'TetraPak.TaskHelper.AwaitCompletionAsync&lt;T&gt;(System.Threading.Tasks.TaskCompletionSource&lt;T&gt;).tcs')). See remarks.  
### Remarks
The method always returns the specified [System.Threading.Tasks.TaskCompletionSource&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.TaskCompletionSource-1 'System.Threading.Tasks.TaskCompletionSource`1')[tcs](TetraPak_TaskHelper.md#TetraPak_TaskHelper_AwaitCompletionAsync_T_(System_Threading_Tasks_TaskCompletionSource_T_)_tcs 'TetraPak.TaskHelper.AwaitCompletionAsync&lt;T&gt;(System.Threading.Tasks.TaskCompletionSource&lt;T&gt;).tcs').  
Caller's should <i>not</i> rely on the instance being assigned after completion as it is a common  
pattern for many asynchronous operations to create the TCS while initiating and then removing is  
upon completion.  
  
<a name='TetraPak_TaskHelper_AwaitResult_T_(System_Threading_Tasks_TaskCompletionSource_T__System_Nullable_System_TimeSpan__System_Threading_CancellationTokenSource)'></a>
## TaskHelper.AwaitResult&lt;T&gt;(TaskCompletionSource&lt;T&gt;, Nullable&lt;TimeSpan&gt;, CancellationTokenSource) Method
Blocks the thread while waiting for a result.  
```csharp
public static TetraPak.Outcome<T> AwaitResult<T>(this System.Threading.Tasks.TaskCompletionSource<T> tcs, System.Nullable<System.TimeSpan> timeout=null, System.Threading.CancellationTokenSource cts=null);
```
#### Type parameters
<a name='TetraPak_TaskHelper_AwaitResult_T_(System_Threading_Tasks_TaskCompletionSource_T__System_Nullable_System_TimeSpan__System_Threading_CancellationTokenSource)_T'></a>
`T`  
The type of result being requested.  
  
#### Parameters
<a name='TetraPak_TaskHelper_AwaitResult_T_(System_Threading_Tasks_TaskCompletionSource_T__System_Nullable_System_TimeSpan__System_Threading_CancellationTokenSource)_tcs'></a>
`tcs` [System.Threading.Tasks.TaskCompletionSource&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.TaskCompletionSource-1 'System.Threading.Tasks.TaskCompletionSource`1')[T](TetraPak_TaskHelper.md#TetraPak_TaskHelper_AwaitResult_T_(System_Threading_Tasks_TaskCompletionSource_T__System_Nullable_System_TimeSpan__System_Threading_CancellationTokenSource)_T 'TetraPak.TaskHelper.AwaitResult&lt;T&gt;(System.Threading.Tasks.TaskCompletionSource&lt;T&gt;, System.Nullable&lt;System.TimeSpan&gt;, System.Threading.CancellationTokenSource).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.TaskCompletionSource-1 'System.Threading.Tasks.TaskCompletionSource`1')  
The [System.Threading.Tasks.TaskCompletionSource&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.TaskCompletionSource-1 'System.Threading.Tasks.TaskCompletionSource`1') in use for signalling result is available.  
  
<a name='TetraPak_TaskHelper_AwaitResult_T_(System_Threading_Tasks_TaskCompletionSource_T__System_Nullable_System_TimeSpan__System_Threading_CancellationTokenSource)_timeout'></a>
`timeout` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
(optional)<br/>  
Specifies a timeout. If operation times our a default result will be sent back.  
  
<a name='TetraPak_TaskHelper_AwaitResult_T_(System_Threading_Tasks_TaskCompletionSource_T__System_Nullable_System_TimeSpan__System_Threading_CancellationTokenSource)_cts'></a>
`cts` [System.Threading.CancellationTokenSource](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationTokenSource 'System.Threading.CancellationTokenSource')  
(optional)<br/>  
A cancellation token source, allowing operation cancellation (from a different thread).  
  
#### Returns
[TetraPak.Outcome&lt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')[T](TetraPak_TaskHelper.md#TetraPak_TaskHelper_AwaitResult_T_(System_Threading_Tasks_TaskCompletionSource_T__System_Nullable_System_TimeSpan__System_Threading_CancellationTokenSource)_T 'TetraPak.TaskHelper.AwaitResult&lt;T&gt;(System.Threading.Tasks.TaskCompletionSource&lt;T&gt;, System.Nullable&lt;System.TimeSpan&gt;, System.Threading.CancellationTokenSource).T')[&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')  
An [Outcome&lt;T&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;') value, signalling success/failure while also carrying the requested  
result on success; otherwise an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').  
  
