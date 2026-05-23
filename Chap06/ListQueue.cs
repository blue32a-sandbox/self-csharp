namespace SelfCSharp.Chap06
{
    internal class ListQueue
    {
        static void Main(string[] args)
        {
            var list = new Queue<int>();
            list.Enqueue(10);
            list.Enqueue(15);
            list.Enqueue(30);
            list.Enqueue(60);

            foreach (var v in list)
            {
                Console.WriteLine(v); // 10, 15, 30, 60
            }

            Console.WriteLine(list.Count); // 4
            Console.WriteLine(list.Contains(30)); // True
            Console.WriteLine(list.Dequeue()); // 10
            Console.WriteLine(list.Peek()); // 15
            Console.WriteLine(list.Dequeue()); // 15

            Console.WriteLine(String.Join(",", list.ToArray())); // 30,60
        }
    }
}
