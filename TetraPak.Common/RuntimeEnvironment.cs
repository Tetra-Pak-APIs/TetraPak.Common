using System;

namespace TetraPak
{
    [Flags]
    public enum RuntimeEnvironment
    {
        Unknown = 0,
        Sandbox = 10,
        Development = 20,
        
        // "'"migration" tends to have a lot of names ...
        Migration = 30,
        Test = Migration,
        Testing = Migration,
        Staging = Migration,
        
        Production = 40,
    }
}