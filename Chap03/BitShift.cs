namespace SelfCSharp.Chap03
{
    internal class BitShift
    {
        static void Main(string[] args)
        {
            // int型の最小値を設定
            int i = int.MinValue;
            Console.WriteLine($"{Convert.ToString(i, 2)}");
            Console.WriteLine($"{Convert.ToString(i >> 5, 2)}");

            // int型の最小値をuint型にキャスト
            uint m = (uint)i;
            Console.WriteLine($"{Convert.ToString(m, 2)}");
            Console.WriteLine($"{Convert.ToString(m >> 5, 2), 32}");
        }
    }
}
