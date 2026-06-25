using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;

namespace Pro17
{
    internal class Reffor
    {
        static void Main(string[] args)
        {
            var result = 0;
            var sum = 0;

            for (ref var i = ref result; i < 100; i++)
            {
                sum += i;
                if (sum > 1000)
                {
                    break;
                }
            }

            func($"合計が1000を超えるのは、1～{result}を加算した時です。");
        }

        static void func(object? obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
