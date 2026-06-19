using System;
using System.Text.RegularExpressions;
using static System.Console;
using static System.Math;

namespace Pro03
{
    class Program
    {
        static void Main(string[] args)
        {
            var sd = new Dictionary<string, string>()
            {
                ["Rose"] = "バラ",
                ["SunFlower"] = "ヒマワリ",
                ["Morning Glory"] = "あさがお"
            };

            foreach (var key in sd.Keys)
            {
                func($"{key} : {sd[key]}");
            }
        }

        static void func(object? str)
        {
            Console.WriteLine(str);
        }
    }
}
