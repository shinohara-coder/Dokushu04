using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace Pro10
{
    internal class MyParent
    {
        public MyParent(string childname)
        {
            Console.WriteLine($"{childname}の親です。");
        }

        ~MyParent()
        {
            Console.WriteLine("親のファイナライザー");
        }
    }

    internal class MyChild : MyParent
    {
        public MyChild(string childname) : base(childname)
        {
            Console.WriteLine($"子の{childname}です。");
        }

        ~MyChild()
        {
            Console.WriteLine("このファイナライザー");
        }
    }

    internal class MySingleton
    {
        static void Main(string[] args)
        {
            var c = new MyChild("小太郎");
        }
    }
}

