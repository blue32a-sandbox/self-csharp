namespace SelfCSharp.Chap07
{
    internal class MethodLocal
    {
        static void Main(string[] args)
        {
            // 宣言位置より前で呼び出し
            Console.WriteLine(Discount(1000, 0.2)); // 800

            double Discount(int price, double rate)
            {
                return price * (1 - rate);
            }

            Console.WriteLine(Discount(1000, 0.2)); // 800
        }
    }
}
