namespace SelfCSharp.Chap07
{
    internal class ScopeBlock2
    {
        static void Main(string[] args)
        {
            {
                var data = "ブロックスコープ";
            }
            // 宣言の順番を替えても同じ名前を宣言することはできない
            // var data = "ローカルスコープ"; // コンパイルエラー
        }
    }
}
