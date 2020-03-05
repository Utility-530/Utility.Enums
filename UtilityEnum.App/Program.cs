using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace UtilityEnum.App
{
    class Program
    {
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

            Console.ReadLine();
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

            return;
        }
    }
}
