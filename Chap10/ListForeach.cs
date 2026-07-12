namespace SelfCSharp.Chap10
{
    internal class ListForeach
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 3, 6, 9 };
            list.ForEach(v => Console.WriteLine(v * v)); // 1, 9, 36, 81
        }
    }
}
