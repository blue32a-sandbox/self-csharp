using System.Globalization;

namespace SelfCSharp.Chap05
{
    internal class StrFormat
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Format(
                "{0}は{1}、{2}歳です。", "サクラ", "女の子", 1)); // サクラは女の子、1歳です。

            Console.WriteLine(string.Format(
                "名前は{0}です。{0}は元気です。", "サクラ", "女の子")); // 名前はサクラです。サクラは元気です。

            Console.WriteLine(string.Format(
                "名前は{0, 5}です。", "サクラ")); // 名前は  サクラです。

            Console.WriteLine(string.Format(
                "名前は{0, -5}です。", "サクラ")); // 名前はサクラ  です。

            Console.WriteLine(string.Format(
                "10進数で8桁:{0:d8}", 12345)); // 10進数で8桁:00012345

            Console.WriteLine(string.Format(
                "指数:{0:e2}", 12345)); // 指数:1.23e+004

            Console.WriteLine(string.Format(
                "指数（大文字）:{0:E2}", 12345)); // 指数（大文字）:1.23E+004

            Console.WriteLine(string.Format(
                new CultureInfo("da-DK"), "通貨（デンマーク）:{0:C}", 12345)); // 通貨（デンマーク）:12.345,00 kr.

            Console.WriteLine(string.Format(
                "カスタム（0補完）:{0:0,000.000}", 1234.56)); // カスタム（0補完）:1,234.560

            Console.WriteLine(string.Format(
                "カスタム（補完なし）:{0:#,###.###}", 1234.56)); // カスタム（補完なし）:1,234.56

            Console.WriteLine(string.Format((
                "カスタム（複合）:{0,13:0,000.000}"), 1234.56)); // カスタム（複合）:    1,234.560

            Console.WriteLine(string.Format("日付:{0:D}", DateTime.Now)); // 日付:yyyy年mm月dd日

            var price = 1000;
            Console.WriteLine($"価格:{price:c}"); // 価格:\1,000
        }
    }
}
