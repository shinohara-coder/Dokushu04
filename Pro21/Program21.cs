namespace Pro21
{
    internal class IteratorBasic
    {
        static void Main(string[] args)
        {
            var msg = "山田五郎";
            var show = () => { Console.WriteLine(msg); };
            show();
        }
    }
}
