namespace SelfCSharp.Chap06
{
    internal class SetUnion
    {
        static void Main(string[] args)
        {
            var hs = new HashSet<int> { 1, 10, 15, 20, 30 };

            hs.IntersectWith(new HashSet<int>() { 1, 10, 20, 30, 60 });
            PrintSet(hs); // 1,10,20,30

            hs.ExceptWith(new HashSet<int> { 15, 30 });
            PrintSet(hs); // 1,10,20

            hs.UnionWith(new HashSet<int> { 10, 15, 30 });
            PrintSet(hs); // 1,10,30,20,15

            hs.SymmetricExceptWith(new HashSet<int> { 1, 10, 30 });
            PrintSet(hs); // 20,15
        }

        private static void PrintSet(HashSet<int> hs)
        {
            Console.WriteLine(String.Join(",", hs));
        }
    }
}
