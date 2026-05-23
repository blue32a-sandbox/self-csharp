namespace SelfCSharp.Chap06
{
    internal class ListForeach
    {
        static void Main(string[] args)
        {
            var list = new List<string>
            {
                "バラ",
                "ひまわり",
                "あさがお",
            };

            foreach (var s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
