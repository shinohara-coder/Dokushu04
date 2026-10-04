using System.Text.RegularExpressions;
using static System.Console;

namespace Pro15
{
    internal class DelegeteMulti
    {
        static void Main(string[] args)
        {
            var str = "サポートサイトはhttps://wings.msn.to/です。";
            var rgx = new Regex(@"http(s)?://([\w-]+\.)+[\w-]+(/[a-z_0-9-./?%&=]*)?",
                RegexOptions.IgnoreCase);

            var match = rgx.Match(str);
            if (match.Success)
            {
                foreach (Group sub in match.Groups)
                {
                    foreach (Capture capture in sub.Captures)
                    {
                        WriteLine(capture.Value);
                    }
                }
            }

            //WriteLine(rgx.Replace(str, "<a href='$2'>$2/a>"));
        }
    }
}