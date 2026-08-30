namespace Pro17
{
    internal class MyParent
    {
        ~MyParent()
        {
            Console.WriteLine("親です。");
        }
    }

    internal class MyChild : MyParent
    {
        ~MyChild()
        {
            Console.WriteLine("子です。");
        }
    }

    internal class PassArray
    {
        
        static void Main(string[] args)
        {
            var c = new MyChild();
        }
    }
}
