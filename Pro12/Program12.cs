using System.Text.RegularExpressions;
using static System.Console;

namespace Pro12
{
    internal class LockBasicBad
    {
        static void Main(string[] args)
        {
            var str = "電話番号は、084-000-0000です。";
            var rgx = new Regex(@"(?<area>\d{2,4})-(?<city>\d{2,4})-(?<local>\d{4})", RegexOptions.ExplicitCapture);
            //var rgx = new Regex(@"(\d{2,4})-(\d{2,4})-(\d{4})",
            //    RegexOptions.ExplicitCapture);
            var match = rgx.Match(str);
            if (match.Success)
            {
                var gp = match.Groups;
                WriteLine($"市外局番：{gp["area"]}");
                WriteLine($"市内局番：{gp["city"]}");
                WriteLine($"加入者番号：{gp["local"]}");
            }
        }
    }
}

