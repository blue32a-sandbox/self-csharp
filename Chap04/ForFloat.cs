namespace SelfCSharp.Chap04
{
    internal class ForFloat
    {
        static void Main(string[] args)
        {
            // 誤差が発生し、ループは９回で終了してしまう
            for (var i = 0.1f; i <= 1.0; i += 0.1f)
            {
                // 出力した変数iの値も正しくない
                Console.WriteLine(i);
            }
        }
    }
}
