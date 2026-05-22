using System.Globalization;

namespace SelfCSharp.Chap05
{
    internal class TimeJapaniese
    {
        static void Main(string[] args)
        {
            var dt = new DateTime(2026, 05, 23, 01, 21, 05);
            var cal = new CultureInfo("ja-JP");
            cal.DateTimeFormat.Calendar = new JapaneseCalendar();
            Console.WriteLine(dt.ToString("ggyy年MM月dd日 (ddd) tt hh:mm:ss", cal));
        }
    }
}
