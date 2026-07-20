namespace Pro15
{
    internal delegate void OutputProcess(string str);   
    internal class DelegeteUse
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

        static void AddSlash(string data)
        {
            Console.WriteLine($" /{data}/ ");
        }

        static void Main(string[] args)
        {
            var data = new[] { "あいうえお", "かきくけこ", "さしすせそ", "たちつてと" };
            var du = new DelegeteUse();
            du.ArrayWalk(data, AddQuote);
            Console.WriteLine("-------------");
            du.ArrayWalk(data, AddSlash);
        }
    }
}
