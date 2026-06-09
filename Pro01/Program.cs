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
            var str = "自宅の電話番号は、084-000-0000です。携帯は、080-0000-0000です。";
            Regex rgx = new Regex(@"(\d{2,4})-(\d{2,4})-(\d{4})");
            Match match = rgx.Match(str);

            if (match.Success)
            {
                func($"位置:{match.Index} マッチ文字列:{match.Value}");
            }

            foreach (Group m in match.Groups)
            {
                func(m.Value);
            }
        }

        static void func(object? str)
        {
            Console.WriteLine(str);
        }
    }
}

