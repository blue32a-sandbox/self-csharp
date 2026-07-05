namespace SelfCSharp.Chap09.RecordWith
{
    public record Person(string FirstName, string LastName, int Age);

    internal class RecordWith
    {
        static void Main(string[] args)
        {
            var p = new Person("太郎", "山田", 10);
            var pc1 = p with { Age = 20 };
            var pc2 = p with { };

            Console.WriteLine(pc1); // Person { FirstName = 太郎, LastName = 山田, Age = 20 }

            Console.WriteLine(pc2); // Person { FirstName = 太郎, LastName = 山田, Age = 10 }

            Console.WriteLine(p == pc2); // True
            Console.WriteLine(pc1 == pc2); // False
            Console.WriteLine(Object.ReferenceEquals(p, pc1)); // False
            Console.WriteLine(Object.ReferenceEquals(p, pc2)); // False
        }
    }
}
