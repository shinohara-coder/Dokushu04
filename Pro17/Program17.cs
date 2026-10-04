using System.Text.RegularExpressions;
using static System.Console;

namespace Pro17
{
    internal class DelegateAnonymous
    {
        static void Main(string[] args)
        {
            var str = "メールアドレスはwings@example.comです。";
            var rgx = new Regex(@"([a-z0-9.!#$%&'*+/=?^_{|}~-]+)@([a-z0-9-]+(\.[a-z0-9-]+)*)");
            var match = rgx.Match(str);
            if(match.Success)
            {
                foreach(Group sub in match.Groups)
                {
                    WriteLine(sub.Value);
                }
            }

            WriteLine(rgx.Replace(str, m => m.Value.ToUpper()));
        }
    }
}
