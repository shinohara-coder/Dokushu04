using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Pro10
{
    delegate void OutputProcess(string str);
    internal class DelegeteMulti
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

        static void Front4(string data)
        {
            Console.WriteLine(data.Substring(0, 4));
        }

        static void Main(string[] args)
        {
            string[] data = { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var dm = new DelegeteMulti();
            OutputProcess? proc = AddQuote;
            proc += Front4;
            dm.ArrayWalk(data, proc);

            Console.WriteLine("----------------");

            proc -= Front4;
            dm.ArrayWalk(data, proc);
        }
    }

}
