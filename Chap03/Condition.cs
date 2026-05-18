namespace SelfCSharp.Chap03
{
    internal class Condition
    {
        static void Main(string[] args)
        {
            var score = 75;
            Console.WriteLine(score >= 70 ? "合格！" : "不合格..."); // 合格！
            
            bool flag = true;
            // flag ? Console.WriteLine("OK") : Console.WriteLine("NG");
            Console.WriteLine(flag ? "OK" : "NG"); // OK

            Console.WriteLine($"{( true ? "OK" : "NG")}"); // OK
        }
    }
}
