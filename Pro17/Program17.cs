using System.Text.RegularExpressions;

namespace Pro17
{
    internal class DelegateMulti
    {
        static void Main(string[] args)
        {
            var str = "お問い合わせはhoge@exmample.comまで";
            var rgx = new Regex(@"([a-z0-9.!#$%&'*+/=?^_{|}~-]+)@([a-z0-9-]+(?:\.[a-z0-9-]+)*)", RegexOptions.IgnoreCase);
            Console.WriteLine(rgx.Replace(str, "<a href=\"mailto: $0\">$0</a>"));
        }
    }
}
