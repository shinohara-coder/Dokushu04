using System.Globalization;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal class LockBasicBad
    {
        static void Main(string[] args)
        {
            var full = "ＷＩＮＧＳ";
            var half = "WINGS";

            var ci = CultureInfo.CurrentCulture.CompareInfo;
            WriteLine(ci.Compare(full, half, CompareOptions.Ordinal));
            WriteLine(ci.Compare(full, half, CompareOptions.IgnoreWidth));

            WriteLine("-------------------------");

            var hiragana = "ぷろじぇくと";
            var katakana = "プロジェクト";
            WriteLine(ci.Compare(hiragana, katakana, CompareOptions.Ordinal));
            WriteLine(ci.Compare(hiragana, katakana, CompareOptions.IgnoreKanaType));
        }
    }
}


