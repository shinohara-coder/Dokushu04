using System;
using System.Collections.Generic;

namespace Pro05
{
    internal class MyClass
    {
        string str1 = "包含・インスタンス";
        static string str2 = "包含・静的";

        public void Show()
        {
            MyHelper h = new MyHelper();
            h.Show();
            Console.WriteLine(h.str1);
            Console.WriteLine(MyHelper.str2);
        }
        internal class MyHelper
        {
            internal string str1 = "入れ子・インスタンス";
            internal static string str2 = "入れ子・静的";

            public void Show()
            {
                MyClass c = new MyClass();
                Console.WriteLine(c.str1);
                Console.WriteLine(MyClass.str2);
            }
        }

        
    }

    internal partial class MyPartialMethod
    {
        static partial void Log();
        static void Main(string[] args)
        {
            Console.WriteLine(default(int));
            Console.WriteLine(default(double));
            Console.WriteLine(default(string));

        }
    }

}
