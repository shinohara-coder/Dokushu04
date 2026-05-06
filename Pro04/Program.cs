using System;
using System.Runtime.Serialization;
using static Pro04.hoge.MyClass;

namespace Pro04.hoge
{
    internal class MyClass
    { 
        internal class MyHelper
        {
            public void Show()
            {
                Console.WriteLine("Nested Class is running!");
            }
        }

        public void Run()
        {
            MyHelper helper = new MyHelper();
            helper.Show();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass c = new MyClass();
            c.Run();

            var h = new MyHelper();
            h.Show();
        }
    }

}
