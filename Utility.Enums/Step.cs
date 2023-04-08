using System;
using System.Collections.Generic;
using System.Text;

namespace Utility.Enums
{
    [Flags]

    public enum Step
    {
        None,
        Backward = 1,
        Forward = 2,
        Walk = 4,
        Wait = 8,
        All = Backward | Forward | Walk | Wait

    }
}
