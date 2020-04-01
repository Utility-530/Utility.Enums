# nullable enable
using System;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.Build.Evaluation;

namespace ProjectFileEdit
{


    public class DescriptionModifier
    {
        public string Prependage { get; set; } = string.Empty;
        public string Appendage { get; set; } = string.Empty;

        public string ModifyDescription(Type type, Predicate<Type>? predicate = null)
        {
           // MSBuildLocator.RegisterDefaults();
            Assembly assembly = Assembly.GetAssembly(type);

            var description = CreateDescription(predicate ??= new Predicate<Type>(x => true), assembly);
            var dir = new System.IO.FileInfo(assembly.Location);
            var parent = dir.Directory.Parent.Parent.Parent.Parent;
            var name = System.IO.Path.ChangeExtension(dir.Name,"csproj");
            var file = parent.GetFiles(name,System.IO.SearchOption.AllDirectories).Single();
            SetDescription(description, file.FullName);

            return description;


            string CreateDescription(Predicate<Type> predicate, Assembly assembly)
            {
                var stringBuilder = new StringBuilder();

                stringBuilder.Append(Prependage);

                foreach (Type aType in assembly.GetTypes().Where(x => predicate(x)))
                {
                    stringBuilder.Append(aType.Name + ", ");
                }

                stringBuilder.Remove(stringBuilder.Length - 2, 2);
                stringBuilder.Append(Appendage);

                return stringBuilder.ToString();
            }


            static void SetDescription(string description, string projectPath)
            {
                MSBuildHelper.SetMsBuildExePath();

                var project = new Project(projectPath);

                project.SetProperty("Description", description);

                project.Save();
            }

            //static void fsd()
            //{
            //    string solutionPath = @"C:\Users\...\PathToSolution\MySolution.sln";
            //    var msWorkspace =new Microsoft.Build.Evaluation.So(,)

            //    var solution = msWorkspace.OpenSolutionAsync(solutionPath).Result;
            //    foreach (var project in solution.Projects)
            //    {

            //    }
            //}
        }


        public static Predicate<Type> EnumPredicate() => new Predicate<Type>(x => x.IsSubclassOf(typeof(Enum)));

    }
}