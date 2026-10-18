using System.Text.RegularExpressions;
using static System.Console;

namespace Pro13
{
    internal class Person
    {
        private string _firstName;
        private string _lastName;

        //public Person() { }
        public Person() : this("firstName", "lastName") { }
        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        //public Person():this("firstName","lastName") { }

        public string Show()
        {
            return $"名前は{_lastName} {_firstName}です。";
        }
    }

    internal class DelegateUse
    {
        static void Main(string[] args)
        {
            var p1 = new Person();
            WriteLine(p1.Show());

            var p2 = new Person("孝雄", "堀内");
            WriteLine(p2.Show());
        }
    }
}
