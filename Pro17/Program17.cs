namespace Pro17
{
    internal class Person
    {
        public string FirstNmae { get; set; } = "";
        public string LastNmae { get; set; } = "";

        public Person() { }

        [method:Obsolete(message:"代替としてToStringメソッドを利用してください。ほげ")]
        public string Show()
        {
            return $"名前は{LastNmae}{FirstNmae}です。";
        }
    }

    internal class DelegateMulti
    {
        static void Main(string[] args)
        {
            Person p = new Person
            {
                FirstNmae = "三郎",
                LastNmae = "田中"
            };

            Console.WriteLine(p.Show());
        }
    }
}
