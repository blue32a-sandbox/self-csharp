namespace SelfCSharp.Chap09.RecordStruct
{
    // レコード構造体
    public record struct Person(string FirstName, string LastName, int Age);

    // イミュータブルにするならreadonly修飾子を付ける
    //public readonly record struct Person(string FirstName, string LastName, int Age);

    internal class RecordStruct
    {
        static void Main(string[] args)
        {
            var p1 = new Person("太郎", "山田", 10);
            var p2 = new Person("太郎", "山田", 10);

            Console.WriteLine(p1); // Person { FirstName = 太郎, LastName = 山田, Age = 10 }

            Console.WriteLine(p1 == p2); // True
            (string fname, string lname, int age) = p1;
            Console.WriteLine(fname); // 太郎

            // レコード構造体は規定で書き換え可能
            p1.FirstName = "次郎";
            Console.WriteLine(p1.FirstName); // 次郎
        }
    }
}
