namespace SelfCSharp.Chap06
{
    internal class ListBasic
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 10, 15, 30, 60 };
            var list2 = new List<int> { 1, 5, 3, 6 };

            list.Insert(2, 7);
            list.Add(120);

            foreach (var v in list)
            {
                Console.WriteLine(v); // 10, 15, 7, 30, 60, 120
            }

            Console.WriteLine(list.Count); // 6
            Console.WriteLine(list[0]); // 10
            Console.WriteLine(list.Contains(30)); // True
            Console.WriteLine(list.IndexOf(30)); // 3
            Console.WriteLine(list.LastIndexOf(30)); // 3
            Console.WriteLine(list.Remove(60)); // True
            PrintList(list); // 10,15,7,30,120

            list.AddRange(list2);
            PrintList(list); // 10,15,7,30,120,1,5,3,6

            PrintList(list.GetRange(2, 4)); // 7,30,120,1

            list.Reverse();
            PrintList(list); // 6,3,5,1,120,30,7,15,10

            var ary = new int[3];
            list.CopyTo(2, ary, 0, 3);
            Console.WriteLine(String.Join(",", ary)); // 5,1,120
        }

        private static void PrintList(List<int> list)
        {
            Console.WriteLine(string.Join(",", list));
        }
    }
}
