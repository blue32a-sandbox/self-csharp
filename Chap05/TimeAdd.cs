namespace SelfCSharp.Chap05
{
    internal class TimeAdd
    {
        static void Main(string[] args)
        {
            var dt = new DateTime(2026, 05, 23, 01, 21, 05);
            Console.WriteLine(dt.AddYears(10)); // 2036/05/23 1:21:05
            Console.WriteLine(dt.AddMonths(-3)); // 2026/02/23 1:21:05
            Console.WriteLine(dt.AddDays(20)); // 2026/06/12 1:21:05
            Console.WriteLine(dt.AddHours(5)); // 2026/05/23 6:21:05
            Console.WriteLine(dt.AddMinutes(-20)); // 2026/05/23 1:01:05
            Console.WriteLine(dt.AddSeconds(45)); // 2026/05/23 1:21:50
        }
    }
}
