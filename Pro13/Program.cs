using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace Pro13
{
    internal class DelegateLambda
    {
        static void Main(string[] args)
        {
            int num = 42;

            // fixed を使ってメモリの位置を固定し、アドレスをポインタ型（int*）に代入
            unsafe
            {
                int* ptr = &num;
                Console.WriteLine($"変数xのアドレス：0x{(IntPtr)ptr:X}");
            }
        }
    }

}
