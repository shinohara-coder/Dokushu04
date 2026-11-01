using static System.Console;

namespace Pro23
{
    internal class Person
    {
        public string FistName { get; set; } = "";
        public string LastName { get; set; } = "";

        public Person() { }
        public virtual string Show()
        {
            return $"名前は{this.LastName}{this.FistName}です。";
        }
    }

    internal class BusinessPerson : Person
    {
        public override string Show()
        {
            return $"{base.Show()}会社員です。";
        }
    }

    internal class EliteBusinessPerson : BusinessPerson
    {
        public override string Show()
        {
            return $"{base.Show()}その中でもエリートです。";
        }
    }

    internal class ArgsParams
    {
        static void Main(string[] args)
        {
            var ebp = new EliteBusinessPerson
            {
                FistName = "幸太郎",
                LastName = "清宮"
            };
            WriteLine(ebp.Show());
        }
    }
}

