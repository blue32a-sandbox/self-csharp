namespace SelfCSharp.Chap06
{
    internal class ListForeach2
    {
        static void Main(string[] args)
        {
            var list = new List<string>
            {
                "バラ",
                "ひまわり",
                "あさがお",
            };
            var enu = list.GetEnumerator();
            while (enu.MoveNext())
            {
                var str = enu.Current;
                Console.WriteLine(str);
            }
        }
    }
}
