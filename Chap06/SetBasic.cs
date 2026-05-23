namespace SelfCSharp.Chap06
{
    internal class SetBasic
    {
        static void Main(string[] args)
        {
            var hs = new HashSet<int> { 1, 20, 30, 60, 10, 15 };
            hs.Add(10);
            hs.Add(5);
            hs.Remove(60);

            foreach (var v in hs)
            {
                Console.WriteLine(v); // 1,20,30,10,15,5
            }

            Console.WriteLine(hs.Count); // 6
        }
    }
}
