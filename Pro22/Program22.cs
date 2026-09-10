using Pro22.IntExtension;
using System.Diagnostics.CodeAnalysis;

namespace Pro22
{
    internal class MyClass
    {
        //class MyHelper
        internal class MyHelper
        {
            public void Show()
            {
                Console.WriteLine("Nested Class is running!");
            }
        }

        public void Run()
        {
            var helper = new MyHelper();
            helper.Show();
        }
    }
    internal class IteratorBasic
    {
        static void Main(string[] args)
        {
            var c = new MyClass();
            c.Run();

            var h = new MyClass.MyHelper();
;        }
    }
}
