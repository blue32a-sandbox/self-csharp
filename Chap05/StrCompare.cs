namespace SelfCSharp.Chap05
{
    internal class StrCompare
    {
        static void Main(string[] args)
        {
            var str1 = "wings";
            var str2 = "WINGS";
            Console.WriteLine(str1.Equals(str2, StringComparison.OrdinalIgnoreCase)); // True
            Console.WriteLine(string.Compare(str1, str2, StringComparison.OrdinalIgnoreCase)); // 0
        }
    }
}
