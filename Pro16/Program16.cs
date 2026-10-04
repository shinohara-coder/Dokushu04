using System.Text.RegularExpressions;
using static System.Console;

namespace Pro16
{
    internal class DelegeteMultiResult
    {
        static void Main(string[] args)
        {
            var str = "仕事用はwings@example.comです。";
            var rgx = new Regex(@"(?<localName>[a-z0-9.!#$%&'*+/=?^_{|}~-]+)@(?<domain>[a-z0-9-]+(\.[a-z0-9-]+)*)", RegexOptions.IgnoreCase);
            WriteLine(rgx.Replace(str, "${domain}の${localName}"));
        }
    }
}
