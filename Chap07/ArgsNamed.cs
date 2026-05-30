namespace SelfCSharp.Chap07.MethodArgs
{
    internal class ArgsNamed
    {
        static void Main(string[] args)
        {
            var p = new Person()
            {
                lastName = "山田",
                fristName = "太郎"
            };
            p.Show(title: "氏"); // こんにちは、山田太郎氏！
            p.Show(title: "氏", greeting: "おはよう"); // おはよう、山田太郎氏！
        }
    }
}
