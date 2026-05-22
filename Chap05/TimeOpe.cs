namespace SelfCSharp.Chap05
{
    internal class TimeOpe
    {
        static void Main(string[] args)
        {
            var dt1 = new DateTime(2026, 05, 23, 00, 32, 05);
            var dt2 = new DateTime(2013, 08, 05, 05, 15, 10);
            var span = new TimeSpan(3, 15, 30, 0);
            Console.WriteLine(dt1 + span); // 2026/05/26 16:02:05
            Console.WriteLine(dt1 - span); // 2026/05/19 9:02:05
            Console.WriteLine(dt1 == dt2); // False
            Console.WriteLine(dt1 > dt2); // True
        }
    }
}
