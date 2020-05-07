using System;
using System.ComponentModel;

namespace UtilityEnum
{
    public enum CompanySuffix
    {
        None,
        Metals = 1,
        Sport,
        Software,
        Manufacturing,
        AG,
        BVBA,
        [Description("Ltd.")]
        Ltd_,
        [Description("Ltd.")]
        Inc_,
        Finance,
        Insurances,
        Clothing,
        Lingerie,
        Outerwear,
        Sprl,
        International,
        Couture,
        Wear,
        Worldwide,
        Productions,
        Sportswear,
        Shirts,
        [Description("Corp.")]
        Corp_,
        XL,
        NV,
        CVBA,
        AAT,
        [Description("Pty.")]
        Pty_,
        SE,
        AD,
        SD,
        KDA,
        [Description("E.I.R.L.")]
        E_I_R_L_,
        Hardware,
        [Description("Language Services")]
        Language__Services,
        Services,
        Logistics,
        Constructions
    }
}
