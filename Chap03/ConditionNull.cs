namespace SelfCSharp.Chap03
{
    internal class ConditionNull
    {
        static void Main(string[] args)
        {
            string? str = "山田";
            string def = "権兵衛";
            Console.WriteLine(str ?? def); // 山田
        }
    }
}
