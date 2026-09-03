namespace SelfCSharp.Chap09.Priority1
{
    interface IHoge
    {
        void Foo(string str);
    }

    interface IHoge2
    {
        void Foo(string str2);
    }

    public class MyClass : IHoge, IHoge2
    {
        public void Foo(string str)
        {
            Console.WriteLine($"暗黙的={str}");
        }
    }
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
           
        }
    }
}

