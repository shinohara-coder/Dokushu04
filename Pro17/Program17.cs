namespace Pro17
{
    internal delegate void OutputProcess(string str);
    internal class DelegateMulti
    {
        void ArrayWalk(string[] data, OutputProcess output)
        {
            foreach (var value in data)
            {
                output(value);
            }
        }

        static void AddQuote(string data)
        {
            Console.WriteLine($" [{data}] ");
        }

        static void Front4(string data)
        {
            Console.WriteLine(data.Substring(0, 4));
        }

        static void AddHoge(string data)
        {
            Console.WriteLine(data + "Hoge");
        }
        static void Main(string[] args)
        {
            var data = new[] { "あいうえお", "かきくけこ", "さしすせそ", "たちつてと" };
            var dm = new DelegateMulti();
            OutputProcess? proc = AddQuote;
            proc += Front4;
            proc += AddHoge;
            dm.ArrayWalk(data, proc);

            Console.WriteLine("\n------------\n");
            proc += AddHoge;
            proc += Front4;
            dm.ArrayWalk(data, proc);

            Console.WriteLine("\n------------\n");
            proc -= AddHoge;
            dm.ArrayWalk(data, proc!);

        }
    }
}
