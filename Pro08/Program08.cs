using static System.Console;

namespace Pro08
{
    internal record Person(string FirstName, string LastName, int Age);

    internal class TryCatchOrder
    {
        static void Main(string[] args)
        {
            var p1 = new Person("慎太郎", "小森田", 18);
            var p2 = new Person("慎太郎", "小森田", 18);
            WriteLine(p1);
            WriteLine(p1.ToString());
            WriteLine(p1 == p2);
            (string fname, string lname, int age) = p1;
            WriteLine($"{lname}{fname} {age}歳");
        }
    }
}
