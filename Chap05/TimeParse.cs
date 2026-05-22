using System.Globalization;

namespace SelfCSharp.Chap05
{
    internal class TimeParse
    {
        static void Main(string[] args)
        {
            var dt1 = "2026/05/22 23:32:17";
            Console.WriteLine(DateTime.Parse(dt1));

            var dt2 = "令和8年5月22日 23時32分17秒";
            Console.WriteLine(DateTime.Parse(dt2));

            var dt3 = "Donnerstag, 22. Mai 2026 23:32:17";
            Console.WriteLine(DateTime.Parse(dt3, new CultureInfo("de-DE")));
        }
    }
}
