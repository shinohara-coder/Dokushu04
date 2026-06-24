using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pro13
{
    
    internal class PassRefBasic
    {
        public int CountUp(ref int data)
        {
            //data++;
            return ++data;
        }
        static void Main(string[] args)
        {
            int data = 1;
            var p = new PassRefBasic();
            func(p.CountUp(ref data));
            func(data);
        }

        static void func(object? obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }



}
