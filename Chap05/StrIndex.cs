namespace SelfCSharp.Chap05
{
    internal class StrIndex
    {
        static void Main(string[] args)
        {
            var str = "にわにはにわにわとりがいる";
            Console.WriteLine(str.IndexOf("にわ")); // 0
            Console.WriteLine(str.IndexOf("にも")); // -1
            Console.WriteLine(str.LastIndexOf("にわ")); // 6
            Console.WriteLine(str.IndexOf("にわ", 3)); // 4
            Console.WriteLine(str.LastIndexOf("にわ", 3)); // 0
            Console.WriteLine(str.IndexOf("にわ", 2, 5)); // 4
            Console.WriteLine(str.LastIndexOf("にわ", 5, 3)); // 4
            Console.WriteLine(str.IndexOf("にわ", 5, 10)); // エラー
        }
    }
}
