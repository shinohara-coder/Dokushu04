using MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace Pro08
{
    internal class MyInitializer
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.WriteLine("Init is called!!");
        }

        [ModuleInitializer]
        public static void Init2()
        {
            Console.WriteLine("Init2 is called!!");
        }
    }

    internal class Message
    {
        int number;

        static Message()
        {
            Console.WriteLine("静的コンストラクター");
        }

        public Message(int number)
        {
            this.number = number;
            Console.WriteLine($"通常のコンストラクター{number}");
        }
    }

    internal class MySingleton
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main is called!!");
            var m1 = new Message(1);
        }

        private static void func(object? str)
        {
            Console.WriteLine(str);
        }
    }
}
