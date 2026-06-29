namespace SelfCSharp.Chap09
{
    enum Season : long
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    internal class SeasonEnum
    {
        public void ProcessSeason(Season season)
        {
            Console.WriteLine(
                season switch
                {
                    Season.Spring => "春です。",
                    Season.Summer => "夏です。",
                    Season.Autumn => "秋です。",
                    Season.Winter => "冬です。",
                    _ => "不明な季節です。"
                }
             );
        }
    }

    internal class SeasonEnumClient
    {
        static void Main(string[] args)
        {
            var se = new SeasonEnum();
            se.ProcessSeason(Season.Spring);

            // コンパイルエラー
            //se.ProcessSeason(4);
        }
    }
}
