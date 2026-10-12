using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using static System.Console;

namespace Pro08
{
    internal class StringLengthComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return y.Length - x.Length;
        }
    }


    internal class MySingleton
    {
        static void Main(string[] args)
        {
            var d = new SortedDictionary<string, string>(new StringLengthComparer())
            {
                ["Rose"] = "バラ",
                ["Sunflower"] = "ひまわり",
                ["Morning Glory"] = "あさがお",
                ["Cherry Blossoms"] = "サクラ",
                ["Tulip"] = "チューリップ"
            };

            foreach (var key in d.Keys)
            {
                WriteLine($"{key} : {d[key]}");
            }
        }
    }
}

