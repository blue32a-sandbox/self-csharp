namespace SelfCSharp.Chap10
{
    internal class LinqBetween
    {
        static void Main(string[] args)
        {
            var bs = AppTables.Books
                     .Where(b => 2000 <= b.Price && b.Price <= 3500)
                     .Select(b => b);

            foreach (var b in bs)
            {
                Console.WriteLine(b);
            }
        }
    }
}
