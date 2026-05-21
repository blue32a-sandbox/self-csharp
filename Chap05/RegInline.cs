using System.Text.RegularExpressions;

namespace SelfCSharp.Chap05
{
    internal class RegInline
    {
        static void Main(string[] args)
        {
            var str = "仕事用はwings@example.comです。プライベート用はYAMA@example.comです。";

            var rgx1 = new Regex(@"([a-z0-9.!#$%&'*+/=?^_{|}~-]+)@([a-z0-9-]+(\.[a-z0-9-]+)*)", RegexOptions.IgnoreCase);
            foreach (Match m in rgx1.Matches(str))
            {
                Console.WriteLine(m.Value);
            }

            var rgx2 = new Regex(@"(?i)([a-z0-9.!#$%&'*+/=?^_{|}~-]+)@([a-z0-9-]+(\.[a-z0-9-]+)*)");
            foreach (Match m in rgx2.Matches(str))
            {
                Console.WriteLine(m.Value);
            }

            var rgx3 = new Regex(@"(?i:([a-z0-9.!#$%&'*+/=?^_{|}~-]+)@([a-z0-9-]+(\.[a-z0-9-]+)*))");
            foreach (Match m in rgx3.Matches(str))
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
