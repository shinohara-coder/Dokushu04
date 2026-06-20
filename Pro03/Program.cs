using System;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using static System.Console;
using static System.Math;

namespace Pro03
{
    internal class StringLengthComparer : IComparer<string>
    {
       public int Compare(string? x, string? y)
        {
            return x.Length - y.Length;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            var sd = new SortedDictionary<string, string>()
            {
                ["Rose"] = "バラ",
                ["SunFlower"] = "ヒマワリ",
                ["Morning Glory"] = "あさがお",
                ["Lily"] = "ユリ"
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
