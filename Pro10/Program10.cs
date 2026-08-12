using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Pro10
{
    internal class LockBasicBad
    {
        static void Main(string[] args)
        {
            var str = "自宅の電話番号は、084-000-0000です。携帯は、080-0000-0000です。";
            var rgx = new Regex(@"(\d{2,4})-(\d{2,4})-(\d{4})");
            var result = rgx.Matches(str);
            Console.WriteLine(result.Count);
            Console.WriteLine(result[0]);

            foreach (Match m in result)
            {
                Console.WriteLine($"位置：{m.Index} 長さ：{m.Length} マッチ文字列：{m.Value}");
                foreach (Group g in m.Groups)
                {
                    Console.WriteLine($"インデックス：{g.Index,2} マッチ文字列：{g.Value}");
                }
                Console.WriteLine("-----------------------------------------------");
            }
        }
    }
}