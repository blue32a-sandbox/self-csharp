namespace SelfCSharp.Chap10
{
    internal class LinqStartsWith
    {
        static void Main(string[] args)
        {
            var bs = AppTables.Books
                     .Where(b => b.Title.StartsWith("Android"))
                     .Select(b => b);

            foreach (var b in bs)
            {
                Console.WriteLine(b);
            }
        }
    }
}
