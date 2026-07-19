namespace SelfCSharp.Chap11
{
    internal class ReflectBasic
    {
        static void Main(string[] args)
        {
            // 引数なしのコンストラクター
            var tp = typeof(Person);
            var op = Activator.CreateInstance(tp);
            Console.WriteLine(op); // SelfCSharp.Chap11.Person

            // 引数ありのコンストラクター
            var tf = typeof(FileInfo);
            var cf = tf.GetConstructor(new[] { typeof(string) });
            var of = cf?.Invoke(new[] { @"c:\data\result.txt" });
            Console.WriteLine(of); // c:\data\result.txt
        }
    }
}
