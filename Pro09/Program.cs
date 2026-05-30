using System.Net;

namespace Pro09
{
    internal class AsyncHttp
    {   
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var result = await client.GetStringAsync("https://codezine.jp");
            Console.WriteLine(result);
        }
        
        //static void Main(string[] args)
        //{
        //    var client = new WebClient();
        //    client.DownloadStringCompleted += (sender, e) =>
        //    {
        //        Console.WriteLine(e.Result);
        //    };

        //    client.DownloadStringAsync(new Uri("https://codezine.jp/"));
        //    Console.ReadLine();
        //}
    }
}
