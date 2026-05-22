using System.Globalization;

namespace SelfCSharp.Chap05
{
    internal class TimeStringCulture
    {
        static void Main(string[] args)
        {
            var dt = new DateTime(2026, 05, 23, 00, 01, 24);
            var culture = new CultureInfo("ja-JP");

            Console.WriteLine(dt.ToString("f", culture));
            Console.WriteLine(dt.ToString("yy/MM/dd dddd tt hh:mm:ss", culture));
        }
    }
}
