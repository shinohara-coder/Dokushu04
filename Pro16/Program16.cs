using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;

namespace Pro16
{
    internal class PassOUt
    {
        static void Main(string[] args)
        {
            var p = new Person
            {
                FirstName = "一郎",
                LastName = "田中"
            };

            Console.WriteLine(p switch
            {
                { FirstName: "一郎", LastName: var ln} => $"{ln}イチくん、こんにちは！",
                { FirstName: "次郎", LastName: "山田"} => "山田次郎くんですね。",
                _ => "どなたですか？"
            });
        }
    }
}
