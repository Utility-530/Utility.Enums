using System;

namespace Utility.Enums
{
    [Flags]
    public enum Possession : byte
    {
        NeverHad = 0,
        Had = 1,
        Got = 2,
        Getting = 4,
        WillHave = 16,
        Lost = 32
    }
}