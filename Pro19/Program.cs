using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;

namespace Pro19
{
    internal class IteratorBasic
    {
        internal IEnumerable<string> GetStirngs()
        {
            yield return "あいうえお";
            yield return "かきくけこ";
            yield return "さしすせそ";
        }
        static void Main(string[] args)
        {
            var ite = new IteratorBasic();
            IEnumerable<string> strList = ite.GetStirngs();

            foreach (var str in strList)
            {
                func(str);
            }
        }

        static void func(object? obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
