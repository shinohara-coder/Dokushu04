using System.Globalization;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace Pro13
{
    
    internal class BusinessPerson : Person
    {
        public string Work()
        {
            return $"{this.LastName}{this.FirstName}は、働きます。";
        }

        //public string Show()
        //{
        //    return $"会社員の{this.LastName}{this.FirstName}さんです。";
        //}
    }

    internal class EliteBusinessPerson : BusinessPerson
    {
        public new string Work()
        {
            var result = base.Work();
            return $"{result}いつもテキパキと";
        }
    }

    internal class AsyncReurn
    {   
        static void Main(string[] args)
        {
            var p = new EliteBusinessPerson
            {
                FirstName = "一郎",
                LastName = "小平"
            };
            Console.WriteLine(p.Show());
            Console.WriteLine(p.Work());
        }
    }
}
