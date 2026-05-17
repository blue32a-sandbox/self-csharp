namespace SelfCSharp.Chap03
{
    internal class ConcatString
    {
        static void Main(string[] args)
        {
            var result = "";
            for (int i = 0; i < 100000; i++)
            {
                result += "いろは";
            }
        }
    }
}
