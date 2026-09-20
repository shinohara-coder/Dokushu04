using Pro23.DateTimeExtension;
using static System.Console;

namespace Pro23
{
    internal class NamespaceGlobal
    {
        static void Main(string[] args)
        {
            var bs = from b in AppTables.Books
                     where b.Price < 3000
                     //select b;
                     select new { Title = b.Title, Price = b.Price };

            foreach(var b in bs)
            {
                WriteLine(b);
            }
        }
    }
}

