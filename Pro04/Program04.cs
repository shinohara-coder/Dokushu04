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

        public override bool Equals(object? obj)
        {
            if (Object.ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }

            return obj is Person p &&
                this.FirstName == p.FirstName &&
                this.LastName == p.LastName;
        }
    }
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            var p = new Person("哲夫", "萩原");
            var p2 = new Person("哲夫", "萩原");
            Console.WriteLine(p.Equals(p2));
        }
    }
}

