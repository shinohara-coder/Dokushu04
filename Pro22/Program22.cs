global using static System.Console;

namespace Pro22
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName,string lastName)
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

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }
    
    internal class IteratorBasic
    {
        static void Main(string[] args)
        {
            var p = new Person("健太郎", "池谷");
            var p2 = new Person("健太郎", "池谷");
            WriteLine(p.Equals(p2));
        }
    }
}
