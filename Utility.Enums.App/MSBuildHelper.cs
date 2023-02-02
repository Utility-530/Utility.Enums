# nullable enable

using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProjectFileEdit
{
    public static class MSBuildHelper
    {
        public static void SetMsBuildExePath()
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