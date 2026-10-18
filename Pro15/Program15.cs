using System.Text.RegularExpressions;
using static System.Console;

namespace Pro15
{
    internal class MyProcess
    {
        public MyProcess()
        {
            Console.WriteLine("constructor");
        }

        ~MyProcess()
        {
            Console.WriteLine("finalizer");
        }
    }

    internal class DelegeteMulti
    {
        static void Main(string[] args)
        {
            var mp = new MyProcess();
        }
    }
}