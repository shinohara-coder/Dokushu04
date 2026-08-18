namespace SelfCSharp.Chap09.Priority1
{
    internal class Person
    {
        private string _firstName = "";
        private string _lastName = "";

        public Person(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public Person() : this("権兵衛", "名無") { }

        public void　Show()
        {
            Console.WriteLine($"名前は{this._lastName}{this._firstName}です。");
        }
    }
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            //var p = new Person();
            var p = new Person("新之助", "及川");
            p.Show();
        }
    }
}

