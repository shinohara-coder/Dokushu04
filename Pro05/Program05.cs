using System.Net;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal class LambdaCapture
    {
        //static async Task Main(string[] args)
        //{
        //    var client = new HttpClient();
        //    var result = await client.GetStringAsync("https://www.youtube.com/feed/subscriptions");
        //    WriteLine(result);
        //}

        static void Main(string[] args)
        {
            var client = new WebClient();
            client.DownloadStringCompleted += (sender, e) =>
            {
                WriteLine(e.Result);
            };
            client.DownloadStringAsync(new Uri("https://www.berry.co.jp/"));
            ReadLine();
        }
    }
}

