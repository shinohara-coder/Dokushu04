using System.Globalization;
using System.IO.Pipes;
using static System.Console;
using static System.Math;
using static System.String;

namespace Pro19
{
    internal class PassArray
    {
        static void Main(string[] args)
        {
            WriteLine(Abs(-452));
            WriteLine(Round(1.732));
            WriteLine(Join(", ", new[] {"Apple","Banana","Orange"}));
        }
    }
}
