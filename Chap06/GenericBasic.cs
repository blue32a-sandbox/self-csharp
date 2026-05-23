namespace SelfCSharp.Chap06
{
    internal class GenericBasic
    {
        static void Main(string[] args)
        {
            var list = new List<string>();
            list.Add("あいうえお");
            string str = list[0]; // キャスト不要
            Console.WriteLine(str);
            //list.Add(12345); // コンパイルエラー
        }
    }
}
