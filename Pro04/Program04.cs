using System.Text.RegularExpressions;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal enum Season
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
            //var str = (Season)Enum.Parse(typeof(Season), "Autumn");
            //var num = (Season)Enum.Parse(typeof(Season), "3");
            //WriteLine($"{str} - {str.GetType()}");
            //WriteLine($"{num} - {num.GetType()}");

            //var success = Enum.TryParse("ann", out Season s);
            //WriteLine(success ? $"{s}" : "変換失敗");

            var sArray = Enum.GetValues(typeof(Season));
            foreach (var name in sArray)
            {
                WriteLine($"{(int)name} : {name}");
            }
        }
    }
}

