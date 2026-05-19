namespace SelfCSharp.Chap04
{
    internal class PreRegion
    {
        static void Main(string[] args)
        {
            #region
            const string Publisher = "翔泳社";
            const double Tax = 1.1;
            var author = "WINGSプロジェクト";
            var title = "１人で学ぶC#";
            var price = 1000;
            #endregion

            Console.WriteLine($"{title} ({Publisher}刊、{author}著) 発売開始");
            Console.WriteLine($"{price * Tax}円");
        }
    }
}
