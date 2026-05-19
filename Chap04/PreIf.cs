#define DEBUG

namespace SelfCSharp.Chap04
{
    internal class PreIf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("この行は常に表示されます。");
            #if DEBUG
            Console.WriteLine("デバッグ時にだけ表示します。");
            #endif
            Console.WriteLine("この行は常に表示されます。");
        }
    }
}
