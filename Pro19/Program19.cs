using static System.Console;

namespace Pro19
{
    //public record struct Person(string FirstName, string LastName, int Age);
    public record Person(string FirstName, string LastName, int Age);

    internal class PassArray
    {
        static void Main(string[] args)
        {
            var p1 = new Person("一郎", "田中", 22);
            var p2 = new Person("一郎", "田中", 22);
            //p1.FirstName = "幸太郎";
            WriteLine(p1);
            WriteLine(p1 == p2);
            WriteLine(Object.ReferenceEquals(p1, p2));
            (string fname, string lname, int age) = p1;
            WriteLine($"{lname} {fname} {age}歳");
        }
    }

}
