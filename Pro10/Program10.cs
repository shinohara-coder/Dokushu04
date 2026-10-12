using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using static System.Console;

namespace Pro10
{
    internal class StringLengthComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return x.Length - y.Length;
        }
    }

    internal class MyAppExceptionClient
    {
        static void Main(string[] args)
        {
            var list = new List<string>
            {
                "ばら",
                "ひまわり",
                "あざみ",
                "チューリップ",
                "きく"
            };

            //list.Sort(new StringLengthComparer());
            list.Sort((x, y) => y.Length - x.Length);

            foreach (var s in list)
            {
                WriteLine(s);
            }
        }
    }
}