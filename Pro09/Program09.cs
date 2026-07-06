using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace Pro08
{
    internal class MySingleton
    {   
        static void Main(string[] args)
        {
            try
            {
                var f = new StreamReader(@"C:\nothing.dat");
            }
            catch (FileNotFoundException ex) when (ex.Message.Contains(".dat"))
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("存在しない.datファイルが指定されました。");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

