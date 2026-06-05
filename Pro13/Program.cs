using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Pro13
{
    internal class DelegateLambda
    {
        static void Main(string[] args)
        {
            var data1 = new[] { "い", "ろ", "は" };
            var data2 = new[] { "い", "ろ", "は" };
            Console.WriteLine(data2 == data1);
            Console.WriteLine(data2.Equals(data2));
            Console.WriteLine(data1.SequenceEqual(data2));
        }
    }

}
