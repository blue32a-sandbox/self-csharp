namespace SelfCSharp.Chap03
{
    internal class CalcDivZero
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(3 / 0); // エラー：定数 0 による除算です
            //Console.WriteLine(3 % 0); // エラー：定数 0 による除算です
            Console.WriteLine(3d / 0); // ∞
            Console.WriteLine(3d % 0); // NaN
        }
    }
}
