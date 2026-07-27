using System.Reflection;
using System.Reflection.Metadata;

namespace Pro07
{
    internal class AsyncBasic
    {
        static void Main(string[] args)
        {
            var bs = from b in AppTables.Books
                     join r in AppTables.Reviews on b.Isbn equals r.Isbn
                     select new
                     {
                         Title = b.Title,
                         Reviwer = r.Name,
                         Body = r.Body
                     };
                     

            //var bs = AppTables.Books
            //        .GroupBy(b => new
            //        {
            //            PublishYear = b.Published.Year,
            //            PublishMonth = b.Published.Month
            //        })
            //        .OrderBy(pubs => pubs.Key.PublishYear)
            //        .ThenBy(pubs => pubs.Key.PublishMonth);



            //Console.WriteLine(bs);
            foreach (var b in bs)
            {
                Console.WriteLine($"「{b.Title}」({b.Reviwer})");
                Console.WriteLine($"{b.Body}");
                Console.Write('\n');
            }
        }
    }
}
