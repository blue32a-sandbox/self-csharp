using Chapter = SelfCSharp.Chap09.Other;

namespace SelfCSharp.Chap09.Ns
{
    internal class NamespaceModifier
    {
        static void Main(string[] args)
        {
            // エイリアスとの衝突
            //var ci = new Chapter.CultureInfo("ja-JP");

            var ci = new Chapter::CultureInfo("ja-JP");
        }

        internal class Chapter { }
    }
}
