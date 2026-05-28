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
            //         group b by b.Publisher into pubs
            //         where pubs.Average(b => b.Price) >= 3500
            //         select new {
            //             Published = pubs.Key,
            //             AveragePrice = pubs.Average(b => b.Price)
            //         };


            var bs = AppTables.Books
                    .GroupBy(b => b.Publisher)
                    .Select(pubs => new
                    {
                        Published = pubs.Key,
                        AveragePrice = pubs.Average(b => b.Price)
                    })
                    .Where(x => x.AveragePrice >= 2000);
            
            foreach (var b in bs)
            {
                Console.WriteLine($"{b.Published} {b.AveragePrice}円");
            }
        }
    }
}
