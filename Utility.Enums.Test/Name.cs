namespace UtilityEnum.Test
{
    internal enum Name
    {
        [Names("Timm", "Timothy", "Timothe")]
        Tim,

        [Names("Thomas", "Tomm", "Toto")]
        Tom,

        [Names("John", "Jacky", "J")]
        Jack,

        [Names("Gretch", "Gret")]
        Gretchin
    }
}