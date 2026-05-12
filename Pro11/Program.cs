using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Pro10
{
    delegate void OutputProcess(string str);
    internal class DelegeteUseCounter
    {
        void ArrayWalk(string[] data, OutputProcess output)
        {
            foreach (var value in data)
            {
                output(value);
            }
        }

        static void Main(string[] args)
        {
            string[] data = { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var du = new DelegeteUseCounter();
            var c = new Counter();
            du.ArrayWalk(data, c.AddLength);
            Console.WriteLine(c.Result);
        }
    }

    internal class Counter
    {
        public int Result { get; private set; }

        public void AddLength(string value)
        {
            Result += value.Length;
        }
    }

}
