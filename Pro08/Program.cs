using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Pro06
{
    internal class DelegeteNoUse
    {
        void ArrayWalk(string[] data)
        {
            foreach (var value in data)
            {
                Console.WriteLine($"[{value}]");
            }
        }

        static void Main(string[] args)
        {
            string[] data = { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var nu = new DelegeteNoUse();
            nu.ArrayWalk(data);
        }
    }
}
