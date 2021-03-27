using System;

namespace tetrapak.serialization
{
#if DEBUG
    /// <summary>
    ///   Add this attribute to a JSON serializable class to produce JSON conversion debug output. 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class DebugJsonConversionAttribute : Attribute
    {}
#endif
}