using SelfCSharp.Chap10;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pro14
{

    internal class NameOfNull
    {
        static void Main(string[] args)
        {
            //var bs = from b in AppTables.Books
            //         where b.Price < 3000
            //         select new { Title = b.Title, Price = b.Price };

            var bs = AppTables.Books
                    .GroupBy(b => b.Publisher)
                    .Where(pubs => pubs.Average(b => b.Price) >= 3500)
                    .Select(pubs => new 
                    { 
                        Published = pubs.Key,
                        AvgPrice = pubs.Average(b => b.Price)
                    });

            foreach (var b in bs)
            {
                func($"{b.Published} {b.AvgPrice}円");
            }
        }

        static void func(object? obj)
        {
            Console.WriteLine(obj.ToString());
        }

        
    }



}
