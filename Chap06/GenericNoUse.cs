using System.Collections;

namespace SelfCSharp.Chap06
{
    internal class GenericNoUse
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("あいうえお");
            list.Add("かきくけこ");
            string str = (string)list[0];
            Console.WriteLine(str);

            list.Add(12345);
            string str2 = (string)list[2]; // 実行時エラー
        }
    }
}
