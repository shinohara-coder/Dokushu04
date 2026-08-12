using System.Text.RegularExpressions;

namespace Pro14
{
    internal class DelegeteNoUse
    {
        static async Task Main(string[] args)
        {
            var str = "自宅の電話番号は、084-111-2222です。携帯は、080-333-4444です。";
            //var rgx = new Regex(@"(\d{2,4})-(\d{2,4})-(\d{4})", RegexOptions.ExplicitCapture);
            var rgx = new Regex(@"(\d{2,4})-(\d{2,4})-(\d{4})");

            var result = rgx.Matches(str);
            foreach (Match m in result)
            {
                Console.WriteLine(m.Value);
                var gp = m.Groups;
                Console.WriteLine($"市外局番：{gp[1]}");
                Console.WriteLine($"市内局番：{gp[2]}");
                Console.WriteLine($"加入者番号：{gp[3]}");
                Console.WriteLine();
            }
        }
    }
}
