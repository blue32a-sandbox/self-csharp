using System;

namespace SelfCSharp.Chap09
{
    internal class ThrowExp
    {
        static void Main(string[] args)
        {
            var i = -10;
            Console.WriteLine(i > 0 ? i :
                throw new Exception("iは正数でなければいけません。"));
        }
    }
}
