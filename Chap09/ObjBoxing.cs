namespace SelfCSharp.Chap09
{
    internal class ObjBoxing
    {
        static void Main(string[] args)
        {
            int data = 100;
            Console.WriteLine(data.ToString()); // Objectクラスのメンバーを利用できる
            object obj = data; // object型にも代入できる（ボックス化／ボクシング）
            Console.WriteLine(obj);

            int i = (int)obj; // 元の型に戻す（ボックス化解除／アンボクシング）
            Console.WriteLine(i);
        }
    }
}
