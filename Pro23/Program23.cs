using Pro23.DateTimeExtension;
using static System.Console;

namespace Pro23
{
    internal class NamespaceGlobal
    {
        static void Main(string[] args)
        {
            //var bs = from b in AppTables.Books
            //         where new int[] { 3, 6 }.Contains(b.Published.Month)
            //         select b;

            var bs = AppTables.Books
                    .GroupBy(b => b.Publisher,
                            b => new { Title = b.Title, Price = b.Price, Published = b.Published.ToShortDateString() });

            foreach (var b in bs)
            {
                WriteLine($" [{b.Key}] ");
                foreach (var t in b)
                {
                    //WriteLine($"{t.Title} ({t.Price}円)");
                    WriteLine(t);
                }
            }
        }
    }
}

