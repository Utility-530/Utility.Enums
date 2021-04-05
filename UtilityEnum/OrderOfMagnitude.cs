using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityEnum
{
    public enum OrderOfMagnitude : byte
    {
        None,
        Subatomic = 1,
        AtomicToCellular,
        CellularToHuman,
        HumanToAstronomical,
        Astronomical,
    }
}
