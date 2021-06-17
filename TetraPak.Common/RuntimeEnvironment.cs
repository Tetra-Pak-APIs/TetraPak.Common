using System;

namespace TetraPak
{
    [Flags]
    public enum RuntimeEnvironment
    {
        Production = 10,
        Migration = 20,
        Testing = Migration,
        Staging = Migration,
        Development = 30,
        Sandbox = 40
    }
}