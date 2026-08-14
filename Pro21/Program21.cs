namespace Pro21
{
    internal class EventBasic
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"C:\Users\hirok\OneDrive\デスクトップ\hoge.txt"))
            {
                //Console.WriteLine(reader.ReadToEnd());
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
        }
    }
}
