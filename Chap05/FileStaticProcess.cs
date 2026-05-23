namespace SelfCSharp.Chap05
{
    internal class FileStaticProcess
    {
        static void Main(string[] args)
        {
            var file = @"C:\data\sample.txt";
            Console.WriteLine(File.Exists(file));
            Console.WriteLine(File.GetLastAccessTime(file));
            Console.WriteLine(File.GetLastWriteTime(file));

            // 上書きコピー
            File.Copy(file, @"C:\data\sample_copy.txt", true);

            // 移動
            File.Move(@"C:\data\sample_copy.txt", @"C:\data\SelfCSharp\sample_copy.txt");

            // リネーム
            File.Move(@"C:\data\SelfCSharp\sample_copy.txt", @"C:\data\SelfCSharp\sample_renamed.txt");

            // 削除
            File.Delete(@"C:\data\SelfCSharp\sample_renamed.txt");
        }
    }
}
