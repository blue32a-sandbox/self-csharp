using System.Diagnostics.Contracts;

namespace SelfCSharp.Chap06
{
    internal class ListLinked
    {
        static void Main(string[] args)
        {
            var animals = new[] { "とら", "うさぎ", "たつ" };
            var list = new LinkedList<string>(animals);

            foreach (var v in list)
            {
                Console.WriteLine(v); // とら うさぎ たつ
            }

            Console.WriteLine(list.Count); // 3
            Console.WriteLine(list.Contains("とら")); // True

            list.AddFirst("ねずみ");
            list.AddLast("いのしし");
            list.AddBefore(list.Last, "いぬ");
            list.AddAfter(list.First, "うし");
            PrintList(list); // ねずみ,うし,とら,うさぎ,たつ,いぬ,いのしし

            list.Remove("たつ");
            list.RemoveLast();
            PrintList(list); // ねずみ,うし,とら,うさぎ,いぬ

            var node = list.First;
            list.Remove(node);
            list.AddLast(node);
            PrintList(list); // うし,とら,うさぎ,いぬ,ねずみ
        }

        private static void PrintList(LinkedList<string> list)
        {
            Console.WriteLine(string.Join(",", list));
        }
    }
}
