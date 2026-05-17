namespace SelfCSharp.Chap03
{
    internal class CalcDecimal
    {
        static void Main(string[] args)
        {
            // 浮動小数点数を含んだ演算では、意図した結果を得られない場合がある
            Console.WriteLine(Math.Floor((0.7 + 0.1) * 10)); // 7
            Console.WriteLine(0.2 * 3 == 0.6); // False

            // decimal型を利用する
            Console.WriteLine(Math.Floor((0.7M + 0.1M) * 10M)); // 8
            Console.WriteLine(0.2M * 3M == 0.6M); // True

            // decimal型による演算は低速で、扱える値範囲が狭い
            // 演算そのものは整数で進め、最後に小数点をつける方法もある
            Console.WriteLine((2 * 3) / 10d == 0.6); // True
        }
    }
}
