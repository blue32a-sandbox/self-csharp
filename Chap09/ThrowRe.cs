namespace SelfCSharp.Chap09
{
    internal class ThrowRe
    {
        static void Main(string[] args)
        {
            try
            {
                using (var sr = new StreamReader(@"C:\noting.dat"))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("FileNotFoundExceptionをキャッチして再スロー");
                throw;

                // スタックトレースを上書きしてしまう
                //throw ex;
            }
        }
    }
}
