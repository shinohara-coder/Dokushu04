using static System.Console;

namespace Pro18
{
    public record Person(string FirstName, string LastName, int Age);

    internal class PassArray
    {
        static void Main(string[] args)
        {
            var p = new Person("一郎", "田中", 10);

        }
    }
}
