namespace SelfCSharp.Chap09.Priority1
{
    internal class MyGenerics<T> where T : new()
    {
        internal void Hoge()
        {
            var value = new T();
        }
    }
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            var m = new MyGenerics<int>();
            m.Hoge();
        }
    }
}

