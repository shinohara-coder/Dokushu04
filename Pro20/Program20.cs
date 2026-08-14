using System.Text;

namespace Pro20
{
    internal class DelegateLamda
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            const string filename = @"C:\Users\hirok\OneDrive\デスクトップ\hoge.log";
            var lines = new[] {"hoge", "fuga", "foo", "piyo" };
            using (var writer = new StreamWriter(filename, true, encoding:Encoding.GetEncoding("Shift-JIS")))
            {
                writer.WriteLine(DateTime.Now.ToString());
            }

            File.WriteAllLines(filename, lines);
        }
    }
}
