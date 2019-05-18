using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityEnum.Test
{
    enum Name
    {
        [Names("Timm","Timothy","Timothe")]
        Tim,
        [Names("Thomas","Tomm","Toto")]
        Tom,
        [Names("John","Jacky","J")]
        Jack,
        [Names("Gretch","Gret")]
        Gretchin

    }
}
