using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;

namespace Pro15
{
    internal class PassReIn
    {
        static void Main(string[] args)
        {
            //var t = ("C#", "Java", "Visual Basic");
            //var t = ("Python", "Ruby", "PHP");
            var t = ("Kotlin", "TypeScript", "C++");
            Console.WriteLine(t switch
            {
                ("C#", "Java", "Visual Basic") => "コンパイル言語",
                ("Python", "Ruby", var lang) => $"インタプリター言語{lang}",
                ("Kotlin", "TypeScript", _) => "トランスコンパイル言語",
                _ => "その他"
            });
        }
    }
}
