namespace SelfCSharp.Chap08
{
    public interface IHoge
    {
        void Log(string msg)
        {
            Console.WriteLine($"Log: {msg}");
        }
    }

    public class Hoge : IHoge
    {
        // 明示的な実装を行うと、デフォルト実装は見えなくなる
        //public void Log(string msg)
        //{
        //    Console.WriteLine($"Hoge: {msg}");
        //}
    }

    internal class InterfaceDefault
    {
        static void Main(string[] args)
        {
            var h = new Hoge();

            // インターフェイス型に型キャストすることで、デフォルト実装を呼び出すことができる
            ((IHoge)h).Log("任意のメッセージ"); // Log: 任意のメッセージ
        }
    }
}
