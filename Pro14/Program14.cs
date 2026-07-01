using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Text;

namespace Pro14
{
    internal class Person
    {

    }
    
    internal class PassRefBasic
    {
        static void Main(string[] args)
        {
            object obj = new Person();
            //double obj = 123;
            Console.WriteLine(obj switch
            {
                int i => $"数値です。：{i}",
                string str => $"文字列型です：{str}",
                double d => $"浮動小数です：{d}",
                var data => $"その他の型でした。：{data}"
            });
        }
    }
}
