global using static System.Console;

namespace Pro14
{
    internal class DelegeteUseCounter
    {
        static void Main(string[] args)
        {
            //var bs = from b in AppTables.Books
            //         where b.Price < 3000
            //         select new { Title = b.Title, Price = b.Price, Isbn = b.Isbn };

            var bs = AppTables.Books
                .Select(b => new
                {
                    ShortTitle = b.Title.Substring(0, 5),
                    DiscountPrice = b.Price * 0.9,
                    Released = (b.Published <= DateTime.Now ? "発売中" : "発売予定")
                });

            foreach (var b in bs)
            {
                WriteLine(b);
            }
        }
    }
}
