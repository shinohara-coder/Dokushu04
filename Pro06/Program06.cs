using System.IO.Pipes;

namespace Pro06
{
    internal class LockBasic
    {
        static void Main(string[] args)
        {
            foreach (var book in AppTables.Books)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("---------------------------------");

            foreach (var review in AppTables.Reviews)
            {
                Console.WriteLine(review);
            }
        }
    }   
}
