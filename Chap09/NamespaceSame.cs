using System.Globalization;
using SelfCSharp.Chap09.Other;

namespace SelfCSharp.Chap09.Ns
{
    internal class NamespaceSame
    {
        static void Main(string[] args)
        {
            // あいまいな参照
            //var ci = new CultureInfo("ja-JP");

            // 完全修飾名による参照
            var ci = new System.Globalization.CultureInfo("ja-JP");
        }
    }
}
