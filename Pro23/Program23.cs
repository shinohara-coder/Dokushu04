global using static System.Console;

namespace Pro23
{
    internal class Person : IEquatable<Person>
    {
        public string FirstName { get; private set; }
        public string LastName { get; set; }

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
        internal class ArgsParams
    {        
        static void Main(string[] args)
        {
            
        }
    }
}

