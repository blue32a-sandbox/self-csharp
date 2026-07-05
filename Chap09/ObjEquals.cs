namespace SelfCSharp.Chap09.ObjectEquals
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
            // 同一性の判定
            if (Object.ReferenceEquals(this, obj))
            {
                return true;
            }

            // 型の判定
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }

            // 同値性の判定
            return obj is Person p &&
                this.FirstName == p.FirstName &&
                this.LastName == p.LastName;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }

    internal class ObjEquals
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
