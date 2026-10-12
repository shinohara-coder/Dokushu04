using System.Text.RegularExpressions;
using static System.Console;
using static System.Math;

namespace Pro06
{   
    internal class AsyncStream
    {
        static  void Main(string[] args)
        {
            var s = new Stack<int>();
            s.Push(10);
            s.Push(15);
            s.Push(30);
            s.Push(60);

            WriteLine(s.Count());
            WriteLine(s.Contains(30));
            WriteLine(s.Pop());
            WriteLine(s.Peek());
            WriteLine(s.Pop());

            WriteLine(String.Join(",", s.ToArray()));
        }
    }   
}
