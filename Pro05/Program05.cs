using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Pro05
{
    interface IHoge
    {
        void Foo(string str);
    }

    interface IHoge2
    {
        void Foo(string str2);
    }

    internal class MyClass : IHoge, IHoge2
    {
        public void Foo(string str)
        {
            Console.WriteLine($"暗黙的 = {str}");
        }
    }

    internal class interfaceOverlap
    {
        static void Main(string[] args)
        {
            
        }
    }

}
