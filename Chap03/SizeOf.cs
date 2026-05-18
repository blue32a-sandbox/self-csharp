namespace SelfCSharp.Chap03
{
    internal class SizeOf
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sizeof(int)); // 4
            Console.WriteLine(sizeof(decimal)); // 16

            // unsafeモードを利用することで、参照型を含まない構造体やポインターのサイズを取得できる
            //unsafe
            //{
            //    Console.WriteLine(sizeof(MyStruct));
            //}
        }
    }
}
