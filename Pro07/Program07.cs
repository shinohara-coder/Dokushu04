using System.Reflection;
using System.Reflection.Metadata;

namespace Pro07
{
    internal class AsyncBasic
    {
        static void Main(string[] args)
        {
            var bs = from b in AppTables.Books
                     join r in AppTables.Reviews on b.Isbn equals r.Isbn into reviews
                     from r in reviews.DefaultIfEmpty()
                     select new
                     {
                         Title = b.Title,
                         Reviwer = r != null ? r.Name : "レビューなし",
                         Body = r != null ? r.Body : ""
                     };

            //var bs = AppTables.Books
            //        .Join(
            //        AppTables.Reviews,
            //        b => b.Isbn,
            //        r => r.Isbn,
            //        (b, r) => new
            //        {
            //            Title = b.Title,
            //            Reviwer = r.Name,
            //            Body = r.Body
            //        }
            //        );

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
