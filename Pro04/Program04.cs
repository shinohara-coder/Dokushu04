using System.Text.RegularExpressions;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
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
    internal class PassOut
    {
        static void Main(string[] args)
        {
            var p = new Person
            {
                FirstName="一郎",
                LastName="山本"
            };

            WriteLine(p switch
            {
                { FirstName:"",LastName:var ln}=>$"{ln}タロくん、こんにちは"
            });
        }
    }
}

