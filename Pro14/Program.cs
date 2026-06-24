using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Text;

namespace Pro14
{
    internal class PassRefArray
    {
        public int[] Update(ref int[] data)
        {
            data = new[] { 10, 20, 30 };
            //data = new[] { 100, 200, 300 };
            return data;
        }

        static void Main(string[] args)
        {
            var data = new[] { 2, 4, 6 };
            var p = new PassRefArray();
            func(p.Update(ref data)[0]);
            func(data[0]);
        }

        static void func(object? obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
