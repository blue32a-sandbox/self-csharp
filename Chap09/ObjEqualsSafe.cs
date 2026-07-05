namespace SelfCSharp.Chap09.ObjectEquals2
{
    internal class Person : IEquatable<Person>
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public bool Equals(Person? other)
        {
            // 同一性の判定
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }

            // 型の判定
            if (other == null || this.GetType() != other.GetType())
            {
                return false;
            }

            // 同値性の判定
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

    internal class ObjEqualsSafe
    {
        static void Main(string[] args)
        {
            var p1 = new Person("太郎", "山田");
            var p2 = new Person("太郎", "山田");

            Console.WriteLine(p1.Equals(p2)); // True

            var p3 = new Person("花子", "山田");
            Console.WriteLine(p1.Equals(p3)); // False
        }
    }
}
