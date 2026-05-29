using System;
using System.Collections.Generic;

namespace Pro05
{
    internal class MyClass
    {
        static void Main(string[] args)
        {
            var t1 = new Thread(Count);
            var t2 = new Thread(Count);
            var t3 = new Thread(Count);

            t1.Start(1);
            t2.Start(2);
            t3.Start(3);
        }


        static void Count(object? n)
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Thread{n}: {i}");
            }
        }
        
    }

}
