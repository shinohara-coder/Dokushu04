global using static System.Console;

namespace Pro13
{
    internal class MyClass
    {
        string str1 = "包含・インスタンス";
        static string str2 = "包含・静的";

        public void Show()
        {
            var h = new MyHelper();
            h.Show();
            WriteLine(h.str1);
            WriteLine(MyHelper.str2);
        }

        class MyHelper
        {
            internal string str1 = "入れ子・インスタンス";
            internal static string str2 = "入れ子・静的";

            public void Show()
            {
                var c = new MyClass();
                WriteLine(c.str1);
                WriteLine(MyClass.str2);
            }
        }
    }
    internal class DelegateUse
    {
        static void Main(string[] args)
        {
            var mc = new MyClass();
            mc.Show();
        }
    }
}
