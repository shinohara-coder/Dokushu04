global using static System.Console;

namespace Pro08
{
    internal record Person(string FirstName, string LastName, int Age);

    internal class IteratorBasic
    {
        static void Main(string[] args)
        {
            var p = new Person("慎太郎", "小森田", 18);
            var pc1 = p with { Age = 35 };
            var pc2 = p with { };

            WriteLine(pc1);
            WriteLine(pc2);
            WriteLine(p == pc2);
            WriteLine(Object.ReferenceEquals(p, pc2));
        }
    }
}

