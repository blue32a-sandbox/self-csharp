using System;

namespace SelfCSharp.Chap11
{
    internal class DynamicBasic
    {
        static void Main(string[] args)
        {
            dynamic d = 10; // 整数
            d = "ほげ"; // 文字列
            d.Hoge(); // string型にHogeメソッドはないのでエラー
        }
    }
}
