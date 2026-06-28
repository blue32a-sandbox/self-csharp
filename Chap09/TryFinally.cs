using System;

namespace SelfCSharp.Chap09
{
    internal class TryFinally
    {
        static void Main(string[] args)
        {
            StreamReader? sr = null;
            try
            {
                sr = new StreamReader(@"C:\noting.dat");
                Console.WriteLine(sr.ReadToEnd());
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
