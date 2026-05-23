namespace SelfCSharp.Chap05
{
    internal class DirectoryStaticProcess
    {
        static void Main(string[] args)
        {
            var dir = @"C:\data\SelfCSharp";
            Console.WriteLine(Directory.Exists(dir));
            Console.WriteLine(Directory.GetParent(dir));
            Console.WriteLine(Directory.GetDirectoryRoot(dir));
            Console.WriteLine(Directory.GetCreationTime(dir));
            Console.WriteLine(Directory.GetLastAccessTime(dir));
            Console.WriteLine(Directory.GetLastWriteTime(dir));

            var dirs = Directory.GetDirectories(dir);
            foreach (var d in dirs)
            {
                Console.WriteLine(d);
            }

            Directory.CreateDirectory(@"C:\data\smp");
            Directory.Move(@"C:\data\smp", @"C:\data\test");
            Directory.Move(@"C:\data\test", @"C:\data\SelfCSharp\test");
            Directory.Delete(@"C:\data\SelfCSharp\test");
        }
    }
}
