global using static System.Console;
using System.Runtime.Serialization;

namespace Pro24
{
    internal class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public Person(string firstName, string lastname, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastname;
            this.Age = age;
        }

        public void Deconstruct(out string firstName)
        {
            firstName = this.FirstName;
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

    internal class PassBasic
    {
        static void Main(string[] args)
        {
            var p = new Person("太郎", "麻生", 85);
            //var (fn,ln,age) = p;
            //Write($"「名前：{fn}」 「姓：{ln}」 「年齢：{age}」");
            var fn = p;
            WriteLine(fn);
        }
    }
}
