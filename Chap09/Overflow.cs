namespace SelfCSharp.Chap09
{
    internal class Overflow
    {
        static void Main(string[] args)
        {
            try
            {
                checked
                {
                    var i = int.MaxValue;
                    Console.WriteLine(++i);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("オーバーフロー発生！");
            }
        }
    }
}
