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
        public virtual int Count { get; }

#if DEBUG
        public string DebugDisplay => $"Count={Count}; Total={TotalCount}";
#endif

        public static EnumOutcome<T> Success(IReadOnlyCollection<T> value, int totalCount = 0) 
            => new EnumOutcome<T>(true, value, totalCount == 0 ? value.Count : totalCount);
        
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

    public class ChunkOutcome<T> : EnumOutcome<T>
    {
        public ReadChunk Chunk { get; }

        public override int Count => Chunk.Count;

        public int Skip => Chunk.Skip;
        
        public static ChunkOutcome<T> Success(IReadOnlyCollection<T> value, ReadChunk chunk, int totalCount = 0) 
            => new ChunkOutcome<T>(true, value, chunk, totalCount == 0 ? value.Count : totalCount);

        protected ChunkOutcome(
            bool result, 
            IReadOnlyCollection<T> value,
            ReadChunk chunk,
            int totalCount, 
            Exception exception = null) 
        : base(result, value, totalCount, exception)
        {
            Chunk = chunk;
        }
    }
}