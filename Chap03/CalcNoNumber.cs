namespace SelfCSharp.Chap03
{
    internal class CalcNoNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1 + 2); // 3
            Console.WriteLine("a" + 5); // a5
            Console.WriteLine(5 + "b"); // 5b
            Console.WriteLine("1" + "2"); // 12
            Console.WriteLine("a" + DateTime.Now); // aYYYY/MM/DD HH:MM:SS
        }
    }
}
