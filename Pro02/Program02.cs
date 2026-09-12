using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal class MyGenerics<T> where T : IComparable<T>
    {
        public int Hoge(T x, T y)
        {
            return x.CompareTo(y);
        }
    }
    internal partial class TupleBasic
    {
        static void Main(string[] args)
        {
            var m = new MyGenerics<double>();
            WriteLine(m.Hoge(3.1417, 3.1419));
        }
    }
}


