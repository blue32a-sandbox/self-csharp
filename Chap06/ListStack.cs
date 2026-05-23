namespace SelfCSharp.Chap06
{
    internal class ListStack
    {
        static void Main(string[] args)
        {
            var s = new Stack<int>();
            s.Push(10);
            s.Push(15);
            s.Push(30);
            s.Push(60);

            foreach (var v in s)
            {
                Console.WriteLine(v); // 60, 30, 15, 10
            }

            Console.WriteLine(s.Count); // 4
            Console.WriteLine(s.Contains(30)); // True
            Console.WriteLine(s.Pop()); // 60
            Console.WriteLine(s.Peek()); // 30
            Console.WriteLine(s.Pop()); // 30

            Console.WriteLine(String.Join(",", s.ToArray())); // 15,10
        }
    }
}
