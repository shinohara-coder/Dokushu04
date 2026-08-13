namespace Pro20
{
    internal class DelegateLamda
    {
        static void Main(string[] args)
        {
            using (var writer = new StreamWriter(@"C:\Users\hirok\OneDrive\デスクトップ\hoge.log"))
            {
                writer.WriteLine(DateTime.Now.ToString());
            }
        }
    }
}
