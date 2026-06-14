using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace Pro06
{
    internal class AsyncBasic
    {
        static void Main(string[] args)
        {
            var array1 = new[] { "dog", "cat", "mouse", "fox", "lion", "tigar", "rabbit" };

            Array.Sort(array1);
            //func(string.Join(" & ", array1));

            //func(Array.BinarySearch(array1, "tigar"));

            var array2 = new[] { "あ", "い", "う", "え", "お" };
            var array3 = new string[5];
            Array.Copy(array2, 1, array3, 1, 3);
            func(string.Join(" & ", array3));
        }

        private static void func(object? str)
        {
            Console.WriteLine(str);
        }
    }
}
