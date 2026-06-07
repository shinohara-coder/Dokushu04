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
            var str1 = "wings";
            var str2 = "WINGS";

            func(str1.Equals(str2, StringComparison.OrdinalIgnoreCase));
            func(string.Compare(str1, str2, StringComparison.OrdinalIgnoreCase));
        }

        static void func(object str)
        {
            Console.WriteLine(str);
        }
    }
}

