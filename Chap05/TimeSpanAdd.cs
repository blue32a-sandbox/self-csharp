namespace SelfCSharp.Chap05
{
    internal class TimeSpanAdd
    {
        static void Main(string[] args)
        {
            var dt = new DateTime(2026, 05, 23, 00, 28, 05);
            var span = new TimeSpan(3, 15, 30, 0);
            Console.WriteLine(dt.Add(span)); // 2026/05/26 15:58:05
        }
    }
}
