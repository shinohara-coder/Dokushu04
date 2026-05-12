using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Pro09
{
    delegate void OutputProcess(string str);
    internal class DelegeteUse
    {
        void ArrayWalk(string[] data, OutputProcess output)
        {
            foreach (var value in data)
            {
                output(value);
            }
        }

        static void AddQuote(string data)
        {
            Console.WriteLine($"[{data}]");
        }

        static void AddKakko(string data)
        {
            Console.WriteLine($"「{data}」");
        }

        static void Main(string[] args)
        {
            string[] data = { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var du = new DelegeteUse();
            OutputProcess proc = AddQuote;
            du.ArrayWalk(data, proc);
            du.ArrayWalk(data, AddKakko);
        }
    }
}
