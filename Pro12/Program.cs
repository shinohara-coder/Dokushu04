using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Pro10
{
    internal class DelegateAnonymous
    {
        

        static void Main(string[] args)
        {
            int i = 255;
            sbyte b = (sbyte)i;
            Console.WriteLine(Convert.ToString(b, 16));
        }
    }

}
