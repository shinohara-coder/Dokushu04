//#define DEBUG
//#undef DEBUG
using System.Diagnostics;
using System.Text.RegularExpressions;
using static System.Console;

namespace Pro08
{
    internal class TryCatchOrder
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, string>()
            {
                ["Rose"] = "バラ",
                ["Sunflower"] = "ひまわり",
                ["Morning Glory"] = "あさがお"
            };

            WriteLine(dic.Count);
            WriteLine(dic.ContainsKey("Rose"));
            WriteLine(dic.ContainsValue("バラ"));

            dic.TryGetValue("Rose", out var name);
            WriteLine(name);

            dic.Add("Tulip", "チューリップ");
            dic["Sunflower"] = "向日葵";

            foreach (var key in dic.Keys)
            {
                WriteLine($"{key}：{dic[key]}");
            }

            foreach (var d in dic.Values)
            {
                WriteLine(d);
            }

            dic.Remove("Rose");

            foreach (var m in dic)
            {
                WriteLine($"{m.Key}：{m.Value}");
            }
        }
    }
}
