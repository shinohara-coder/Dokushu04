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
                using (var sr = new StreamReader(@"C:\Users\sc_design\Desktop\sample\SelfCSharp\Chap09\OpeBool.cs"))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("ファイルが見つかりませんでした。");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}

