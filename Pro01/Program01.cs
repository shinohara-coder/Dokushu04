using System.Diagnostics;
using System.Text;

namespace SelfCSharp.Chap09.Priority1
{
    internal class StringLengthComparer: IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            //return x.Length - y.Length;
            return y.Length - x.Length;
        }
    }
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            var dic = new SortedDictionary<string, string>(new StringLengthComparer())
            {
                ["Rose"] = "バラ",
                ["Sunflower"] = "ひまわり",
                ["Morning Glory"] = "あさがお",
                ["Tulip"] = "チューリップ"
            };

            foreach (var key in dic.Keys)
            {
                Console.WriteLine($"{key} : {dic[key]}");
            }
        }
    }
}


