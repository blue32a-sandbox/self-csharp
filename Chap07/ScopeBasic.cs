namespace SelfCSharp.Chap07
{
    internal class ScopeBasic
    {
        public string data = "フィールド";

        public string Show()
        {
            string data = "ローカル";
            return data;
        }

        public string Show2()
        {
            string data = "ローカル";
            return this.data;
        }

        static void Main(string[] args)
        {
            var s = new ScopeBasic();
            Console.WriteLine(s.Show()); // ローカル
            Console.WriteLine(s.Show2()); // フィールド
            Console.WriteLine(s.data); // フィールド
        }
    }
}
