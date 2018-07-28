using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityEnum
{
    public enum SportsBettingContract
    {
        None,
        Home,
        Draw,
        Away,
        Under,
        Over,
        AsianHome,
        AsianAway
    }


    public enum SportsBettingMarket
    {
        //[Description("winner")]
        Winner
    }


    public enum OddSide { None = 0, Back = 1, Lay = 2 }


}
