using System.Text.RegularExpressions;
using static System.Console;

namespace Pro12
{
    internal static class StringExtesions
    {
        public static string ToTitleCase(this string str)
        {
            return str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower();
        }
    }

    internal class LockBasicBad
    {
        static void Main(string[] args)
        {
            WriteLine("japan".ToTitleCase());
        }
    }
}

