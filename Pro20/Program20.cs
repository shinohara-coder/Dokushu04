using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;
using Pro20.IntExtensions;

namespace Pro20
{   
    internal class IteratorBasic
    {
        static void Main(string[] args)
        {
            5.Times(() => func("Hello world!"));   
        }

        static void func(object? obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
