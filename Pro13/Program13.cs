using System.Text.RegularExpressions;
using static System.Console;

namespace Pro13
{
    internal class Animal
    {
        private int _age;
        public string Name { get; private set; } = "";
        public int Age
        {
            get { return _age; }
            private set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _age = value;
            }
        }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void Intro()
        {
            WriteLine($"ボクの名前は{this.Name}。{this.Age}歳だよ");
        }
    }

    internal class DelegateUse
    {
        static void Main(string[] args)
        {
            var ani = new Animal("タロウ", 15);
            ani.Intro();
        }
    }
}
