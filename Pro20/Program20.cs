namespace Pro20
{
    internal class DelegateLamda
    {
        void ArrayWalk(string[] data, Func<string, string> output)
        {
            foreach (var value in data)
            {
                Console.WriteLine(output(value));
            }
        }
        static void Main(string[] args)
        {
            var data = new[] { "あいうえお", "かきくけこ", "さしすせそ", "たちつてと" };
            var dl = new DelegateLamda();
            //dl.ArrayWalk(data, (string d) =>
            //{
            //    return $" [{d}] ";
            //});

            dl.ArrayWalk(data, d => $" [{d}] ");
        }
    }
}
