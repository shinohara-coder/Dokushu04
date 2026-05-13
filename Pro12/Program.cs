using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Pro10
{
    internal class DelegateAnonymous
    {
        void ArrayWalk(string[] data, Func<string, string> output)
        {
            foreach (var value in data)
            {
                Console.WriteLine(output(value));
            }
        }

        static void Main(string[] args)
        {
            string[] data = { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var dm = new DelegateAnonymous();
            dm.ArrayWalk(data, delegate (string d)
            {
                return $"[{d}]";
            });

            dm.ArrayWalk(data, delegate (string d) { return $"[{d.Substring(0, 4)}]"; });
        }
    }

}
