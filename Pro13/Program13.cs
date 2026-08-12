using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Pro13
{
    internal class AsyncReurn
    {   
        static void Main(string[] args)
        {
            var msg = "仕事用はwings@example.comです。プライベート用はYAMA@example.comです。";
            //var rgx = new Regex(@"([a-z0-9.!#$%&'*+/=?^_{|}~-]+)@([a-z0-9-]+(\.[a-z0-9-]+)*)", RegexOptions.IgnoreCase);
            var rgx = new Regex(@"([a-z0-9.!#$%&'*+/=?^_{|}~-]+)@([a-z0-9-]+(?:\.[a-z0-9-]+)*)", RegexOptions.IgnoreCase);

            var result = rgx.Matches(msg);
            foreach (Match m in result)
            {
                foreach (Group gp in m.Groups)
                {
                    Console.WriteLine(gp.Value);
                }
                Console.WriteLine();
            }
        }
    }
}
