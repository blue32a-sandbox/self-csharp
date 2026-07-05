namespace SelfCSharp.Chap09.ObjectEquals2
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
            var p = new Person("掛谷", "哲夫");
            Console.WriteLine(p.GetHashCode());
            var d = new Dictionary<Person, int>();
            d.Add(p, 10);

            // ハッシュ値を算出するためのプロパティを変更する
            p.LastName = "山田";
            Console.WriteLine(p.GetHashCode());

            // エラー（ハッシュ値が変化したため、キーが見つからない）
            //Console.WriteLine(d[p]);
        }
    }
}
