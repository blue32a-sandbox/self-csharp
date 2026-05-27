namespace SelfCSharp.Chap07.Construct
{
    internal class Person
    {
        public string fristName;
        public string lastName;

        public Person(string fristName, string lastName)
        {
            this.fristName = fristName;
            this.lastName = lastName;
        }

        // コンストラクター初期化子を使ってオーバーロードされたコンストラクター
        public Person() : this("権兵衛", "名無") { }

        public void Show()
        {
            Console.WriteLine($"名前は{this.lastName}{this.fristName}です。");
        }
    }

    internal class ConstructorBasic
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.Show(); // 名前は名無権兵衛です。
        }
    }
}
