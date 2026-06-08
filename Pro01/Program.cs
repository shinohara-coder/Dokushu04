//#define DEBUG
using System;
using System.Globalization;
using SelfCSharp.Chap09.Priority1;
//using MyUtil = SelfCSharp.Chap09.Priority2.MyUtil;

namespace SelfCSharp.Chap09.Priority1
{ 
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            var str = "123456o7890";
            func(str.All(ch => char.IsDigit(ch)));
        }

        static void func(object? str)
        {
            Console.WriteLine(str);
        }
    }
}

