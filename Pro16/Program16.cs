namespace Pro16
{
    internal class AsyncStream
    {
        static async Task Main(string[] args)
        {
            await foreach (var result in fetchAsync())
            {
                Console.WriteLine(result.Substring(0, 500));
                Console.WriteLine("\n----------------------------------------------------------------------------\n");
            }
        }

        private static async IAsyncEnumerable<string> fetchAsync()
        {
            var list = new[]
            {
                "https://www.berry.co.jp/",
                "https://developer.mozilla.org/ja/docs/Web",
                "https://weathernews.jp/?fm=header"
            };

            var client = new HttpClient();
            foreach (var url in list)
            {
                var result = await client.GetStringAsync(url);
                yield return result;
            }
        }
    }
}
