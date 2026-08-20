using System.Runtime.CompilerServices;

namespace Pro10
{
    internal class MyInitializer
    {
        [ModuleInitializer]
        public static void init()
        {
            Console.WriteLine("Init is called!!");
        }

        [ModuleInitializer]
        public static void Init2()
        {
            Console.WriteLine("Init2 is called!!");
        }
    }
    internal class AsuncBasic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main is called!!");
        }
    }

}
