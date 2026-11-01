using static System.Console;

namespace Pro24
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

    internal class Student : Person
    {
        public override string Show()
        {
            return $"学生の{this.LastName}{this.FirstName}です。";
        }
    }

    internal class PassBasic
    {
        static void Main(string[] args)
        {
            Person p = new BusinessPerson
            {
                FirstName = "幸太郎",
                LastName = "小泉"
            };

            BusinessPerson bp = (BusinessPerson)p;
            WriteLine(p.GetType());
            WriteLine(bp.GetType());
            //Student st = (Student)p;

            if(p is Student st)
            {
                st = (Student)p;
            }

            WriteLine(p.Show());
            WriteLine(bp.Show());
            WriteLine(bp.Work());
        }
    }
}
