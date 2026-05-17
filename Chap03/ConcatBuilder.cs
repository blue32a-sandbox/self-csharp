using System.Text;

namespace SelfCSharp.Chap03
{
    internal class ConcatBuilder
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            for (int i = 0; i < 100000; i++)
            {
                builder.Append("いろは");
            }
            var result = builder.ToString();
        }
    }
}
