namespace SelfCSharp.Chap07
{
    internal class TupleBasic
    {
        public (int max, int min) GetMaxMin(int x, int y)
        {
            return x >= y ? (x, y) : (y, x);
        }

        static void Main(string[] args)
        {
            var a = new TupleBasic();
            var t = a.GetMaxMin(15, 13);
            Console.WriteLine(t.max); // 15
            Console.WriteLine(t.min); // 13

            var (resultMax, resultMin) = a.GetMaxMin(5, 3);
            Console.WriteLine(resultMax); // 5
            Console.WriteLine(resultMin); // 3
        }
    }
}
