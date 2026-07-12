namespace SelfCSharp.Chap10
{
    internal class LinqFirst
    {
        static void Main(string[] args)
        {
            var b = AppTables.Books
                    .OrderBy(b => b.Price)
                    .First();
            //var b = AppTables.Books
            //        .Where(b => b.Price > 10000)
            //        .OrderBy(b => b.Price)
            //        .FirstOrDefault();

            Console.WriteLine(b);
        }
    }
}
