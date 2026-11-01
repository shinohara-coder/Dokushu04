using System.Globalization;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal class PassRefReturn
    {
        static void Main(string[] args)
        {
            var x = 20;
            var y = 10;

            WriteLine((x, y) switch
            {
                (10, 20) => "(10, 20)",
                (20, 10) => "(20, 10)",
                (10, _) => "x=10",
                _ => "???"
            });
        }
    }
}

