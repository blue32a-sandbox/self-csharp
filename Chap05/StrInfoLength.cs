using System.Globalization;

namespace SelfCSharp.Chap05
{
    internal class StrInfoLength
    {
        static void Main(string[] args)
        {
            var str = "叱る";
            var strInfo = new StringInfo(str);
            Console.WriteLine(strInfo.LengthInTextElements); // 2
        }
    }
}
