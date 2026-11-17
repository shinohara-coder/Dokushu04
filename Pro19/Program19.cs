global using static System.Console;

namespace Pro19
{
    internal class MyGeneics<T> where T : new()
    {
        public void Hoge()
        {
            var value = new T();
        }
    }

    internal class PassArray
    {
        static void Main(string[] args)
        {
            var m = new MyGeneics<int>();
            WriteLine(m.Equals(100));
        }
    }
}
