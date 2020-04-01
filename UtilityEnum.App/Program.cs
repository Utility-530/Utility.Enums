using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Build.Evaluation;
using ProjectFileEdit;

namespace UtilityEnum.App
{
    class Program
    {
        private static readonly string AppendDescription = "\nNames Attribute(and helper methods) to match strings to enums and CountryInfo attribute(and helper methods) to match strings to countries and provide country information.";

        private static void Main(string[] args)
        {

            var description = new DescriptionModifier
            {
                Appendage = " enums." + Environment.NewLine + AppendDescription
            }.ModifyDescription(typeof(YesNo), DescriptionModifier.EnumPredicate());

            Console.WriteLine(description);
            Console.ReadLine();
        }
    }
}
