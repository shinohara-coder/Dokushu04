using System.Net;

namespace Pro15
{
    internal class DelegeteUse
    {
        static void Main(string[] args)
        {
            var client = new WebClient();
            client.DownloadStringCompleted += (sender, e) =>
            {
                Console.WriteLine(e.Result);
            };

            client.DownloadStringAsync(new Uri("https://www.berry.co.jp/"));
            Console.ReadLine();
        }
    }
}