global using static System.Console;

namespace Pro18
{   
    internal class MyGeneics<T> where T:IComparable<T>
    {
        public int Hoge(T x, T y)
        {
            return x.CompareTo(y);
        }
    }
    internal class NameOfNull
    {
        static void Main(string[] args)
        {
            var m = new MyGeneics<string>();
            WriteLine(m.Hoge("あいう", "あいう"));
            WriteLine(m.Hoge("あいう", "あいお"));
            WriteLine(m.Hoge("あいう", "CVD"));
        }
    }
}

