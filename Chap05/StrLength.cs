namespace SelfCSharp.Chap05
{
    internal class StrLength
    {
        static void Main(string[] args)
        {
            var str1 = "WINGSプロジェクト";
            Console.WriteLine(str1.Length); // 11

            // サロゲートペアを含む文字列
            var str2 = "叱る";
            Console.WriteLine(str2.Length); // 3
        }
    }
}
