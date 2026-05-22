using System.Globalization;

namespace SelfCSharp.Chap05
{
    internal class TimeExact
    {
        static void Main(string[] args)
        {
            var str = "20260522235117";
            DateTime dt = DateTime.ParseExact(str, "yyyyMMddHHmmss", new CultureInfo("Ja-JP"));
            Console.WriteLine(dt);
        }
    }
}
