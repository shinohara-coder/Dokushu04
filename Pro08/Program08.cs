using MyLib;
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
        internal class MyParent
        {
            public MyParent()
            {
                Console.WriteLine("親です。");
            }
        }

        internal class MyChild : MyParent
        {
            public MyChild()
            {
                Console.WriteLine("子です。");
            }
        }
        static void Main(string[] args)
        {
            var c = new MyChild();
        }
    }
}
