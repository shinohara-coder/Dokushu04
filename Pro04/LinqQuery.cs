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
            var bs = AppTables.Books
                    .Where(b => b.Price > 10000)
                    .OrderBy(b => b.Price)
                    .FirstOrDefault();

            //foreach (var b in bs)
            //{
            //    Console.WriteLine(b);
            //}

            Console.WriteLine(bs);
        }
    }
}
