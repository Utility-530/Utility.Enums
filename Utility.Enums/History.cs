using System;

namespace Utility.Enums
{
    [Flags]
    public enum History
    {
        None,
        Past = 1,
        Present = 2,
        Future = 4
    }
}