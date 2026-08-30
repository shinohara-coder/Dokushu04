namespace Pro16
{
    internal class MyParent
    {
        public MyParent(string childName)
        {
            Console.WriteLine($"{childName}の親です。");
        }
    }

    internal class MyChild : MyParent
    {
        public MyChild(string childName) : base(childName)
        {
            Console.WriteLine($"子の{childName}です。");
        }
    }

    internal class DelegeteUse
    {
        static void Main(string[] args)
        {
            var c = new MyChild("花子");
        }
    }
}
