using static System.Console;

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
            //同一性の判定
            if (Object.ReferenceEquals(this, obj))
            {
                return true;
            }

            //型の判定
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }

            //同値性の判定
            return obj is Person p &&
                    this.FirstName == p.FirstName &&
                    this.LastName == p.LastName;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            var p = new Person("一郎", "田中");
            var p2 = new Person("一郎", "田中");
            WriteLine(p.Equals(p2));
            WriteLine(p.GetHashCode() == p2.GetHashCode());
            //WriteLine(p2.GetHashCode());
        }
    }
}

