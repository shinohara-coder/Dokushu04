using static System.Console;

namespace Pro18
{
    public record Person(string FirstName, string LastName, int Age);

    internal class PassArray
    {
        static void Main(string[] args)
        {
            var p = new Person("一郎", "田中", 10);
            var pc1 = p with { Age = 52 };
            var pc2 = p with { };
            WriteLine(pc1);
            WriteLine(pc2);
            WriteLine(p == pc2);
            WriteLine(Object.ReferenceEquals(p, pc2));
        }
    }
}
