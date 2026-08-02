namespace Pro14
{
    internal class DelegeteNoUse
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            //client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
            var result = await client.GetStringAsync("https://www.berry.co.jp/");
            Console.WriteLine(result);
        }
    }
}
