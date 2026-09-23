using static System.Console;
using static System.Math;

namespace Pro06
{   
    internal class AsyncStream
    {
        static async Task Main(string[] args)
        {
            var results = fetchAsync();
            await foreach(var result in results)
            {
                WriteLine(result.Substring(0, 500));
                WriteLine("\n--------------------------------------------------------------------------------\n");
            }
        }

        private static async IAsyncEnumerable<string> fetchAsync()
        {
            var list = new[]
            {
                "https://www.berry.co.jp/",
                "https://wings.msn.to/",
                "https://www.fromsoftware.jp/jp/"
            };

            var client = new HttpClient();
            foreach(var url in list)
            {
                var result = await client.GetStringAsync(url);
                yield return result;
            }
        }
    }   
}
