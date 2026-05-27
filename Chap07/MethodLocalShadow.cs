namespace SelfCSharp.Chap07
{
    internal class MethodLocalShadow
    {
        static void Main(string[] args)
        {
            var msg = "Local Variable";

            void MyLocal()
            {
                var msg = "Inner Variable";
                // C# 8.0 以降では隠蔽とみなされ、名前の重複が許容される
                Console.WriteLine(msg); // Inner Variable
            }
            MyLocal();
            Console.WriteLine(msg); // Local Variable
        }
    }
}
