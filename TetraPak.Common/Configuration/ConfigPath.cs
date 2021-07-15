using System.Diagnostics;

namespace TetraPak.Configuration
{
    [DebuggerDisplay("{" + nameof(StringValue) + "}")]
    public class ConfigPath : MultiStringValue
    {
        public const string Separator = ":";
        
        protected override string OnGetSeparator() => Separator;

        public static implicit operator ConfigPath(string s) => new(s);
        
        public ConfigPath(string stringValue) : base(stringValue)
        {
        }

        public ConfigPath(string[] items) : base(items)
        {
        }
    }
}