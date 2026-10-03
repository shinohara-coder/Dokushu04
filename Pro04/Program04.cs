using System.Text.RegularExpressions;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal class AsyncReturn
    {
        static void Main(string[] args)
        {
            var str = "自宅の電話番号は、084-000-0000です。携帯は、080-0000-0000です。";
            var rgx = new Regex(@"(\d{2,4})-(\d{2,4})-(\d{4})");
            var match = rgx.Match(str);
            if(match.Success)
            {
                WriteLine($"位置:{match.Index} マッチ文字列:{match.Value}");
                foreach(Group m in match.Groups)
                {
                    WriteLine(m.Value);
                }
            }
        }
    }
}

