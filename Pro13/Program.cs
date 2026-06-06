using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pro13
{
    
    internal class NameOfNull
    {
        static void Main(string[] args)
        {
            object obj = new NameOfNull();
            switch (obj)
            {
                case int i:
                    Console.WriteLine(Math.Abs(i));
                    break;

                case string str:
                    Console.WriteLine(str[0]);
                    break;


                default:
                    Console.WriteLine("意図しない型です。");
                    break;
            }
        }
    }

}
