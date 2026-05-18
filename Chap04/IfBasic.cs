namespace SelfCSharp.Chap04
{
    internal class IfBasic
    {
        static void Main(string[] args)
        {
            var i = 10;
            if (i == 10)
            {
                Console.WriteLine("変数iは10です。");
            }
            else
            {
                Console.WriteLine("変数iは10ではありません。");
            } // 変数iは10です。
        }
    }
}
