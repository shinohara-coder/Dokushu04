//#define DEBUG
using System;
using System.Globalization;
using System.Security.AccessControl;
using SelfCSharp.Chap09.Priority1;
//using MyUtil = SelfCSharp.Chap09.Priority2.MyUtil;

namespace SelfCSharp.Chap09.Priority1
{ 
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            func(string.Format(
                "カスタム(補完なし) :{0:#,###.###}", 123456123.789));
        }

        static void func(object? str)
        {
            Console.WriteLine(str);
        }
    }
}

