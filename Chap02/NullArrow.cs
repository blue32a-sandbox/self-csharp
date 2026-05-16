namespace SelfCSharp.Chap02
{
    internal class NullArrow
    {
        static void Main(string[] args)
        {
            // プロジェクトでnull許容を有効化している状態だと、警告が発生する
            string str = null;
            // string str = "";
            // string? str = null;
            Console.WriteLine(str);
        }
    }
}
