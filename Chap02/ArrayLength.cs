namespace SelfCSharp.Chap02
{
    internal class ArrayLength
    {
        static void Main(string[] args)
        {
            // 多次元配列のサイズと次元数
            var multi = new[,] {
                { 10, 11, 12 },
                { 20, 21, 22 },
            };
            Console.WriteLine(multi.Length); // 6
            Console.WriteLine(multi.Rank); // 2

            // ジャグ配列のサイズと次元数
            var jagged = new int[3][];
            jagged[0] = new[] { 10, 11, 12, 13 };
            jagged[1] = new[] { 20, 21 };
            jagged[2] = new[] { 30, 31, 32 };
            Console.WriteLine(jagged.Length); // 3
            Console.WriteLine(jagged[0].Length); // 4
            Console.WriteLine(jagged.Rank); // 1
        }
    }
}
