using Microsoft.VisualBasic;
using Pro04.hoge;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pro04
{   
    internal class LinqQuery
    {
        static void Main(string[] args)
        {
            //var bs = from b in AppTables.Books
            //         group b by b.Publisher;

            var bs = AppTables.Books
                    .GroupBy(b => b.Publisher,
                        b => new { Title = b.Title, Price = b.Price});

            foreach (var b in bs)
            {
                Console.WriteLine($"[{b.Key}]");
                foreach (var t in b)
                {
                    Console.WriteLine($"{t.Title} ({t.Price}円)");
                }
            }
        }
    }
}
