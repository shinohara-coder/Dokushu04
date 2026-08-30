namespace Pro15
{
    internal class MyParent
    {
        public MyParent()
        {
            Console.WriteLine("親です。");
        }
    }

    internal class MyChild : MyParent
    {
        public MyChild()
        {
            Console.WriteLine("子です。");
        }
    }

    internal class DelegeteUse
    {
        static void Main(string[] args)
        {
            var c = new MyChild();
        }
    }
}