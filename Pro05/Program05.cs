namespace SelfCSharp.Chap09.Priority1
{
    internal class Person : IEquatable<Person>
    {
        public string FirstName { get; private set; }
        //public string LastName { get; private set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        //IEquatable<Person>インターフェイスの実装
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

        // Objectクラスのオーバーライド
        public override bool Equals(object? obj)
        {
            return this.Equals(obj as Person);
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
            var p = new Person("太郎", "今宮");
            Console.WriteLine(p.GetHashCode());
            var d = new Dictionary<Person, int>();
            var old_p = p;
            d.Add(p, 10);
            //p.LastName = "柱谷";
            Console.WriteLine(p.GetHashCode());
            Console.WriteLine(d[old_p]);
        }
    }
}

