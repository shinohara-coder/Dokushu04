using System.Net;
using System.Text.RegularExpressions;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            var str = "自宅の電話番号は、084-000-0000です。携帯は、080-0000-0000です。";
            var rgx = new Regex(@"(\d{2,4})-(\d{2,4})-(\d{4})");
            var result = rgx.Matches(str);
            WriteLine(result.Count);
            WriteLine(result[0]);

            foreach(Match m in result)
            {
                WriteLine($"位置:{m.Index} 長さ:{m.Length} マッチ文字列:{m.Value}");
                foreach(Group g in m.Groups)
                {
                    WriteLine(g.Value);
                }
                WriteLine("---------------------------");
            }
        }
    }
}

