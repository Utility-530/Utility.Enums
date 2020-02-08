using System;
using System.Linq;
using System.Reflection;

namespace UtilityEnum.App
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (Type enumType in Assembly.GetAssembly(typeof(YesNo)).GetTypes()
                          .Where(x => x.IsSubclassOf(typeof(Enum))))
            {
                Console.Write(enumType.Name + ", ");
            }

            Console.ReadLine();
        }
    }
}
