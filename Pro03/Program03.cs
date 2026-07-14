namespace SelfCSharp.Chap09.Priority1
{
    internal class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return $"Person: {this.LastName} {this.FirstName}";
        }
    }
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            var p = new Person("一郎", "小平");
            Console.WriteLine(p);
            Console.WriteLine(p.FirstName);
        }
    }
}

