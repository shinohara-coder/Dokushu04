using static System.Console;

namespace Pro20
{
    public record Person(string FirstName, string LastName);
    public record BusinessPerson(string FirstName, string LastName) : Person(FirstName, LastName);
    public record Student(string FirstName, string LastName) : Person(FirstName, LastName);

    internal class PassRefArray
    {
        static void Main(string[] args)
        {
            Person p = new Person("一郎", "田中");
            Person bp = new BusinessPerson("一郎", "田中");
            BusinessPerson bp2 = new BusinessPerson("一郎", "田中");
            Person st = new Student("一郎", "田中");

            //WriteLine(bp);

            WriteLine(bp == st);
            WriteLine(p == bp);
            WriteLine(bp == bp2);
        }
    }
}
