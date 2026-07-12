namespace SelfCSharp.Chap10
{
    internal class LinqIn
    {
        static void Main(string[] args)
        {
            var bs = AppTables.Books
                     .Where(b => new int[] { 3, 6 }.Contains(b.Published.Month))
                     .Select(b => b);

            foreach (var b in bs)
            {
                Console.WriteLine(b);
            }
        }
    }
}
