namespace SelfCSharp.Chap03
{
    internal class Shortcut
    {
        static void Main(string[] args)
        {
            string? str = null;
            if(str != null && str.StartsWith("https://"))
            {
                Console.WriteLine("「https://～」で始まります。");
            }

            // &演算子はショートカットの性質を持たない
            //if (str != null & str.StartsWith("https://"))
            //{
            //    Console.WriteLine("「https://～」で始まります。");
            //}
        }
    }
}
