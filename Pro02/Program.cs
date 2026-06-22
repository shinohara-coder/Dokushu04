//#define DEBUG
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
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
            var dic = new Dictionary<string, string>()
            {
                ["Rose"] = "バラ",
                ["SunFlower"] = "ひまわり",
                ["Morning Glory"] = "あさがお"
            };

            //func(dic.Count);
            //func(dic.ContainsKey("Rose"));
            //func(dic.ContainsValue("バラ"));

            //dic.TryGetValue("SunFlower", out var name);
            //func(name);

            //func("--------------");
            //foreach (var key in dic.Keys)
            //{
            //    func($"{key} : {dic[key]}");
            //}

            //func("--------------");
            //foreach (var v in dic.Values)
            //{
            //    func(v);
            //}

            dic.Remove("Rose");

            foreach (var m in dic)
            {
                func(m.ToString());
            }
        }

        static void func(object? str)
        {
            Console.WriteLine(str);
        }
    }
}

