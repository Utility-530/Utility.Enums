﻿namespace Utility.Enums
{
    public enum Execution : byte
    {
        None,
        NotAttempted = 1,
        Failure,
        Success,
        TooLate
    }
}