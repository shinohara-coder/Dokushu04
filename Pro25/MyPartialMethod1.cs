using System;
using System.Collections.Generic;
using System.Text;

namespace Pro25.hoge
{
    internal partial class MyPartialMethod
    {
        static partial void Log()
        {
            Console.WriteLine("ログを記録しました。");
        }
    }
}
