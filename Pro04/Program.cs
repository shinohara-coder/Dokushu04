using System;
using System.Text.RegularExpressions;
using static System.Console;
using static System.Math;

namespace Pro03
{
    internal class Person
    {
        private string _firstName;
        private string _lastName;

        public Person(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        //public Person() : this("権兵衛", "名無") { }
        public Person() { }

        public void Show()
        {
            Console.WriteLine($"名前は{this._lastName}{this._firstName}です。");
        }
    }
    
    internal class ConstructorBasic
    {
        static void Main(string[] args)
        {
            var p = new Person()
            {

            };
            p.Show();
        }
    }
}
