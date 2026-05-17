namespace SelfCSharp.Chap03
{
    internal class Increment
    {
        static void Main(string[] args)
        {
            var i = 3;
            var j = ++i;
            Console.WriteLine(i); // 4
            Console.WriteLine(j); // 4

            var m = 3;
            var n = m++;
            Console.WriteLine(m); // 4
            Console.WriteLine(n); // 3
        }
    }
}
