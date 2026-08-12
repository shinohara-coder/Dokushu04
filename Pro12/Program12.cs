using System.Text.RegularExpressions;

namespace Pro10
{
    internal class AsuncBasic
    {
        static void Main(string[] args)
        {
            var str = "自宅の電話番号は、084-111-2222です。携帯は、080-333-4444です。";
            var rgx = new Regex(@"(?<area>\d{2,4})-(?<city>\d{2,4})-(?<local>\d{4})", RegexOptions.ExplicitCapture);

            var result = rgx.Matches(str);
            foreach (Match m in result)
            {
                Console.WriteLine(m.Value);
                var gp = m.Groups;
                Console.WriteLine($"市外局番：{gp["area"]}");
                Console.WriteLine($"市内局番：{gp["city"]}");
                Console.WriteLine($"加入者番号：{gp["local"]}");
                Console.WriteLine();
            }
        }
    }

}
