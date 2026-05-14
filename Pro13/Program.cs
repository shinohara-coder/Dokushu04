using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Pro13
{
    internal class DelegateLambda
    {
        //void ArrayWalk(string[] data, Func<string, string> output)
        //{
        //    foreach (var value in data)
        //    {
        //        Console.WriteLine(output(value));
        //    }
        //}

        static void Main(string[] args)
        {
            //string[] data = { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            //var dm = new DelegateLambda();
            //dm.ArrayWalk(data, d => $"[{d}]");

            //dm.ArrayWalk(data, d => $"[{d.Substring(0, 4)}]");
            var msg = "田中一郎";
            Action show = () => { Console.WriteLine(msg); };
            show();
        }
    }

}
