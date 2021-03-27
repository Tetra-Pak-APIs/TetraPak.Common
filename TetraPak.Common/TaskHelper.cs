using System.Threading.Tasks;

namespace tetrapak
{
    public static class TaskHelper
    {
        /// <summary>
        ///   Examines the status of a <see cref="TaskCompletionSource"/> and awaits its
        ///   completion when applicable (the TCS might have already ran to completion) and then returns it.
        /// </summary>
        /// <param name="tcs">
        ///    The <see cref="TaskCompletionSource{TResult}"/> to be awaited.
        /// </param>
        /// <typeparam name="T">
        ///   The task completion source's result type.
        /// </typeparam>
        /// <returns>
        ///   The specified <see cref="TaskCompletionSource{TResult}"/> (<paramref name="tcs"/>). See remarks.
        /// </returns>
        /// <remarks>
        ///   The method always returns the specified <see cref="TaskCompletionSource{TResult}"/> <paramref name="tcs"/>.
        ///   Caller's should <i>not</i> rely on the instance being assigned after completion as it is a common
        ///   pattern for many asynchronous operations to create the TCS while initiating and then removing is
        ///   upon completion.
        /// </remarks>
        public static async Task<TaskCompletionSource<T>> AwaitCompletion<T>(this TaskCompletionSource<T> tcs)
        {
            if (tcs.Task.Status < TaskStatus.RanToCompletion)
            {
                await tcs.Task.ConfigureAwait(false);
            }

            return tcs;
        }
    }
}