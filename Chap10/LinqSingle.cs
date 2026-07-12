namespace SelfCSharp.Chap10
{
    internal class LinqSingle
    {
        static void Main(string[] args)
        {
            var b = AppTables.Books
                     .Single(b => b.Isbn == "978-4-7981-6849-4");
            //var b = AppTables.Books
            //         .SingleOrDefault(b => b.Isbn == "xxx-x-xxxx-xxxx-x");

            Console.WriteLine(b);
        }
    }
}
