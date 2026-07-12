namespace SelfCSharp.Chap10
{
    internal class LinqGroupMulti
    {
        static void Main(string[] args)
        {
            //var bs = from b in AppTables.Books
            //         group b by new
            //         {
            //             Publisher = b.Publisher,
            //             PublishYear = b.Published.Year
            //         };
            var bs = AppTables.Books
                     .GroupBy(b => new
                     {
                         Publisher = b.Publisher,
                         PublishYear = b.Published.Year
                     });

            foreach (var b in bs)
            {
                Console.WriteLine($"[{b.Key.Publisher}-{b.Key.PublishYear}]");
                foreach (var t in b)
                {
                    Console.WriteLine($"{t.Title} ({t.Price}円)");
                }
            }
        }
    }
}
