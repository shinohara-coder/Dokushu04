using System.Text.RegularExpressions;
using static System.Console;

namespace Pro18
{
    internal class NameOfNull
    {
        static void Main(string[] args)
        {
            var str = "にわに3わうらにわに51わにわとりがいる";
            var rgx = new Regex(@"\d{1,}わ");
            var result = rgx.Split(str);
            WriteLine(string.Join("", result));
        }
    }
}

