using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;

namespace Pro16
{
    internal class PassOUt
    {
        public void GetMaxMin(int x, int y, out int max, out int min)
        {
            if (x >= y)
            {
                max = x;
                min = y;
            }
            else
            {
                max = y;
                min = x;
            }
        }
        static void Main(string[] args)
        {
            var a = new PassOUt();
            //int resultMax, resultMin;
            a.GetMaxMin(5, 3, out int resultMax, out int resultMin);
            func(resultMax);
            func(resultMin);
        }

        static void func(object? obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
