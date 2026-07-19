namespace Pro13
{
    delegate void Process(string str);
    internal class PassRefBasic
    {   
        static void Run(string s)
        {
            Console.WriteLine($"{s}走ります。");
        }

        static void Greet(string s)
        {
            Console.WriteLine($"{s}、皆さん。");
        }

        static string Hoge(string s)
        {
            return $"{s}を受け取ったよ。";
        }
        static void Main(string[] args)
        {
            var p = new Process(Run);
            p("グダグダ");

            p = new Process(Greet);
            p("こにゃにゃちは");

            p = new Process(Console.WriteLine);
            p("ほげほげ");

            var f = new FileInfo(@"C:\data\sample.txt");
            var ps = new Process(f.MoveTo);
        }
    }
}
