using System;

namespace TetraPak.Serialization
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ImplementedAsAttribute : Attribute
    {
        public Type Type { get; }

        public ImplementedAsAttribute(Type type)
        {
            Type = type;
        }
    }
}