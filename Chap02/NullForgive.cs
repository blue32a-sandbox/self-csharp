namespace SelfCSharp.Chap02
{
    internal class NullForgive
    {
        static void Main(string[] args)
        {
            string?[] format = { "2022-12-25 10:16:23" };
            // nullである可能性があるので警告が発生する
            //var dt = DateTime.Parse(format[0]);

            if (format[0] is {  } item) // nullチェック
            {
                var dt1 = DateTime.Parse(item);
                Console.WriteLine(dt1);
            }

            // null免除演算子 !
            var dt2 = DateTime.Parse(format[0]!);
            Console.WriteLine(dt2);
        }
    }
}
