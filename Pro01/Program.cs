using System;
using SelfCSharp.Chap09.Priority1;
//using MyUtil = SelfCSharp.Chap09.Priority2.MyUtil;

namespace SelfCSharp.Chap09.Priority1
{ 
    internal class LambdaCapture
    {
        
        private static Action CreateAction(int init)
        {
            int value = init;
            return () =>
            {
                value++;
                Console.WriteLine(value);
            };
        }

        static void Main(string[] args)
        {
            Action show = CreateAction(10);
            show();
            show();
            show();
        }
    }
}

