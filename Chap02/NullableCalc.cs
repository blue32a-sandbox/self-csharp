namespace SelfCSharp.Chap02
{
    internal class NullableCalc
    {
        static void Main(string[] args)
        {
            int? num1 = 3;
            int num2 = 5;
            // num1.Value + num2
            Console.WriteLine(num1 + num2); // 8
        }
    }
}
