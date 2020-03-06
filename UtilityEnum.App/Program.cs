using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Build.Evaluation;

namespace UtilityEnum.App
{
    class Program
    {
        private static string AppendDescription = "\nNames Attribute(and helper methods) to match strings to enums and CountryInfo attribute(and helper methods) to match strings to countries and provide country information.";

        static void Main(string[] args)
        {
            var stringBuilder = new StringBuilder();
            foreach (Type enumType in Assembly.GetAssembly(typeof(YesNo)).GetTypes()
                          .Where(x => x.IsSubclassOf(typeof(Enum))))
            {
                stringBuilder.Append(enumType.Name + ", ");
            }

            stringBuilder.Remove(stringBuilder.Length - 2, 2);

            Console.Write(stringBuilder.ToString());

            SetClipboard(stringBuilder.ToString());

            stringBuilder.Append(" enums.");
            stringBuilder.Append(AppendDescription);
            SetDescription(stringBuilder.ToString());

            Console.ReadLine();
        }


        static void SetDescription(string description)
        {
            SetMsBuildExePath();

            var project = new Project("../../../../UtilityEnum/UtilityEnum.csproj");

            project.SetProperty("Description", description);

            project.Save(); 
        }


        /// <summary>
        /// Sets clipboard to value.
        /// </summary>
        /// <param name="value">String to set the clipboard to.</param>
        public static void SetClipboard(string value)
        {
            if (value == null)
                throw new ArgumentNullException("Attempt to set clipboard with null");

            Process clipboardExecutable = new Process();
            clipboardExecutable.StartInfo = new ProcessStartInfo // Creates the process
            {
                RedirectStandardInput = true,
                FileName = @"clip",
            };
            clipboardExecutable.Start();

            clipboardExecutable.StandardInput.Write(value); // CLIP uses STDIN as input.
            // When we are done writing all the string, close it so clip doesn't wait and get stuck
            clipboardExecutable.StandardInput.Close();

        }

        private static void SetMsBuildExePath()
        {
            try
            {
                var startInfo = new ProcessStartInfo("dotnet", "--list-sdks")
                {
                    RedirectStandardOutput = true
                };

                var process = Process.Start(startInfo);
                process.WaitForExit(1000);

                var output = process.StandardOutput.ReadToEnd();
                var sdkPaths = Regex.Matches(output, "([0-9]+.[0-9]+.[0-9]+) \\[(.*)\\]")
                    .OfType<Match>()
                    .Select(m => System.IO.Path.Combine(m.Groups[2].Value, m.Groups[1].Value, "MSBuild.dll"));

                var sdkPath = sdkPaths.Last();
                Environment.SetEnvironmentVariable("MSBUILD_EXE_PATH", sdkPath);
            }
            catch (Exception exception)
            {
                Console.Write("Could not set MSBUILD_EXE_PATH: " + exception);
            }
        }
    }
}
