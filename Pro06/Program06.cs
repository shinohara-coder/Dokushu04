using System.IO.Pipes;

namespace Pro06
{
    internal class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public void Deconstruct(out string firstName, out string lastName)
        {
            firstName = this.FirstName;
            lastName = this.LastName;
        }

        public void Deconstruct(out string firstName, out string lastName, out int age)
        {
            firstName = this.FirstName;
            lastName = this.LastName;
            age = this.Age;
        }
    }

    internal class LockBasic
    {
        static void Main(string[] args)
        {
            var p = new Person("圭太", "山本", 36);
            var (fn, ln, age) = p;
            Console.WriteLine(fn);
            Console.WriteLine(ln);
            Console.WriteLine(age);
        }
    }   
}
