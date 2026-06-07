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
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    var result = i * j;
                    if (result > 40)
                    {
                        //goto END;
                        break;
                    }
                    Console.Write($"{result,2} ");
                }
                Console.WriteLine();
            }

        END:
            Console.WriteLine("Fnished!!");
        }
    }

}
