using Pro23.DateTimeExtension;
using static System.Console;

namespace Pro23
{
    internal class NamespaceGlobal
    {
        static void Main(string[] args)
        {
            //var bs = from b in AppTables.Books
            //         join r in AppTables.Reviews on b.Isbn equals r.Isbn
            //         select new
            //         {
            //             Title = b.Title,
            //             Reviewer = r.Name,
            //             Body = r.Body
            //         };

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
                WriteLine($"「{b.Title}」({b.Reviewer})");
                WriteLine($"{b.Body}");
                WriteLine("\n--------------\n");
            }
        }
    }
}

