namespace SelfCSharp.Chap09
{
    internal class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public void Deconstruct(out string firstName, out string LastName)
        {
            firstName = this.FirstName;
            LastName = this.LastName;
        }

        public void Deconstruct(out string firstName, out string LastName, out int age)
        {
            firstName = this.FirstName;
            LastName = this.LastName;
            age = this.Age;
        }
    }

    internal class ObjDeconstruct
    {
        static void Main(string[] args)
        {
            var p = new Person("太郎", "山田", 20);
            var (fn, ln, age) = p;
            Console.WriteLine(fn); // 太郎
            Console.WriteLine(ln); // 山田
            Console.WriteLine(age); // 20
        }
    }
}
