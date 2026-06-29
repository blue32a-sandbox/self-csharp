namespace SelfCSharp.Chap09
{
    internal class EnumString
    {
        static void Main(string[] args)
        {
            var s = Season.Spring;
            Console.WriteLine(s); // Spring
            Console.WriteLine(s.ToString()); // Spring
            Console.WriteLine(s.ToString("D")); // 1
            Console.WriteLine(s.ToString("X")); // 0000000000000001
        }
    }
}
