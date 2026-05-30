namespace SelfCSharp.Chap07.MethodArgs
{
    internal class ArgsParams
    {
        public int TotalProducts(params int[] values)
        {
            int result = 1;
            foreach (var value in values)
            {
                result *= value;
            }
            return result;
        }

        static void Main(string[] args)
        {
            var v = new ArgsParams();
            Console.WriteLine(v.TotalProducts(12, 15, -1)); // -180
            Console.WriteLine(v.TotalProducts(5, 7, 8, 2)); // 560
        }
    }
}
