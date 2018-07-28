using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace UtilityEnum
{
    public enum Sport
    {
        [Description("Football")]
        Football,
        [Description("Basketball")]
        Basketball,
        [Description("Tennis")]
        Tennis,
        [Description("Ice hockey")]
        IceHockey,
        [Description("Horse Racing")]
        HorseRacing,
        [Description("Rugby")]
        Rugby,
        [Description("American Football")]
        AmericanFootball

    }
}
