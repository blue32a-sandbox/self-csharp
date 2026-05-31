namespace SelfCSharp.Chap07
{
    internal class RefAsign
    {
        static void Main(string[] args)
        {
            var i = 10;
            var j = 20;

            ref var k = ref i;
            k = 15;
            Console.WriteLine($"i={i}, j={j}, k={k}"); // i=15, j=20, k=15

            k = ref j;
            k = 108;
            Console.WriteLine($"i={i}, j={j}, k={k}"); // i=15, j=108, k=108
        }
    }
}
