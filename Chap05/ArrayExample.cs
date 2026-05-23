namespace SelfCSharp.Chap05
{
    internal class ArrayExample
    {
        static void Main(string[] args)
        {
            var array1 = new[] { "dog", "cat", "mouse", "fax", "lion" };

            // 事前にソート
            Array.Sort(array1);
            Console.WriteLine(string.Join("& ", array1)); // cat& dog& fax& lion& mouse

            // ソート済み配列を検索
            Console.WriteLine(Array.BinarySearch(array1, "mouse")); // 4

            // 配列array2の２～４番目を配列array3の２番目以降の要素にコピー
            var array2 = new[] { "あ", "い", "う", "え", "お" };
            var array3 = new string[5];
            Array.Copy(array2, 1, array3, 1, 3);
            Console.WriteLine(string.Join("& ", array3)); // & い& う& え&

            // 配列array1のサイズを３拡張
            Array.Resize(ref array1, array1.Length + 3);
            Console.WriteLine(string.Join("& ", array1)); // cat& dog& fax& lion& mouse& & &

            // 配列array2の２～３番目をクリア
            Array.Clear(array2, 1, 2);
            Console.WriteLine(string.Join("& ", array2)); // あ& & & え& お

            // 多次元配列のコピー（３～６番目の要素をコピー）
            var multi1 = new string[,]
            {
                {"ハ", "ニ", "ホ", "ヘ", "ト" },
                {"ど", "れ", "み", "ふぁ", "そ" }
            };
            var multi2 = new string[2, 3];
            Array.Copy(multi1, 2, multi2, 0, 6);
            foreach (var v in multi2)
            {
                Console.WriteLine(v); // ホ ヘ ト ど れ み
            }
        }
    }
}
