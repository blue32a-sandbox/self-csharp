namespace SelfCSharp.Chap02
{
    internal class FieldNew
    {
        // public SrtedDictionary<string, FileInfo> Map = new SortedDictionary<string, FileInfo>();
        public SortedDictionary<string, FileInfo> Map = new();

        static void Main(string[] args)
        {
            var dt = new DateTime(2022, 02, 15, 13, 17, 23);
            Console.WriteLine(dt); // 2022/02/15 13:17:23
            // new TimeSpan(3, 15, 30, 0)
            Console.WriteLine(dt.Add(new(3, 15, 30, 0))); // 2022/02/19 4:47:23
        }
    }
}
