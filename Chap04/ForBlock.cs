namespace SelfCSharp.Chap04
{
    internal class ForBlock
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    // ブロック配下でカウンター変数を操作しない
                    i++;
                }
                Console.WriteLine(i);
            }
        }
    }
}
