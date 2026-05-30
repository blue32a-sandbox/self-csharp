namespace SelfCSharp.Chap07.ClassField
{
    internal class MyApp
    {
        public static readonly string Title = "独習C#";

        // readonly修飾子を、const修飾子と置き換えてもほぼ同じ
        //public const string Title = "独習C#";
    }

    internal class FieldStatic
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyApp.Title); // 独習C#
            //MyApp.Title = "本気でおぼえるC#"; // コンパイルエラー
        }
    }
}
