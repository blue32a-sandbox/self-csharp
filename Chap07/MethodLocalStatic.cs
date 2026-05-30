namespace SelfCSharp.Chap07
{
    internal class MethodLocalStatic
    {
        int myfield = 0;
        static int myfield2 = 0;

        static void Main(string[] args)
        {
            var mylocal = 1;
            const int MY_CONST = 2;

            static void Hoge()
            {
                //Console.WriteLine(myfield); // エラー
                //Console.WriteLine(mylocal); // エラー
                Console.WriteLine(myfield2); // 0
                Console.WriteLine(MY_CONST); // 2
                Console.WriteLine(nameof(mylocal)); // mylocal
            }
            Hoge();
        }
    }
}
