global using static System.Console;

namespace Pro10
{
    public record Person(string FirstName, string LastName);
    public record BusinessPerson(string FirstName, string LastName) : Person(FirstName, LastName);
    public record Student(string FirstName, string LastName) : Person(FirstName, LastName);

    internal class MyAppExceptionClient
    {
        static void Main(string[] args)
        {
            const string FIRST_NAME= "一郎";
            const string LAST_NAME= "田中";

            Person p = new Person(FIRST_NAME, LAST_NAME);
            Person bp = new BusinessPerson(FIRST_NAME, LAST_NAME);
            BusinessPerson bp2 = new BusinessPerson(FIRST_NAME, LAST_NAME);
            Person st = new Student(FIRST_NAME, LAST_NAME);

            WriteLine(bp);
            WriteLine(bp == st);
            WriteLine(p == bp);
            WriteLine(bp == bp2);
        }
    }
}