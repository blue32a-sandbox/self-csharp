namespace SelfCSharp.Chap09
{
    internal class Overflow
    {
        static void Main(string[] args)
        {
            var i = int.MaxValue;
            Console.WriteLine(++i);
        }
    }
}
