namespace SelfCSharp.Chap08.PublicField
{
    internal class  Triangle
    {
        // インスタンスフィールドを公開すると
        // * 読み書きを制御できない
        // * 値の妥当性をチェックできない
        // * 内部表現の変更に弱い
        public double width;
        public double height;

        public double GetArea()
        {
            return this.width * this.height / 2;
        }
    }

    internal class ClassField
    {
        static void Main(string[] args)
        {
            var t = new Triangle()
            {
                width = 20,
                height = 10
            };
            Console.WriteLine(t.GetArea());
        }
    }
}
