using System;
using System.Linq;

namespace tetrapak.serialization
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