using System.Text.RegularExpressions;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal enum Season : int
    {
        Spring,
        Summer,
        Autumn,
        Winter,
        All = Spring + Summer + Autumn + Winter
    }
    internal class PassOut
    {
        static void Main(string[] args)
        {
            var str = (Season)Enum.Parse(typeof(Season), "Autumn");
            var num = (Season)Enum.Parse(typeof(Season), "3");
            WriteLine(str);
            WriteLine(num);
        }
    }
}

