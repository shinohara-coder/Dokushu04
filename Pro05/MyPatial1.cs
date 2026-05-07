using System;
using System.Collections.Generic;
using System.Text;

namespace Pro05
{
    internal partial class MyPartialMethod
    {
        static partial void Log()
        {
            Console.WriteLine("ログを記録しました。");
        }
    }
}
