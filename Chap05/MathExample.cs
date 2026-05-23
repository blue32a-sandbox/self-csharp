namespace SelfCSharp.Chap05
{
    internal class MathExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Abs(-100)); // 100
            Console.WriteLine(Math.Max(6, 3)); // 6
            Console.WriteLine(Math.Min(6, 3)); // 3
            Console.WriteLine(Math.Ceiling(1234.56)); // 1235
            Console.WriteLine(Math.Floor(1234.56)); // 1234
            Console.WriteLine(Math.Round(1234.56, MidpointRounding.AwayFromZero)); // 1235
            Console.WriteLine(Math.Sqrt(10000)); // 100
            Console.WriteLine(Math.Pow(2, 4)); // 16
            Console.WriteLine(Math.Sign(-100)); // -1
            Console.WriteLine(Math.Cos(Math.PI / 180 * 60)); // 0.5000000000000001
            Console.WriteLine(Math.Sin(Math.PI / 180 * 30)); // 0.49999999999999994
            Console.WriteLine(Math.Tan(Math.PI / 180 * 45)); // 0.9999999999999999
            Console.WriteLine(Math.Log(125, 5)); // 3.0000000000000004
            Console.WriteLine(Math.Log10(100)); // 2
        }
    }
}
