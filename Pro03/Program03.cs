namespace SelfCSharp.Chap09.Priority1
{
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, -15, 30, 60, -50, 40 };

            //Console.WriteLine(list.FindIndex(v => v < 0));
            //Console.WriteLine(list.FindLastIndex(v => v < 0));
            Console.WriteLine(list.FindIndex(1, 3, v => v < 0));
        }
    }
}

