using System.Numerics;
using static System.Console;

namespace SelfCSharp.Chap02
{
    internal class PassRefArray
    {
        static void Main(string[] args)
        {
            //var t = ("C#", "Java", "Visual Basic");
            //var t = ("Python", "Ruby", "C++");
            var t = ("Kotlin", "TypeScript", "anh");
            WriteLine(t switch
            {
                ("C#", "Java", "Visual Basic") => "コンパイル言語",
                ("Python", "Ruby", var lang) => $"インタプリタ言語：{lang}",
                ("Kotlin", "TypeScript", _) => "トランスコンパイル言語",
                _ => "その他"
            });
        }
    }
}


