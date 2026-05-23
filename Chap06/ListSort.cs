namespace SelfCSharp.Chap06
{
    internal class StringLengthComparer2 : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return x.Length - y.Length;
        }
    }

    internal class ListSort
    {
        static void Main(string[] args)
        {
            var list = new List<string>()
            {
                "バラ",
                "ひまわり",
                "あざみ",
            };

            list.Sort(new StringLengthComparer2());

            foreach (var s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
