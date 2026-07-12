namespace SelfCSharp.Chap10
{
    internal class LinqLike
    {
        static void Main(string[] args)
        {
            var bs = AppTables.Books
                     .Where(b => b.Title.Contains("Android"))
                     .Select(b => b);

            foreach (var b in bs)
            {
                Console.WriteLine(b);
            }
        }
    }
}
