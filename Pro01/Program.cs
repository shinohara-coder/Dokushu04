//#define DEBUG
using System;
using System.Globalization;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
using SelfCSharp.Chap09.Priority1;
//using MyUtil = SelfCSharp.Chap09.Priority2.MyUtil;

namespace SelfCSharp.Chap09.Priority1
{ 
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            var headers = new List<string> { "得意先コード", "得意先名", "電話番号", "得意先名" };
            var duplicates = headers
                .GroupBy(h => h, StringComparer.Ordinal)
                .Where(g => g.Count() > 1)
                .Select(g => $"「{g.Key}」")
                .ToList();
            
            foreach (var v in duplicates)
            {
                func(v);
            }

        }

        static void func(object? str)
        {
            Console.WriteLine(str);
        }
    }
}

