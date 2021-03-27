namespace tetrapak.serialization
{
    public delegate bool DeserializationHandler(string serialized, out object deserialized, bool resolvedDynamicValue);
}