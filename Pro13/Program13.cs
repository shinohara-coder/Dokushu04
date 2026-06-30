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
        static void Main(string[] args)
        {
            //object obj = 123;
            double obj = 123;
            Console.WriteLine(obj switch
            {
                123 => "123です。",
                int i => "数値です。",
                _ => "意図しない値です。"
            });
        }
    }



}
