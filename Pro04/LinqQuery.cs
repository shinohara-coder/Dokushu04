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
                     //orderby b.Price descending, b.Published ascending
                     //select b;

            

           foreach (Book b in bs)
            {
                Console.WriteLine(b);
            }

        }
    }
}
