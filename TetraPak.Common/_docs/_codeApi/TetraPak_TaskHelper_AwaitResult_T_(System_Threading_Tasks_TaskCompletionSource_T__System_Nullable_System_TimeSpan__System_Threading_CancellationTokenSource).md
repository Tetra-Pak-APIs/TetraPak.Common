#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[TaskHelper](TetraPak_TaskHelper.md 'TetraPak.TaskHelper')
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
`tcs` [System.Threading.Tasks.TaskCompletionSource&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.TaskCompletionSource-1 'System.Threading.Tasks.TaskCompletionSource`1')[T](TetraPak_TaskHelper_AwaitResult_T_(System_Threading_Tasks_TaskCompletionSource_T__System_Nullable_System_TimeSpan__System_Threading_CancellationTokenSource).md#TetraPak_TaskHelper_AwaitResult_T_(System_Threading_Tasks_TaskCompletionSource_T__System_Nullable_System_TimeSpan__System_Threading_CancellationTokenSource)_T 'TetraPak.TaskHelper.AwaitResult&lt;T&gt;(System.Threading.Tasks.TaskCompletionSource&lt;T&gt;, System.Nullable&lt;System.TimeSpan&gt;, System.Threading.CancellationTokenSource).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.TaskCompletionSource-1 'System.Threading.Tasks.TaskCompletionSource`1')  
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
[TetraPak.Outcome&lt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Outcome-1 'TetraPak.Outcome`1')[T](TetraPak_TaskHelper_AwaitResult_T_(System_Threading_Tasks_TaskCompletionSource_T__System_Nullable_System_TimeSpan__System_Threading_CancellationTokenSource).md#TetraPak_TaskHelper_AwaitResult_T_(System_Threading_Tasks_TaskCompletionSource_T__System_Nullable_System_TimeSpan__System_Threading_CancellationTokenSource)_T 'TetraPak.TaskHelper.AwaitResult&lt;T&gt;(System.Threading.Tasks.TaskCompletionSource&lt;T&gt;, System.Nullable&lt;System.TimeSpan&gt;, System.Threading.CancellationTokenSource).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Outcome-1 'TetraPak.Outcome`1')  
An [TetraPak.Outcome&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Outcome-1 'TetraPak.Outcome`1') value, signalling success/failure while also carrying the requested  
result on success; otherwise an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').  
