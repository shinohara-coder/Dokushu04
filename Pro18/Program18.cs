namespace Pro18
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
    internal class PassArray
    {
        
        static void Main(string[] args)
        {
            Person p = new BusinessPerson
            {
                FirstName = "一郎",
                LastName = "里中"
            };
            //Console.WriteLine((BusinessPerson)p.Work());
            Console.WriteLine(p.Show());
            Console.WriteLine(p.GetType());
            Console.WriteLine(typeof(Person));
            Console.WriteLine(typeof(BusinessPerson));
        }
    }
}
