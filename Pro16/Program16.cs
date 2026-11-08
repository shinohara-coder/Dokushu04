using System.Text.RegularExpressions;
using static System.Console;

internal class Util
{
    public static void Run()
    {
        WriteLine("Util is running.");
    }
}

namespace Pro16.Util
{
    internal class MySingleton
    {
        static void Main(string[] args)
        {
            global::Util.Run();
        }
    }
}
