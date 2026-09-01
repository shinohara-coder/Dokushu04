using Pro23.DateTimeExtension;

namespace Pro23
{
    internal class PassRefReturn
    {
        static void Main(string[] args)
        {
            var dt = DateTime.Now;
            if (dt.IsToday())
            {
                Console.WriteLine("今日届いたデータです。");
            }
        }
    }
}
