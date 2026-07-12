namespace SelfCSharp.Chap10
{
    internal class LinqQuery
    {
        static void Main(string[] args)
        {
            var bs = from b in AppTables.Books
                     where b.Price < 3000
                     select new { Title = b.Title, Price = b.Price };

            foreach (var b in bs)
            {
                Console.WriteLine(b);
            }
        }
    }
}
