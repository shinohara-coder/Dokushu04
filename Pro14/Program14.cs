using System.Text.RegularExpressions;

namespace Pro14
{
    internal class DelegeteNoUse
    {
        int myfield = 0;
        static int myfield2 = 0;
        static async Task Main(string[] args)
        {
            var mylocal = 1;
            const int MY_CONST = 2;

            static void Hoge()
            {
                //Console.WriteLine(myfield);
                //Console.WriteLine(mylocal);
                Console.WriteLine(myfield2);
                Console.WriteLine(MY_CONST);
                Console.WriteLine(nameof(myfield));
            }
            Hoge();
        }
    }
}
