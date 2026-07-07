using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pro14
{

    internal class PassRefBasic
    {
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter,
            All = Spring + Summer + Autumn + Winter,
        }
        static void Main(string[] args)
        {
            //var str = (Season)Enum.Parse(typeof(Season), "Summer");
            //var num = (Season)Enum.Parse(typeof(Season), "1");
            //Console.WriteLine($"{str} - {str.GetType()}");
            //Console.WriteLine($"{num} - {num.GetType()}");

            var seasons = Enum.GetValues(typeof(Season));
            foreach (var name in seasons)
            {
                Console.WriteLine($"{(int)name} : {name}");
            }
        }
    }



}
