namespace SelfCSharp.Chap05
{
    internal class StreamWrite
    {
        static void Main(string[] args)
        {
            using (var writer = new StreamWriter(@"c:\data\data.log", true))
            {
                writer.WriteLine(DateTime.Now.ToString());
            }
        }
    }
}
