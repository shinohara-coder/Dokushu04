namespace Pro07
{
    internal class AsyncBasic
    {
        static void Main(string[] args)
        {
            var bs = from b in AppTables.Books
                     //where b.Price < 3000
                     select b;

            foreach (var b in bs)
            {
                Console.WriteLine(b);
            }
        }   
    }
}
