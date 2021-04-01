using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TetraPak
{
#if DEBUG
    [DebuggerDisplay("{" + nameof(DebugDisplay) + "}")]
#endif
    public class EnumOutcome<T> : Outcome<IReadOnlyCollection<T>>
    {
        /// <summary>
        ///   Gets the total available number of entities.
        /// </summary>
        public int TotalCount { get; }

        /// <summary>
        ///   Gets the number of entities in the outcome.
        /// </summary>
        public int Count { get; }

#if DEBUG
        public string DebugDisplay => $"Count={Count}; Total={TotalCount}";
#endif

        public static EnumOutcome<T> Success(IReadOnlyCollection<T> value, int totalCount) 
            => new EnumOutcome<T>(true, value, totalCount);
        
        public new static EnumOutcome<T> Fail() 
            => new EnumOutcome<T>(false, default, 0, null);
        
        public new static EnumOutcome<T> Fail(Exception exception) 
            => new EnumOutcome<T>(false, default, 0, exception);
        
        public static EnumOutcome<T> Fail(T[] value, Exception exception) 
            => new EnumOutcome<T>(false, value, 0, exception);

        protected EnumOutcome(
            bool result, 
            IReadOnlyCollection<T> value, 
            int totalCount, 
            Exception exception = null) 
        : base(result, value, exception)
        {
            TotalCount = totalCount;
            Count = value?.Count ?? 0;
        }
    }
}