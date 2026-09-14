using static System.Console;
using static System.Math;

namespace Pro06
{   
    internal class Person
    {
        public string FirstName { get; private set; }
        public string LasstName { get; private set; }
        public int Age { get; private set; }

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LasstName = lastName;
            this.Age = age;
        }

        public void Deconstruct(out string firstName, out string lastName)
        {
            firstName = this.FirstName;
            lastName = this.LasstName;
        }

        public void Deconstruct(out string firstName, out string lastName, out int age)
        {
            firstName = this.FirstName;
            lastName = this.LasstName;
            age = this.Age;
        }
    }
    internal class Practice4
    {
        static void Main(string[] args)
        {
            var p = new Person("一郎", "田中", 25);
            var (fn, ln, age) = p;
            WriteLine($"名：{fn}　姓：{ln} 年齢：{age}");
            var p2 = new Person("太郎", "山田", 35);
            var (fn2, ln2) = p2;
            WriteLine($"名：{fn2}　姓：{ln2}");
        }
    }   
}
