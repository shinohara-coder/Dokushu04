using System.Globalization;

namespace Pro14
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
            return $"{this.LastName}{this.FirstName}は働きます。";
        }
    }
    
    internal class DelegeteNoUse
    {
       static void Main(string[] args)
        {
            var bp = new BusinessPerson
            {
                FirstName = "幸太郎",
                LastName = "杉山"
            };
            Console.WriteLine(bp.Work());
            Console.WriteLine(bp.Show());
        }
    }
}
