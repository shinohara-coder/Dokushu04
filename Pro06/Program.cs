using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace Pro06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("孝雄", "堀内");
            Console.WriteLine(p.GetHashCode());
            Dictionary<Person, int> d = new Dictionary<Person, int>();
            d.Add(p, 10);
            p.LastName = "中田";
            Console.WriteLine(p.GetHashCode());
            Console.WriteLine(d[p]);
        }
    }

    internal class Person : IEquatable<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public bool Equals(Person? other)
        {
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }

            if (other == null || this.GetType() != other.GetType())
            {
                return false;
            }

            return this.FirstName == other.FirstName && this.LastName == other.LastName;
        }

        public override bool Equals(object? obj)
        {
            return this.Equals(obj as Person);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }
}
