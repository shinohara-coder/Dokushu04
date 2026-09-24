using static System.Console;

namespace Pro07
{
    internal class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        [Obsolete("代替としてToStringメソッドを利用してください。")]
        public string Show()
        {
            return $"名前は{this.LastName}{this.FirstName}です。";
        }
    }

    internal class AsyncBasic
    {
        static void Main(string[] args)
        {
            Person p = new Person
            {
                FirstName = "一郎",
                LastName = "田中"
            };
            WriteLine(p.Show());
        }
    }
}
