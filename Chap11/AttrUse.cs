namespace SelfCSharp.Chap11
{
    [Version("1.0.0", Beta = true)]
    internal class AttrUse
    {
        static void Main(string[] args)
        {
            var t = typeof(AttrUse);
            var attr = Attribute.GetCustomAttribute(
                t, typeof(VersionAttribute)) as VersionAttribute;
            if (attr is not null)
            {
                Console.WriteLine(attr.Number); // 1.0.0
                Console.WriteLine("Β版で" + (attr.Beta ? "す" : "はありません")); // Β版です
            }
        }
    }
}
