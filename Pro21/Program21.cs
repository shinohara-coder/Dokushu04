using System.IO.Pipes;
using System.Runtime.InteropServices;
using static System.Console;

namespace Pro21
{ 
    internal class LambdaMember
    {
        int myfield = 0;
        static int myfield2 = 0;
        static void Main(string[] args)
        {
            var mylocal = 1;
            const int MY_CONST = 2;

            static void Hoge()
            {
                //WriteLine(myfield);
                //WriteLine(mylocal);
                WriteLine(myfield2);
                WriteLine(MY_CONST);
                WriteLine(nameof(mylocal));
                WriteLine(nameof(myfield));
            }
            Hoge();
        }
    }
}
