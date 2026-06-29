namespace SelfCSharp.Chap09
{
    internal class EnumParse
    {
        static void Main(string[] args)
        {
            var str = (Season)Enum.Parse(typeof(Season), "Summer");
            var num = (Season)Enum.Parse(typeof(Season), "2");
            Console.WriteLine($"{str} - {str.GetType()}"); // Summer - SelfCSharp.Chap09.Season
            Console.WriteLine($"{num} - {num.GetType()}"); // Summer - SelfCSharp.Chap09.Season

            var success = Enum.TryParse("Summer", out Season s);
            Console.WriteLine(success ? $"{s}" : "変換失敗"); // Summer
        }
    }
}
