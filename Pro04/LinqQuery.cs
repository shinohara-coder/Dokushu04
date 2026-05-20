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
            //         where (new int[] { 3, 6 }.Contains(b.Published.Month))
            //         select new { Title = b.Title, Price = b.Price, Published = b.Published };

            var bs = AppTables.Books
                    .Where(b => new int[] {3, 6}.Contains(b.Published.Month))
                    .Select(b => new { Title = b.Title, Price = b.Price, Published = b.Published });

            foreach (var b in bs)
            {
                Console.WriteLine(b);
            }
        }
    }
}
