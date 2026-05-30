namespace SelfCSharp.Chap07
{
    internal class Constants
    {
        // const定数をは無条件にstaticであるため、static修飾子は不要
        //public static const int Value = 10; // エラー
        public const int Value = 10;
    }

    internal class ConstantsBasic
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Constants.Value);
        }
    }
}
