namespace SelfCSharp.Chap10
{
    internal class LinqOrder
    {
        static void Main(string[] args)
        {
            //var bs = from b in AppTables.Books
            //         orderby b.Price descending, b.Published
            //         select b;
            var bs = AppTables.Books
                     .OrderByDescending(b => b.Price)
                     .ThenBy(b => b.Published)
                     .Select(b => b);

            foreach (var b in bs)
            {
                Console.WriteLine(b);
            }
        }
    }
}
