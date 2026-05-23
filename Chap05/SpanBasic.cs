namespace SelfCSharp.Chap05
{
    internal class SpanBasic
    {
        static void Main(string[] args)
        {
            var list = new[] { 10, 20, 30, 40, 50, 60 };

            // int配列から２～４番目の要素を参照するSpanを生成
            var sp = new Span<int> (list, 2, 3);
            foreach (var v in sp)
            {
                Console.WriteLine(v); // 30 40 50
            }

            // Span経由でint配列を更新
            sp[1] = 999;
            foreach (var v in list)
            {
                Console.WriteLine(v); // 10 20 30 999 50 60
            }
        }
    }
}
