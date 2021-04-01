using System;
using System.Linq;
using TetraPak;

namespace TetraPak.Serialization
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SerializeIgnorePropertiesAttribute : Attribute
    {
        internal string[] PropertyNames { get; }
        
        public SerializeIgnorePropertiesAttribute(params string[] propertyNames)
        {
            PropertyNames = propertyNames.Select(i => StringHelper.ToLowerInitial(i)).ToArray();
        }
    }
}