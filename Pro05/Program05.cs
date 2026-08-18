namespace SelfCSharp.Chap09.Priority1
{
    internal class Hoge
    {
        public string value = "field";
        public Hoge() { }
        public Hoge(string value)
        {
            this.value = value;
        }
    }
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            var h = new Hoge("constructor") { value = "initializer" };

            Console.WriteLine(h.value);
        }
    }
}

