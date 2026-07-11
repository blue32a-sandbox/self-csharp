namespace SelfCSharp.Chap10
{
    internal class LamdbaAccess
    {
        static void Main(string[] args)
        {
            var msg = "鈴木次郎";
            var show = () => { Console.WriteLine(msg); };
            show(); // 鈴木次郎
        }
    }
}
