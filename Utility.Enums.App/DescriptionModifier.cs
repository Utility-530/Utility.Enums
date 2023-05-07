# nullable enable

using Microsoft.Build.Evaluation;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ProjectFileEdit
{
    public class DescriptionCreator
    {
        public static string Create(Assembly assembly, Predicate<Type>? predicate = null, string? prependage = null, string? appendage = null)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append(prependage);

            foreach (Type aType in assembly.GetTypes().Where(x => predicate?.Invoke(x) != false).OrderBy(a => a.Name))
            {
                stringBuilder.Append(aType.Name + ", ");
            }

            stringBuilder.Remove(stringBuilder.Length - 2, 2);
            stringBuilder.Append(appendage);

            return stringBuilder.ToString();
        }

        public static string CreateForMarkdown(Assembly assembly, Predicate<Type>? predicate = null, string? prependage = null, string? appendage = null)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append(prependage);

            foreach (Type aType in assembly.GetTypes().Where(x => predicate?.Invoke(x) != false).OrderBy(a => a.Name))
            {
                stringBuilder.Append("- " +aType.Name + Environment.NewLine);
            }

            stringBuilder.Remove(stringBuilder.Length - 2, 2);
            stringBuilder.Append(Environment.NewLine + appendage);

            return stringBuilder.ToString();
        }
    }

    public class DescriptionModifier
    {
        public static string ModifyDescription(string description, FileInfo fileInfo)
        {
            var parent = fileInfo.Directory.Parent;
            var name = System.IO.Path.ChangeExtension(fileInfo.Name, "csproj");
            var file = parent.GetFiles(name, System.IO.SearchOption.AllDirectories).Single();

            SetDescription(description, file.FullName);

            return description;

            static void SetDescription(string description, string projectPath)
            {
                MSBuildHelper.SetMsBuildExePath();

                var project = new Project(projectPath);

                project.SetProperty("Description", description);

                project.Save();
            }
        }

        public static Predicate<Type> EnumPredicate() => new Predicate<Type>(x => x.IsSubclassOf(typeof(Enum)));
    }
}