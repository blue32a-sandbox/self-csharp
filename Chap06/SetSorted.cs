namespace SelfCSharp.Chap06
{
    internal class SetSorted
    {
        static void Main(string[] args)
        {
            var set = new SortedSet<int> { 30, 60, 10, 15 };
            set.Add(10);
            set.Add(5);
            set.Remove(60);

            foreach (var s in set)
            {
                Console.WriteLine(s); // 5, 10, 15, 30
            }

            Console.WriteLine(set.Count); // 4
            Console.WriteLine(set.Min); // 5
            Console.WriteLine(set.Max); // 30

            var set2 = new SortedSet<int> { 10, 15, 30 };
            Console.WriteLine(set.IsSupersetOf(set2)); // True

            set.ExceptWith(new HashSet<int> { 15, 30 });
            set.Remove(10);
            PrintSet(set); // 5
        }

        private static void PrintSet(SortedSet<int> hs)
        {
            Console.WriteLine(String.Join(",", hs));
        }
    }
}
