//#define DEBUG
using System;
using System.ComponentModel.DataAnnotations;
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
            var str = "仕事用はwings@example.comです。プライベート用はYAMA@example.comです。";
            var rgx = new Regex(@"([a-z0-9.!#$%&'*+/=?^_{|}~-]+)@([a-z0-9-]+(\.[a-z0-9-]+)*)", RegexOptions.IgnoreCase);

            MatchCollection result = rgx.Matches(str);

            foreach (Match m in result)
            {
                //func(m.Value);
                foreach (Group g in m.Groups)
                {
                    func(g.Value);
                }
                func("----------------");
            }

        }

        static void func(object? str)
        {
            Console.WriteLine(str);
        }
    }
}

