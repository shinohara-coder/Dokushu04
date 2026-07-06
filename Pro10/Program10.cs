using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace Pro10
{
    internal class MySingleton
    {
        static void Main(string[] args)
        {
            try
            {
                using (var sr = new StreamReader(@"\nothing.dat"))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch (Exception ex) when (
            ex is FileNotFoundException ||
            ex is ArgumentException)
            {
                Console.WriteLine("ファイルにアクセスできません。");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}

