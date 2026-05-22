namespace SelfCSharp.Chap05
{
    internal class TimeParseTry
    {
        static void Main(string[] args)
        {
            DateTime dt;
            if (DateTime.TryParse("2026/05/22 23:40:17", out dt))
            {
                Console.WriteLine(dt);
            }

            if (DateTime.TryParse("20260522234017", out dt))
            {
                Console.WriteLine(dt);
            }
            else
            {
                Console.WriteLine("変換できませんでした。");
            }
        }
    }
}
