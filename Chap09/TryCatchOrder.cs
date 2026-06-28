namespace SelfCSharp.Chap09
{
    internal class TryCatchOrder
    {
        static void Main(string[] args)
        {
            try
            {
                using (var sr = new StreamReader(@"C:\nothing.dat"))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            // 先頭のExceptionクラスがすべての例外を補足してしまうためエラーになる
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.StackTrace);
            //}
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("ArgumentNullException");
                Console.WriteLine(ex.StackTrace);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("FileNotFoundException");
                Console.WriteLine(ex.StackTrace);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("ArgumentException");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
