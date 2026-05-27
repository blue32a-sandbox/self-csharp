namespace SelfCSharp.Chap07.Anonymous
{
    internal class Hoge
    {
        public string value = "fiald";
        
        public Hoge() { }

        public Hoge(string value)
        {
            this.value = value;
        }
    }

    internal class AnonymousInit
    {
        static void Main(string[] args)
        {
            var h = new Hoge("constructor") { value = "initalizer" };

            // 優先順位はオブジェクト初期化子、コンストラクター、フィールドの順
            Console.WriteLine(h.value); // initalizer
        }
    }
}
