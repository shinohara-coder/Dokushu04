using System;
using System.Text.RegularExpressions;
using static System.Console;
using static System.Math;

namespace Pro03
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "自宅の電話番号は、084-000-0000です。携帯は、080-0000-0000です。";
            var pattern = @"
                (\d{2,4})  # 市外局番
                -(\d{2,4}) # 市内局番
                -(\d{4})   # 加入者番号
                ";

            var rgx = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);
            var match = rgx.Match(str);
            if (match.Success)
            {
                Console.WriteLine($"位置：{match.Index} マッチ文字列：{match.Value}");
                foreach (Group g in match.Groups)
                {
                    Console.WriteLine(g.Value);
                }
            }
        }
    }
}
