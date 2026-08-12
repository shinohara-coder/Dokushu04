using System.Net;
using System.Text.RegularExpressions;

namespace Pro15
{
    internal class DelegeteUse
    {
        static void Main(string[] args)
        {
            var str = "サポートサイトはhttps://wings.msn.to/です。";
            var rgx = new Regex(@"http(s)?://([\w-]+\.)+[\w-]+(/[a-z_0-9-./?%&=]*)?", RegexOptions.IgnoreCase);

            var match = rgx.Match(str);
            if (match.Success)
            {
                foreach (Group gp in match.Groups)
                {
                    Console.WriteLine(gp.Value);
                }
            }
        }
    }
}