using System.Globalization;
using System.Runtime.CompilerServices;
using static System.Console;

namespace Pro20
{
    internal class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        public virtual string Show()
        {
            return $"名前は{this.LastName}{this.FirstName}です。";

        }
    }

    internal class BusinessPerson : Person
    {
        public override string Show()
        {
            return $"会社員の{this.LastName}{this.FirstName}です。";
        }

        public string Work()
        {
            return $"{this.LastName}{this.FirstName}は、働きます。";
        }
    }

    internal class ModuleInit
    {
        static void Main(string[] args)
        {
            var bp = new BusinessPerson
            {
                FirstName = "丈太郎",
                LastName = "空条"
            };

            WriteLine(bp.Work());
            WriteLine(bp.Show());
        }
    }
}
