namespace TetraPak.Serialization
{
    /// <summary>
    ///   Used by the <see cref="DynamicEntitySafeJsonConverter{T}"/> to deal with inconsistent api that
    ///   sometimes return objects/arrays as value types (such as a string).
    /// </summary>
    public interface IFlexibleEntity
    {
        void SetValue(object items);
    }
}