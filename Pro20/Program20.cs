using System.Globalization;
using System.Runtime.CompilerServices;
using static System.Console;

namespace Pro20
{
    internal class MyInitializer
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.WriteLine("Init is called!!");
        }

        [ModuleInitializer]
        public static void Init2()
        {
            Console.WriteLine("Init2 is called!!");
        }
    }

    internal class ModuleInit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main is called!!");
        }
    }
}
