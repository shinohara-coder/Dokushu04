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
            /*var bs = from b in AppTables.Books
                     join r in AppTables.Reviews on b.Isbn equals r.Isbn
                     select new
                     {
                         Title = b.Title,
                         Reviewer = r.Name,
                         Body = r.Body
                     };*/


            var bs = AppTables.Books
                    .Join(
                        AppTables.Reviews,
                        b => b.Isbn,
                        r => r.Isbn,
                        (b, r) => new
                        {
                            Title = b.Title,
                            Reviewer = r.Name,
                            Body = r.Body
                        }
                    );
            
            foreach (var b in bs)
            {
                Console.WriteLine($"「{b.Title}」({b.Reviewer})");
                Console.WriteLine($"{b.Body}");
                Console.WriteLine("-----------");
            }
        }
    }
}
