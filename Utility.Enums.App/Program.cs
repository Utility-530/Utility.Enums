using ProjectFileEdit;
using System;
using System.Linq;
using System.Reflection;
using Utility.Enums;

namespace UtilityEnum.App
{
    internal class Program
    {
        private const string AppendDescription = "\nNames Attribute(and helper methods) to match strings to enums and CountryInfo attribute(and helper methods) to match strings to countries and provide country information.";

        private static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetAssembly(typeof(YesNo));

            var description = DescriptionCreator.Create(
                assembly,
                DescriptionModifier.EnumPredicate(),
                appendage: " enums." + Environment.NewLine + AppendDescription);

            Console.WriteLine(description);


            //var lineSeparated = DescriptionCreator.CreateForMarkdown(
            //    assembly,
            //    DescriptionModifier.EnumPredicate(),
            //    appendage: " enums." + Environment.NewLine + AppendDescription);
            //Console.WriteLine(lineSeparated);
            
            //Console.ReadLine();


            var dir = new System.IO.FileInfo(assembly.Location);
            var parent = dir.Directory.Parent.Parent.Parent.Parent;
            var name = System.IO.Path.ChangeExtension(dir.Name, "csproj");
            var file = parent.GetFiles(name, System.IO.SearchOption.AllDirectories).Single();

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("modifying...");
            try
            {
                DescriptionModifier.ModifyDescription(description, file);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("completed");
            Console.ReadLine();
        }
    }
}