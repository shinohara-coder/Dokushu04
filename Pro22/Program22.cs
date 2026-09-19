using static System.Console;

namespace Pro22
{
    internal class IteratorBasic
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 3, 6, 9 };
            list.ForEach(v => WriteLine(v * v));
        }
    }
}
