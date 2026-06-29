namespace SelfCSharp.Chap09.Const
{
    internal class Season
    {
        public const int Spring = 0;
        public const int Summer = 1;
        public const int Autumn = 2;
        public const int Winter = 3;

        public void ProcessSeason(int season)
        {
            Console.WriteLine(
                season switch
                {
                    Spring => "春です。",
                    Summer => "夏です。",
                    Autumn => "秋です。",
                    Winter => "冬です。",
                    _ => "不明な季節です。"
                }
             );
        }
    }

    internal class SeasonConst
    {
        static void Main(string[] args)
        {
            var sc = new Season();
            sc.ProcessSeason(Season.Spring);

            // 想定しない値も受け取ってしまう
            sc.ProcessSeason(4);
        }
    }
}
