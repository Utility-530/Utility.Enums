using System.ComponentModel;

namespace Utility.Enums
{
    public enum Sport : byte
    {
        None,

        [Description("Football")]
        Football = 1,

        [Description("Soccer")]
        Soccer,

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