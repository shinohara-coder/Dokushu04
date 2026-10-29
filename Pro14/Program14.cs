using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using static System.Console;

namespace Pro14
{
    internal class Person
    {
        public string FirstName{ get; set; } = "";
        public string LastName{ get; set; } = "";

        public Person() {
            FirstName = "太郎";
            LastName = "山田";
        }

        public string Show()
        {
            return $"名前は{this.LastName}{this.FirstName}です。";
        }
    }
    internal class DelegeteUseCounter
    {
        static void Main(string[] args)
        {
            var p = new Person
            {
                FirstName = "一郎",
                LastName = "吉田"
            };

            WriteLine(p.Show());
        }
    }
}
