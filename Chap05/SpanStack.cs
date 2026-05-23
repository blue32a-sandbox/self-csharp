namespace SelfCSharp.Chap05
{
    internal class SpanStack
    {
        static void Main(string[] args)
        {
            //unsafe
            //{
            //    int* list = stackalloc int[5];
            //    list[99] = 100; // エラーは検出されない
            //}

            // Span型と併用することで、unsafeでない環境でもstackallocを利用できるようになる
            Span<int> list = stackalloc[] { 10, 20, 30, 40, 50 };
            list[99] = 100; // 実行時にエラーが発生
        }
    }
}
