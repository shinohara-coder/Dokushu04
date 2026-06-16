using System.Net;

namespace Pro10
{
    internal class AttrBasic
    {
        static void Main(string[] args)
        {
            var s = new Stack<int>();
            s.Push(10);
            s.Push(15);
            s.Push(30);
            s.Push(60);

            foreach (var v in s)
            {
                func(v);
            }

            func(s.Count());
            func(s.Contains(50));
            func(s.Pop());
            func(s.Peek());
            func(s.Pop());

            func(string.Join(", ", s.ToArray()));
        }

        static void func(object? obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
