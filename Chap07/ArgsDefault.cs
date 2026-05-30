namespace SelfCSharp.Chap07.MethodArgs
{
    internal class Person
    {
        public string fristName = "";
        public string lastName = "";

        public void Show(string greeting = "こんにちは", string title = "さん")
        {
            Console.WriteLine($"{greeting}、{this.lastName}{this.fristName}{title}！");
        }
    }

    internal class ArgsDefault
    {
        static void Main(string[] args)
        {
            var p = new Person()
            {
                lastName = "山田",
                fristName = "太郎"
            };
            p.Show(); // こんにちは、山田太郎さん！
            p.Show("はじめまして"); // はじめまして、山田太郎さん！
        }
    }
}
