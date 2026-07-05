namespace SelfCSharp.Chap09.RecordProp
{
    public record Person
    {
        // プライマリコンストラクターを使用しない従来の構文
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }
    }

    internal class RecordProp
    {
        // オブジェクト初期化を使用して初期化する
        static void Main(string[] args)
        {
            var p = new Person()
            {
                FirstName = "太郎",
                LastName = "山田",
                Age = 10
            };
            Console.WriteLine(p); // Person { FirstName = 太郎, LastName = 山田, Age = 10 }
        }
    }
}
