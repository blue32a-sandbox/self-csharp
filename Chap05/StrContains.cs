namespace SelfCSharp.Chap05
{
    internal class StrContains
    {
        static void Main(string[] args)
        {
            var str = "WINGSプロジェクト";

            Console.WriteLine(str.Contains("プロ")); // True
            Console.WriteLine(str.StartsWith("WINGS")); // True
            Console.WriteLine(str.EndsWith("WINGS")); // False
        }
    }
}
