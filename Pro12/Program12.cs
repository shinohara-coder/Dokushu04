using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Text;

namespace Pro10
{
    internal class TypeGetBasic
    {
        static void Main(string[] args)
        {
            try
            {
                checked
                {
                    var i = int.MaxValue;
                    Console.WriteLine(++i);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("オーバーフロー発生");
            }
        }
    }

}
