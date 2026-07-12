namespace SelfCSharp.Chap09.Priority1
{
    internal class MyGenerics<T> where T : IComparable<T>
    {
        internal int Hoge(T x, T y)
        {
            return x.CompareTo(y);
        }
    }
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            var m = new MyGenerics<double>();
            Console.WriteLine(m.Hoge(0.564, 0.456));
        }
    }
}


