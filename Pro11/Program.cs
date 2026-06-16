using IronPython.Hosting;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Pro10
{
    internal class PythonCall
    {

        static void Main(string[] args)
        {
            var list = new Queue<int>();
            list.Enqueue(10);
            list.Enqueue(15);
            list.Enqueue(30);
            list.Enqueue(60);

            foreach (var v in list)
            {
                func(v);
            }

            func(list.Count());
            func(list.Contains(80));
            func(list.Dequeue());
            func(list.Peek());
            func(list.Dequeue());

            func(string.Join(", ", list.ToArray()));
        }

        static void func(object? obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }

}
