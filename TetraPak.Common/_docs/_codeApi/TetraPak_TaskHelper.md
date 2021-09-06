#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak')
## TaskHelper Class
```csharp
public static class TaskHelper
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; TaskHelper  

| Methods | |
| :--- | :--- |
| [AwaitCompletionAsync&lt;T&gt;(TaskCompletionSource&lt;T&gt;)](TetraPak_TaskHelper_AwaitCompletionAsync_T_(System_Threading_Tasks_TaskCompletionSource_T_).md 'TetraPak.TaskHelper.AwaitCompletionAsync&lt;T&gt;(System.Threading.Tasks.TaskCompletionSource&lt;T&gt;)') | Examines the status of a [System.Threading.Tasks.TaskCompletionSource&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.TaskCompletionSource-1 'System.Threading.Tasks.TaskCompletionSource`1') and awaits its<br/>completion when applicable (the TCS might have already ran to completion) and then returns it.<br/> |
| [AwaitResult&lt;T&gt;(TaskCompletionSource&lt;T&gt;, Nullable&lt;TimeSpan&gt;, CancellationTokenSource)](TetraPak_TaskHelper_AwaitResult_T_(System_Threading_Tasks_TaskCompletionSource_T__System_Nullable_System_TimeSpan__System_Threading_CancellationTokenSource).md 'TetraPak.TaskHelper.AwaitResult&lt;T&gt;(System.Threading.Tasks.TaskCompletionSource&lt;T&gt;, System.Nullable&lt;System.TimeSpan&gt;, System.Threading.CancellationTokenSource)') | Blocks the thread while waiting for a result.<br/> |
