global using static System.Console;
using static Pro12.MyClass;

namespace Pro12
{
    internal class MyClass
    {
        internal class MyHelper
        {
            public void Show()
            {
                WriteLine("Nested Class is running!");
            }
        }

        public void Run()
        {
            var helper = new MyHelper();
            helper.Show();
        }
    }


    internal class LockBasicBad
    {
        static void Main(string[] args)
        {
            var c = new MyClass();
            c.Run();

            var h = new MyHelper();
        }
    }
}

