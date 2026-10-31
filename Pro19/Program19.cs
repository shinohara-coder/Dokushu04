using System.Globalization;
using System.IO.Pipes;
using static System.Console;

namespace Pro19
{
    internal class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        public Person() { }

        public string Show()
        {
            return $"名前は{this.LastName}{this.FirstName}です。";
        }
    }

    internal class BusinessPerson : Person
    {
        public string Work()
        {
            return $"{this.LastName}{this.FirstName}は、働きます。";
        }

        //public new string Show()
        //{
        //    return $"会社員の{this.LastName}{this.FirstName}です。";
        //}
    }

    internal class EliteBusinessPerson : BusinessPerson
    {
        public new string Work()
        {
            //var result = base.Work();
            return $"{base.Work()}いつでもテキパキと";
        }
    }

    internal class PassArray
    {
        static void Main(string[] args)
        {
            var ep = new EliteBusinessPerson
            {
                FirstName = "一郎",
                LastName = "小柳"
            };

            WriteLine(ep.Work());
            WriteLine(ep.Show());
        }
    }
}
