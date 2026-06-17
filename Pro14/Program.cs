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
                    .GroupBy(b => new
                    {
                        PublishYear = b.Published.Year,
                        PublishMonth = b.Published.Month
                    })
                    .OrderBy(pubs => pubs.Key.PublishYear)
                    .ThenBy(pubs => pubs.Key.PublishMonth);
                
            foreach (var b in bs)
            {
                func($"[{b.Key.PublishYear}年-{b.Key.PublishMonth}月]");
                foreach (var t in b)
                {
                    func(t);
                }
            }
        }

        static void func(object? obj)
        {
            Console.WriteLine(obj.ToString());
        }

        
    }



}
