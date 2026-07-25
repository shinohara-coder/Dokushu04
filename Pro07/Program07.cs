using System.Reflection;

namespace Pro07
{
    internal class AsyncBasic
    {
        static void Main(string[] args)
        {
            //var bs = from b in AppTables.Books
            //         where b.Price < 3000
            //         select new { Isbn = b.Isbn ,Title = b.Title, Price = b.Price, Publisher = b.Publisher };

            var bs = AppTables.Books
                    .Where(b => b.Price < 3000)
                    .Select(b => new { Title = b.Title, Price = b.Price });

            foreach (var b in bs)
            {
                Console.WriteLine(b);
            }
        }   
    }
}
