namespace SelfCSharp.Chap09.Record
{
    // プライマリコンストラクター
    public record Person(string FirstName, string LastName, int Age);

    internal class RecordBasic
    {
        static void Main(string[] args)
        {
            var p1 = new Person("太郎", "山田", 10);
            var p2 = new Person("太郎", "山田", 10);

            Console.WriteLine(p1); // Person { FirstName = 太郎, LastName = 山田, Age = 10 }

            Console.WriteLine(p1 == p2); // True
            (string fname, string lname, int age) = p1;
            Console.WriteLine(fname); // 太郎
        }
    }
}
