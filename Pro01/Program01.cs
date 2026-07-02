//#define DEBUG
using SelfCSharp.Chap09.Priority1;
using System;
using System.Collections;
using System.Globalization;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
using Pro01.DateTimeExtensions;
//using MyUtil = SelfCSharp.Chap09.Priority2.MyUtil;

namespace SelfCSharp.Chap09.Priority1
{
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            DateTime targetDate = DateTime.Now;
            if (targetDate.IsToday())
            {
                Console.WriteLine("今日届いたデータです！");
            }
        }
    }
}


