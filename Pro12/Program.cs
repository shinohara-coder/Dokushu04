using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Text;

namespace Pro10
{
    internal class DelegateAnonymous
    {
        

        static void Main(string[] args)
        {
            const string STR = "いろは";
            var result = "";
            Stopwatch sw1 = Stopwatch.StartNew();
            for (int i = 0; i < 1e+5; i++)
            {
                result += STR;
            }
            sw1.Stop();
            Console.WriteLine($"所要時間：{sw1.ElapsedMilliseconds}ミリ秒");

            result = "";

            var builder = new StringBuilder();
            Stopwatch sw2 = Stopwatch.StartNew();
            for (int i = 0; i < 1e+5; i++)
            {
                builder.Append(STR);
            }
            result = builder.ToString();
            sw2.Stop();
            Console.WriteLine($"所要時間：{sw2.ElapsedMilliseconds}ミリ秒");
        }
    }

}
