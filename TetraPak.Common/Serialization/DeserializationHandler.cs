namespace TetraPak.Serialization
{
    public delegate bool DeserializationHandler(string serialized, out object deserialized, bool resolvedDynamicValue);
}