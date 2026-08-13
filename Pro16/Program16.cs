using System.Text.RegularExpressions;

namespace Pro16
{
    internal class AsyncStream
    {
        static async Task Main(string[] args)
        {
            var str = "住所は〒184-0000 鎌ヶ谷市小野町0-0-0です。\nあなたの住所は〒273-0000 嬬恋市大野町0-9-9ですね。";
            var rgx = new Regex(@"\d{3}-\d{4}");
            var result = rgx.Matches(str);
            foreach (Match m in result)
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
