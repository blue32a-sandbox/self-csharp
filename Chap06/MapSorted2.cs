namespace SelfCSharp.Chap06
{
    internal class StringLengthComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return x.Length - y.Length;
        }
    }

    internal class MapSorted2
    {
        static void Main(string[] args)
        {
            var d = new SortedDictionary<string, string>(new StringLengthComparer())
            {
                ["Rose"] = "バラ",
                ["Sunflower"] = "ひまわり",
                ["Moring Glory"] = "あさがお",
            };

            foreach (var key in d.Keys)
            {
                Console.WriteLine($"{key}: {d[key]}");
            }
        }
    }
}
