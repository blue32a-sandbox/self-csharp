namespace SelfCSharp.Chap05
{
    internal class SpanString
    {
        static void Main(string[] args)
        {
            var str = "WINGSプロジェクト";
            var sp = str.AsSpan(5, 5);
            // 文字列は不変なので、戻り値は読み取り専用のReadOnlySpan
            //sp[2] = 'ゴ'; // エラー
        }
    }
}
