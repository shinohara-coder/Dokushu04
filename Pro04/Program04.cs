using System.Text.RegularExpressions;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal class AsyncReturn
    {
        static void Main(string[] args)
        {
            var tel = new[] { "080-0000-0000", "084-000-0000", "184-0000" };
            //var rgx = new Regex(@"\d{2,4}-\d{2,4}-\d{4}");
            var rgx = new Regex("84-");
            foreach (var t in tel)
            {
                WriteLine(rgx.IsMatch(t) ? t : "アンマッチ");
            }
        }
    }
}

