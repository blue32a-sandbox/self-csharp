namespace SelfCSharp.Chap07
{
    internal class ScopeBlock
    {
        static void Main(string[] args)
        {
            var data = "ローカルスコープ";
            {
                // ブロックスコープの変数はローカル変数の一種であり、同じ名前を宣言することはできない
                // var data = "ブロックスコープ";  // コンパイルエラー
            }
        }
    }
}
