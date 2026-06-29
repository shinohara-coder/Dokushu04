using IronPython.Hosting;
using System.Diagnostics;
using System.IO.Pipes;
using System.Runtime.CompilerServices;

namespace Pro10
{
    internal class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public Person() { }

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
    
    internal class ArgParams
    {
        
        static void Main(string[] arngs)
        {
            Person bp = new BusinessPerson
            {
                FirstName = "一郎",
                LastName = "屋敷"
            };
            Console.WriteLine(bp.Work());
            Console.WriteLine(bp.Show());
        }
    }

}
