using System.Reflection;

namespace Pro07
{
    internal class AsyncBasic
    {
        static void Main(string[] args)
        {
            var bs = from b in AppTables.Books
                     group b by b.Publisher into pubs
                     where pubs.Average(b => b.Price) >= 3500
                     select new
                     {
                         Published = pubs.Key,
                         AveragePrice = pubs.Average(b => b.Price)
                     };

            //var bs = AppTables.Books
            //        .GroupBy(b => new
            //        {
            //            Publisher = b.Publisher,
            //            PublishYear = b.Published.Year
            //        });

            //Console.WriteLine(bs);
            foreach (var b in bs)
            {
                Console.WriteLine($"{b.Published} {b.AveragePrice}円");
            }
        }
    }
}
