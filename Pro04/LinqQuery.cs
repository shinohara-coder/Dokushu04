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
            //         where (2000 <= b.Price && b.Price <= 3500)
            //         select new { Title = b.Title, Price = b.Price, Published = b.Published };

            var bs = AppTables.Books
                    .Where(b => 2000 <= b.Price && b.Price <= 3500)
                    .Select(b => new { Title = b.Title, Price = b.Price, Published = b.Published });

            foreach (var b in bs)
            {
                Console.WriteLine(b);
            }
        }
    }
}
