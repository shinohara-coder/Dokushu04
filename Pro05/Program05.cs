namespace SelfCSharp.Chap09.Priority1
{
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, -15, 30, 60, -50, 40, -55, 60, -45 };
            int result = list.RemoveAll(v => v < 0);
            Console.WriteLine(result);
            foreach (var n in list)
            {
                Console.WriteLine(n);
            }
        }
    }
}

